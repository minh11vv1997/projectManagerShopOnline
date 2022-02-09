using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects;

using SharedObject.ViewModels;
using SharedObject.Extentions;
using SharedObject.Commons;

namespace WebAdmin.Controllers
{
    public class BlogDetailController : Controller
    {

        private readonly IBlogDetailService _BlogDetailService;
        private readonly IBlogService blogService;

        public BlogDetailController(IBlogDetailService BlogDetailService, IBlogService blogService)
        {
            _BlogDetailService = BlogDetailService;
            this.blogService = blogService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> BlogDetail(string id)
        {
            var result = await _BlogDetailService.GetByBlogId(id);
            ViewBag.Blog = (await blogService.GetById(id));
            return View(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult EditBlogDetail(string blogDetailId, string blogId)
        {
            ViewBag.BlogId = blogId;
            if (string.IsNullOrEmpty(blogDetailId))
            {
                ViewBag.BlogDetailId = "";
            }
            else
            {
                ViewBag.BlogDetailId = blogDetailId;
            }
            
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] BlogDetailViewModel model)
        {
            string token = User.GetSpecificClaim("token");
            ResponseResult result = new ResponseResult();
            if (string.IsNullOrEmpty(model.BlogDetailId))
            {
                result = await _BlogDetailService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 1 });

                }
                else
                {
                    return Json(new { statusCode = 0 });
                }
               
            }
            else
            {
                result = await _BlogDetailService.Update(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 2 });

                }
                else
                {
                    return Json(new { statusCode = 0 });
                }


            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<JsonResult> Delete(string id)
        {

            string token = User.GetSpecificClaim("token");
            var result = await _BlogDetailService.Delete(id, token);
            return Json(new { statusCode = result.StatusCode });

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<JsonResult> GetById(string id)
        {
            var cate = await _BlogDetailService.GetById(id);
            return Json(new { result = cate });
        }

       
    }
}
