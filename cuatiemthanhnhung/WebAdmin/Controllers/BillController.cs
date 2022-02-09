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
    public class BillController : Controller
    {
        private readonly IBillService _billService;
        private readonly IBillDetailService billDetailService;

        public BillController(IBillService billService, IBillDetailService billDetailService)
        {
            _billService = billService;
            this.billDetailService = billDetailService;
        }

        public IActionResult Bill()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] BillViewModel model)
        {

            string token = User.GetSpecificClaim("token");

           var result = await _billService.Update(model, token);
              return Json(new { statusCode = (result.StatusCode) });

        }
        [Authorize(Roles = "Admin")]
        public async Task<JsonResult> Delete(string id)
        {

            string token = User.GetSpecificClaim("token");
            var result = await _billService.Delete(id, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<JsonResult> GetById(string id)
        {
            var cate = await _billService.GetById(id);
            return Json(new { result = cate });

        }
        public async Task<IActionResult> GetBillDetail_Pta(string id)
        {
            var billdetails = await billDetailService.GetByBillId(id);
            return PartialView(billdetails);

        }
        public async Task<IActionResult> GetPagination_Pta([FromBody] PaginationBillViewModel model)
        {
            var result = await _billService.GetPagination(model);
            return PartialView(result);
        }
        public async Task<JsonResult> CountPagination([FromBody] PaginationBillViewModel model)
        {
            int count = await _billService.CountPagination(model);
            return Json(new { result = count });
        }

        
    }
}