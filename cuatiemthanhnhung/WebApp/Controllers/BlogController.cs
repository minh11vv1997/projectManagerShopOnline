using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.ViewModels;

namespace WebApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService blogService;
        private readonly IBlogCategoryService blogCategoryService;
        private readonly IBlogDetailService blogDetailService;

        public BlogController(IBlogService blogService, IBlogCategoryService blogCategoryService, IBlogDetailService blogDetailService)
        {
            this.blogService = blogService;
            this.blogCategoryService = blogCategoryService;
            this.blogDetailService = blogDetailService;
        }
        
        public async Task<IActionResult> Blog(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Id = "";
            }
            else
            {
                ViewBag.Id = id;
            }
            var categories = await blogCategoryService.GetAll();
            var recentBlog = await blogService.GetPagination(new PaginationBlogViewModel { PageSize = 5, PageIndex = 0 });
            ViewBag.RecentBlog = recentBlog;
            return View(categories);

        }
        public async Task<IActionResult> GetPagination_Pta([FromBody] PaginationBlogViewModel model)
        {
            var result = await blogService.GetPagination(model);
            return PartialView(result);
        }
        public async Task<JsonResult> CountPagination([FromBody] PaginationBlogViewModel model)
        {
            int count = await blogService.CountPagination(model);
            return Json(new { result = count });
        }

        [Route("chi-tiet-bai-viet/{KeyCode}/{SeoTittle}")]
        public async Task<IActionResult> BlogDetail(int KeyCode)
        {
            var blog = await blogService.GetByKeyCode(KeyCode);
            var blogDetail = await blogDetailService.GetByBlogId("" + blog.BlogId);
            ViewBag.BlogDetail = blogDetail;
            var categories = await blogCategoryService.GetAll();
            ViewBag.Category = categories;
            var recentBlog = await blogService.GetPagination(new PaginationBlogViewModel { PageSize = 5, PageIndex = 0 });
            ViewBag.RecentBlog = recentBlog;
            return View(blog);
        }
    }
}
