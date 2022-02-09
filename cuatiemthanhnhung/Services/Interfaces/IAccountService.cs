using Microsoft.AspNetCore.Identity;
using SharedObject.Commons;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAccountService
    {
        Task<ResponseResult> Add(CreateUserViewModel model, string token);

        Task<ResponseResult> Update(UpdateUserViewModel model, string token);
        Task<ResponseResult> ChangePassword(ChangePasswordViewModel model, string token);

        Task<ResponseResult> Delete(string userName, string token);

        Task<List<IdentityUser>> GetAll(string token);

        Task<IdentityUser> GetByName(string token, string userName);

        Task<ResponseResult> Login(LoginViewModel model);

    }
}
