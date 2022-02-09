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

namespace Management.Controllers
{
    [Authorize]
    public class InformationController : Controller
    {
        private readonly IInformationService _InformationService;
        public InformationController(IInformationService InformationService)
        {
            _InformationService = InformationService;
        }
        
        public IActionResult Information()
        {
            return View();
        }
        public async Task<IActionResult> GetPagination_Pta()
        {

            var result = await  _InformationService.GetAll();
            return PartialView(result);
        }


        [HttpPost]
        public async Task<IActionResult> Save([FromBody] InformationViewModel model)
        {
            string token = User.GetSpecificClaim("token");
            ResponseResult result = new ResponseResult();
            if (string.IsNullOrEmpty(model.InformationId))
            {
                result = await _InformationService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 1 });

                }
                return Json(new { statusCode = 0 });
            }
            else
            {
                result = await _InformationService.Update(model, token);
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
            var result = await _InformationService.Delete(id, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<JsonResult> GetById(string id)
        {
           
            var cate = await _InformationService.GetById(id);
            return Json(new { result = cate });

        }
    }
}