using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedObject.Commons;
using SharedObject.Extentions;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var session =  HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.CartSession);
            if (session == null)
            {
                ViewBag.Count = 0;
            }
            else
            {
                int count = 0;
                foreach (var item in session)
                {
                    count += item.Quantity;
                }
                ViewBag.Count = count;
            }
           
            return View();
        }
        
    }
}
