using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SharedObject.Commons;
using SharedObject.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] RoleViewModel model)
        {
            IdentityRole role = new IdentityRole();

            role.Name = model.RoleName;
            var result = await roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return Ok(new ResponseResult(200));
            }
            else
            {
                return BadRequest(new ResponseResult(400));
            }

        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] RoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.RoleId);
            if (role == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                role.Name = model.RoleName;
                var result = await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return Ok(new ResponseResult(200));
                }
                else
                {
                    return BadRequest(new ResponseResult(400));
                }
            }

        }

        [HttpDelete("{roleName}")]
        public async Task<IActionResult> Delete(string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {

                var result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return Ok(new ResponseResult(200));
                }
                else
                {
                    return BadRequest(new ResponseResult(400));
                }
            }
        }
        [HttpGet("get-all")]
        public List<IdentityRole> GetAll()
        {

            var roles = roleManager.Roles.ToList();
            return roles;

        }

        [HttpGet("{roleId}")]

        public async Task<IdentityRole> GetById(string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);
            return role;
        }
        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole([FromBody] UserRoleViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                var result = await userManager.AddToRoleAsync(user, model.RoleName);
                if (result.Succeeded)
                {
                    return Ok(new ResponseResult(200));
                }
                else
                {
                    return BadRequest(new ResponseResult(400));
                }
            }

        }

        [HttpPost("remove-role")]
        public async Task<IActionResult> RemoveRole([FromBody] UserRoleViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                var result = await userManager.RemoveFromRoleAsync(user, model.RoleName);
                if (result.Succeeded)
                {
                    return Ok(new ResponseResult(200));
                }
                else
                {
                    return BadRequest(new ResponseResult(400));
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>

        [HttpGet("get-users-in-role/{roleName}")]
        public async Task<List<IdentityUser>> GetUsersInRole(string roleName)
        {
            var users = (await userManager.GetUsersInRoleAsync(roleName)).ToList();
            return users;
        }

        [HttpGet("get-users-not-in-role/{roleName}")]
        public async Task<List<IdentityUser>> GetUsersNotInRole(string roleName)
        {
            var users = userManager.Users.ToList();
            List<IdentityUser> usersNotInRole = new List<IdentityUser>();

            foreach (var item in users)
            {
                if (!await userManager.IsInRoleAsync(item, roleName))
                {
                    usersNotInRole.Add(item);
                }
            }
            return usersNotInRole;

        }


    }
}
