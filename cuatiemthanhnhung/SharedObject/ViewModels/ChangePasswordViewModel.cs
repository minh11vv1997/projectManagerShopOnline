using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedObject.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DisplayName ("Tên tài khoản")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Mật khẩu hiện tại")]
        public string CurrentPassword { get; set; }
        [Required]
        [DisplayName("Mật khẩu mới")]
        public string NewPassword { get; set; }
        [DisplayName("Nhập lại mật khẩu mới")]
        [Compare("NewPassword", ErrorMessage = "Nhập lại mật khẩu không đúng")]
        public string ComfirmPassword { get; set; }
    }
}
