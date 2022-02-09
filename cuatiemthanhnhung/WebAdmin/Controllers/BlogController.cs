using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects;


using SharedObject.ViewModels;
using SharedObject.Extentions;
using SharedObject.Commons;

namespace WebAdmin.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IBlogCategoryService _blogCategoriesService;
        public BlogController(IBlogService blogService, IBlogCategoryService blogCategoriesService)
        {
            _blogService = blogService;
            _blogCategoriesService = blogCategoriesService;
        }
    
        public async Task<IActionResult> Blog()
        {
            var blogcategories = await _blogCategoriesService.GetAll();
            return View(blogcategories);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] BlogViewModel model)
        {

            string token = User.GetSpecificClaim("token");
            model.UserId = User.GetSpecificClaim("Id");
            ResponseResult result = new ResponseResult();
            if (string.IsNullOrEmpty(model.BlogId))
            {
                model.BlogId = "" + Guid.NewGuid();
               
                result = await _blogService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 1, blogId = model.BlogId });

                }
                return Json(new { statusCode = 0 });
            }
            else
            {
                result = await _blogService.Update(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 2 });

                }
                return Json(new { statusCode = 0 });

            }

        }
        [Authorize(Roles ="Admin")]
        public async Task<JsonResult> Delete(string id)
        {

            string token = User.GetSpecificClaim("token");
            var result = await _blogService.Delete(id, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<JsonResult> GetById(string id)
        {
            var cate = await _blogService.GetById(id);
            return Json(new { result = cate });

        }
        public async Task<IActionResult> GetPagination_Pta([FromBody]PaginationBlogViewModel model)
        {
            var result = await _blogService.GetPagination(model);
            var result2 = result;
            return PartialView(result2);
        }
        public async Task<JsonResult> CountPagination([FromBody] PaginationBlogViewModel model)
        {
            int count = await _blogService.CountPagination(model);
            return Json(new { result = count });
        }

        public async Task<IActionResult> WriteBlog(string id)
        {
            var blogcategories = await _blogCategoriesService.GetAll();
           
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.BlogId = "";
            }
            else
            {
                ViewBag.BlogId = id;
            }
            return View(blogcategories);

        }
    }
}