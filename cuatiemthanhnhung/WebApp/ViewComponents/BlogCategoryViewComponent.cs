using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObject.Extentions;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewComponents
{
    public class BlogCategoryViewComponent : ViewComponent
    {
        private readonly IBlogCategoryService blogCategoryService;

        public BlogCategoryViewComponent( IBlogCategoryService blogCategoryService)
        {
            this.blogCategoryService = blogCategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cates = await blogCategoryService.GetAll();
           
            return View(cates);
        }
        
    }
}
