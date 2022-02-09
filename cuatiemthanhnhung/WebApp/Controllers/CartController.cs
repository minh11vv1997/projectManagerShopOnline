using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObject.Extentions;
using SharedObject.ViewModels;

namespace WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }
        [Route("gio-hang")]
        public IActionResult Cart()
        {
            return View();
        }


        public IActionResult GetCart_Pta()
        {
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.CartSession);
            if (session == null)
                session = new List<ShoppingCartViewModel>();
            return PartialView(session);
        }
        public IActionResult UpdateCartViewComponent()
        {

            return ViewComponent("Cart");
        }
        public IActionResult ClearCart()
        {
            HttpContext.Session.Remove(CommonConstants.CartSession);
            return new OkObjectResult("OK");
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(string productId)
        {
            //Get product detail
            var product = await productService.GetById(productId);

            //Get session with item list from cart
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.CartSession);
            if (session != null)
            {
                //Convert string to list object
                bool hasChanged = false;

                //Check exist with item product id
                if (session.Any(x => x.Product.ProductId == Guid.Parse(productId)))
                {
                    foreach (var item in session)
                    {
                        //Update quantity for product if match product id
                        if (item.Product.ProductId == Guid.Parse(productId))
                        {
                            item.Quantity += 1;
                            hasChanged = true;
                            item.TotalMoney = item.Quantity * item.Price;
                        }
                    }
                }
                else
                {
                    session.Add(new ShoppingCartViewModel()
                    {
                        Product = product,
                        Quantity = 1,
                        Price = product.Price,
                        TotalMoney = product.Price
                    });
                    hasChanged = true;
                }

                //Update back to cart
                if (hasChanged)
                {
                    HttpContext.Session.Set(CommonConstants.CartSession, session);
                }
            }
            else
            {
                //Add new cart
                var cart = new List<ShoppingCartViewModel>();
                cart.Add(new ShoppingCartViewModel()
                {
                    Product = product,
                    Quantity = 1,
                    Price = product.Price,
                    TotalMoney = product.Price
                });
                HttpContext.Session.Set(CommonConstants.CartSession, cart);
            }
            return new OkObjectResult(productId);
        }
        public IActionResult RemoveFromCart(string productId)
        {
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.CartSession);
            if (session != null)
            {
                bool hasChanged = false;
                foreach (var item in session)
                {
                    if (item.Product.ProductId == Guid.Parse(productId))
                    {
                        session.Remove(item);
                        hasChanged = true;
                        break;
                    }
                }
                if (hasChanged)
                {
                    HttpContext.Session.Set(CommonConstants.CartSession, session);
                }
                return new OkObjectResult(productId);
            }
            return new EmptyResult();
        }


        public IActionResult UpdateCart([FromBody] UpdateQuantityViewModel model)
        {
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.CartSession);
            if (session != null)
            {
                bool hasChanged = false;
                foreach (var item in session)
                {
                    if (item.Product.ProductId == Guid.Parse(model.ProductId))
                    {
                        item.Quantity = model.Quantity;
                        item.TotalMoney = item.Quantity * item.Price;
                        hasChanged = true;
                    }
                }
                if (hasChanged)
                {
                    HttpContext.Session.Set(CommonConstants.CartSession, session);
                }
                var money = SumMoney();
                return Json(new { total= money });
            }
            return Json(new { total = 0 });
        }

        public IActionResult CaculateTotalMoney()
        {
            var total = SumMoney();
            return Json(new { result = total });
        }




        private decimal SumMoney()
        {
            decimal total = 0;
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.CartSession);
            if (session == null)
            {
                return 0;
            }
            else
            {
                foreach (var item in session)
                {
                    var amount = item.TotalMoney ?? 0;
                    total += amount;
                }
                return total;
            }

        }
    }
}
