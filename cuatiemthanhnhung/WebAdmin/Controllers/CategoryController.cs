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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoriesService;
        public CategoryController(ICategoryService categoriesService)
        {
            _categoriesService = categoriesService;
        }

     
        public IActionResult Category()
        {
           
            return View();
        }
        // Dùng partialView khi dùng đỡ phải load lại trang
        public async Task<IActionResult> GetAll_Pta()
        {
            var result = await _categoriesService.GetAll();
            return PartialView(result);
        }
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] CategoryViewModel model)
        {
            string token = User.GetSpecificClaim("token");
            ResponseResult result = new ResponseResult();
            if (string.IsNullOrEmpty(model.CategoryId))
            {
                result = await _categoriesService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 1 });

                }
                return Json(new { statusCode = 0 });
            }
            else
            {
                result = await _categoriesService.Update(model, token);
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
            var result = await _categoriesService.Delete(id, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<JsonResult> GetById(string id)
        {
            var cate = await _categoriesService.GetById(id);
            return Json(new { result = cate });

        }
    }
}