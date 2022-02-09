using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SharedObject.Commons;
using SharedObject.ViewModels;
using SharedObjects;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        
        private readonly IConfiguration configuration;

        public EmailController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [HttpPost("send-email")]
        public IActionResult SendEmail([FromBody] SendEmailViewModel model)
        {
            var fromAddress = new MailAddress(configuration["Email:From"], "Cửa tiệm thanh nhung");
            var toAddress = new MailAddress(model.SendTo);
            string fromPassword = configuration["Email:Password"];
            string subject = model.Subject;
            string body = model.Body;
            var smtp = new SmtpClient
            {
                Host = configuration["Email:Host"],
                Port = int.Parse( configuration["Email:Port"]),
                EnableSsl = bool.Parse( configuration["Email:EnableSsl"]),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                try
                {
                    smtp.Send(message);
                    return Ok(new ResponseResult (200));
                }
                catch (Exception ex)
                {
                    return Ok(new ResponseResult (400));
                }
            }
        }

    }
}