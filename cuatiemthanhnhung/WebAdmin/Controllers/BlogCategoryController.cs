using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedObject.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects;

using SharedObject.ViewModels;
using SharedObject.Commons;

namespace WebAdmin.Controllers
{
    [Authorize]
    public class BlogCategoryController : Controller
    {
        private readonly IBlogCategoryService _blogCategoriesService;
        public BlogCategoryController(IBlogCategoryService blogCategoriesService)
        {
            _blogCategoriesService = blogCategoriesService;
        }

      
        public IActionResult BlogCategory()
        {
           
            return View();
        }
        public async Task<IActionResult> GetAll_Pta()
        {
            var result = await _blogCategoriesService.GetAll();
            return PartialView(result);
        }
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] BlogCategoryViewModel model)
        {
            string token = User.GetSpecificClaim("token");
            ResponseResult result = new ResponseResult();
            if (string.IsNullOrEmpty(model.BlogCateId))
            {
                result = await _blogCategoriesService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 1 });

                }
                return Json(new { statusCode = 0 });
            }
            else
            {
                result = await _blogCategoriesService.Update(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 2 });

                }
                return Json(new { statusCode = 0 });

            }

        }
        [Authorize(Roles = "Admin")]
        public async Task<JsonResult> Delete(string id)
        {

            string token = User.GetSpecificClaim("token");
            var result = await _blogCategoriesService.Delete(id, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<JsonResult> GetById(string id)
        {
            var cate = await _blogCategoriesService.GetById(id);
            return Json(new { result = cate });

        }
    }
}