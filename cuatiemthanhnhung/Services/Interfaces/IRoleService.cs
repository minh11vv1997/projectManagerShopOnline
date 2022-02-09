using Microsoft.AspNetCore.Identity;
using SharedObject.Commons;
using SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRoleService
    {
        Task<ResponseResult> Add(RoleViewModel model, string token);

        Task<ResponseResult> Update(RoleViewModel model, string token);

        Task<ResponseResult> Delete(string roleName, string token);

        Task<List<IdentityRole>> GetAll(string token);

        Task<IdentityRole> GetById(string token, string RoleId);

        Task<ResponseResult> AssignRole(UserRoleViewModel model, string token);

        Task<ResponseResult> RemoveRole(UserRoleViewModel model, string token);

        Task<List<IdentityUser>> GetUsersInRole(string roleName, string token);

        Task<List<IdentityUser>> GetUsersNotInRole(string roleName, string token);

    }
}
