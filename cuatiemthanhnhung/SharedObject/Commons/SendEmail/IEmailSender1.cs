using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SharedObject.Commons.SendEmail
{
    public interface IEmailSender1
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
