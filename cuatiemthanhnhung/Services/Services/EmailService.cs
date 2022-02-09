using Newtonsoft.Json;
using Services.Interfaces;
using SharedObject.Commons;
using SharedObject.ViewModels;
using SharedObjects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Services.Services
{
    public class EmailService : BaseService, IEmailService
    {
        public async Task<ResponseResult> SendEmail(SendEmailViewModel model)
        {
           
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/email/send-email", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

 
    }
}
