using SharedObject.Commons;
using SharedObject.ViewModels;
using SharedObjects;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
  public  interface IEmailService
    {
        Task<ResponseResult> SendEmail(SendEmailViewModel model);
       
    }
}
