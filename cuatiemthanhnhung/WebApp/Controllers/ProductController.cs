using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.ViewModels;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        [Route("san-pham")]
        public async Task<IActionResult> Product()
        {
            var categories = await categoryService.GetAll();
            return View(categories);
        }

        public async Task<IActionResult> GetPagination_Pta([FromBody] PaginationProductViewModel model)
        {
            var result = await productService.GetPagination(model);
            return PartialView(result);
        }
        public async Task<JsonResult> CountPagination([FromBody] PaginationProductViewModel model)
        {
            int count = await productService.CountPagination(model);
            return Json(new { result = count });
        }
        [Route("chi-tiet-san-pham/{KeyCode}/{SeoTittle}")]
        public async Task<IActionResult> ProductDetail(int KeyCode)
        {
            var product = await productService.GetByKeyCode(KeyCode);
            var category = await categoryService.GetById(""+ product.CategoryId);
            ViewBag.Category = category;
            return View(product);
        }
    }
}
