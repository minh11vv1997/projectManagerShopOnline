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
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace WebAdmin.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _ProductService;
        private readonly ICategoryService categoriesService;
        private readonly IHostingEnvironment hostingEnvironment;

        public ProductController(IProductService ProductService, ICategoryService categoriesService, IHostingEnvironment hostingEnvironment)
        {
            _ProductService = ProductService;
            this.categoriesService = categoriesService;
            this.hostingEnvironment = hostingEnvironment;
        }
      
        public async Task<IActionResult> Product()
        {
            var categories = await categoriesService.GetAll();
        
            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] ProductViewModel model)
        {

            string token = User.GetSpecificClaim("token");
            
            ResponseResult result = new ResponseResult();
            if (string.IsNullOrEmpty(model.ProductId))
            {
               
                result = await _ProductService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { statusCode = 1});

                }
                return Json(new { statusCode = 0 });
            }
            else
            {
                result = await _ProductService.Update(model, token);
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
            var result = await _ProductService.Delete(id, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<JsonResult> GetById(string id)
        {
            var cate = await _ProductService.GetById(id);
            return Json(new { result = cate });

        }
        public async Task<IActionResult> GetPagination_Pta([FromBody]PaginationProductViewModel model)
        {
            var result = await _ProductService.GetPagination(model);
            return PartialView(result);
        }
        public async Task<JsonResult> CountPagination([FromBody] PaginationProductViewModel model)
        {
            int count = await _ProductService.CountPagination(model);
            return Json(new { result = count });
        }
        public async Task<IActionResult> ExportExcel([FromBody] PaginationProductViewModel model)
        {
            string sWebRootFolder = hostingEnvironment.WebRootPath;
            string directory = Path.Combine(sWebRootFolder, "export-files");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string sFileName = $"Product_{DateTime.Now:yyyyMMddhhmmss}.xlsx";
            string fileUrl = $"{Request.Scheme}://{Request.Host}/export-files/{sFileName}";
            FileInfo file = new FileInfo(Path.Combine(directory, sFileName));
            if (file.Exists)
            {
                file.Delete();
                file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            }
            var products = await _ProductService.GetPagination(model);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                // add a new worksheet to the empty workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Products");
                worksheet.Cells["A1"].LoadFromCollection(products, true, TableStyles.Light1);
                worksheet.Cells.AutoFitColumns();
                package.Save(); //Save the workbook.
            }
            return Json(new{ result = fileUrl});
        }
    }
}