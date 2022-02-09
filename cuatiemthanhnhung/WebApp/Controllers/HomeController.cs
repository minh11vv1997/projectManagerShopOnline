using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.ViewModels;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        public async Task <IActionResult> Index()
        {
            var cates = await categoryService.GetAll();
            return View(cates);
        }
        [Route("gioi-thieu")]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }


    }
}
