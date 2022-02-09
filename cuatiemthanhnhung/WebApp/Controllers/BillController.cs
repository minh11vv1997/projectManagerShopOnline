using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObject.ViewModels;
using SharedObject.Extentions;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace WebApp.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillService billService;
        private readonly IBillDetailService billDetailService;
        private readonly IEmailService emailService;
        private readonly IHostingEnvironment hostingEnvironment;

        public BillController(IBillService billService, IBillDetailService billDetailService, IEmailService emailService, IHostingEnvironment hostingEnvironment)
        {
            this.billService = billService;
            this.billDetailService = billDetailService;
            this.emailService = emailService;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> CheckOut([FromBody] BillViewModel model)
        {
            model.BillId = Guid.NewGuid().ToString();
            var result = await billService.Add(model);
            if (result.StatusCode == 200)
            {
                var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.CartSession);
                if (session == null)
                {
                    session = new List<ShoppingCartViewModel>();
                }

                var billDetailViewModels = session.ConvertAll(s => new BillDetailViewModel()
                {
                    ProductName = s.Product.ProductName,
                    Price = s.Price,
                    Quantity = s.Quantity,
                    TotalMoney = s.TotalMoney,
                    BillId = model.BillId
                });
                var result2 = await billDetailService.Add(billDetailViewModels);
                if (result2.StatusCode == 200)
                {
                    var content = CreateEmailBody(billDetailViewModels, model.Total);
                    var emailResult = await emailService.SendEmail(new SendEmailViewModel { Body = content, SendTo = model.Email, Subject = "" });
                    if (emailResult.StatusCode == 200)
                    {
                        session = new List<ShoppingCartViewModel>();
                        HttpContext.Session.Set(CommonConstants.CartSession, session);

                    }

                }

                return Json(new { statusCode = result2.StatusCode });

            }
            else
            {
                return Json(new { statusCode = result.StatusCode });
            }

        }
        private string CreateEmailBody(List<BillDetailViewModel> model, decimal? total)
        {

            string body = "";
            for (int i = 0; i < model.Count; i++)
            {
                var path = Path.Combine(hostingEnvironment.WebRootPath, "template", "billdetail.html");

                string content = System.IO.File.ReadAllText(path);

                content = content.Replace("{{rc}}", "" + i);
                content = content.Replace("{{ProductName}}", model[i].ProductName);
                content = content.Replace("{{Price}}", "" + model[i].Price);
                content = content.Replace("{{Quantity}}", "" + model[i].Quantity);
                content = content.Replace("{{TotalMoney}}", "" + model[i].TotalMoney);
                body += content;
            }

            var path1 = Path.Combine(hostingEnvironment.WebRootPath, "template", "bill.html");

            string content1 = System.IO.File.ReadAllText(path1);
            

            content1 = content1.Replace("{{body}}", body);
            content1 = content1.Replace("{{total}}", ""+total+" Đ");
            return content1;


        }
    }
}
