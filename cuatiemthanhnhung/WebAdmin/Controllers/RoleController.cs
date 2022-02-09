using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObject.Extentions;
using SharedObject.ViewModels;

namespace WebAdmin.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService roleService;

        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }
        public IActionResult Role()
        {
            return View();
        }
        public async Task<IActionResult> GetAll_Pta()
        {

            var token = User.GetSpecificClaim("token");

            var roles = await roleService.GetAll(token);
            return PartialView(roles);
        }
        public async Task<IActionResult> GetById(string id)
        {
            string token = User.GetSpecificClaim("token");

            var role = await roleService.GetById(token, id);
            return Json(new { result = role });

        }
        public async Task<IActionResult> Delete(string id)
        {
            string token = User.GetSpecificClaim("token");

            var responseResult = await roleService.Delete(id, token);
            return Json(new { result = responseResult });

        }

        public IActionResult ManageRole(string rolename)
        {
            ViewBag.RoleName = rolename;
            return View();

        }
        public async Task<IActionResult> GetUsersInRole(string roleName)
        {
            var token = User.GetSpecificClaim("token");
            var users = await roleService.GetUsersInRole(roleName, token);
            return PartialView(users);

        }

        public async Task<IActionResult> GetUsersNotInRole(string roleName)
        {
            var token = User.GetSpecificClaim("token");
            var users = await roleService.GetUsersNotInRole(roleName, token);
            return PartialView(users);

        }
        public async Task<IActionResult> AssignRole([FromBody] UserRoleViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await roleService.AssignRole(model, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<IActionResult> RemoveRole([FromBody] UserRoleViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await roleService.RemoveRole(model, token);
            return Json(new { statusCode = result.StatusCode });

        }
        public async Task<IActionResult> Save([FromBody] RoleViewModel model)
        {
            string token = User.GetSpecificClaim("token");
            if (string.IsNullOrEmpty(model.RoleId))
            {
                var result = await roleService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { result = 1 });
                }
                else
                {
                    return Json(new { result = 0 });
                }
            }
            else
            {
                var result = await roleService.Update(model, token);
                if (result.StatusCode == 200)
                {
                    return Json(new { result = 2 });
                }
                else
                {
                    return Json(new { result = 0 });
                }
            }
        }
    }
}
