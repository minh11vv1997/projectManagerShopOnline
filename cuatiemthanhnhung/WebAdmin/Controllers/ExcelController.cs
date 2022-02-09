using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using Services.Interfaces;
using SharedObject.ViewModels;

namespace WebAdmin.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IProductService productService;

        public ExcelController(IHostingEnvironment hostingEnvironment, IProductService productService)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.productService = productService;
        }

        [Route("exportEx")]
        public async Task<IActionResult> ExportExcel()
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
            var products = await productService.GetPagination(new PaginationProductViewModel {PageIndex= 0, PageSize = 5 });
            using (ExcelPackage package = new ExcelPackage(file))
            {
                // add a new worksheet to the empty workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Products");
                worksheet.Cells["A1"].LoadFromCollection(products, true, TableStyles.Light1);
                worksheet.Cells.AutoFitColumns();
                package.Save(); //Save the workbook.
            }
            return Redirect(fileUrl);
        }
        //[HttpPost]
        //public IActionResult ImportExcel(IList<IFormFile> files, int categoryId)
        //{
        //    if (files != null && files.Count > 0)
        //    {
        //        var file = files[0];
        //        var filename = ContentDispositionHeaderValue
        //                           .Parse(file.ContentDisposition)
        //                           .FileName
        //                           .Trim('"');

        //        string folder = hostingEnvironment.WebRootPath + $@"\uploaded\excels";
        //        if (!Directory.Exists(folder))
        //        {
        //            Directory.CreateDirectory(folder);
        //        }
        //        string filePath = Path.Combine(folder, filename);

        //        using (FileStream fs = System.IO.File.Create(filePath))
        //        {
        //            file.CopyTo(fs);
        //            fs.Flush();
        //        }
        //        productService.ImportExcel(filePath, categoryId);
            
        //        return new OkObjectResult(filePath);
        //    }
        //    return new NoContentResult();
        //}
    }
}
