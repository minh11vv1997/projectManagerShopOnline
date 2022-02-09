using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SharedObject.Commons;
using SharedObject.ViewModels;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes ="Bearer")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IConfiguration configuration;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateUserViewModel model)
        {
            IdentityUser user = new IdentityUser();
            user.Email = model.Email;
            user.UserName = model.UserName;

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok(new ResponseResult(200));
            }
            else
            {
                List<string> notfications = new List<string>();
                foreach (var item in result.Errors)
                {
                    notfications.Add(item.Description);
                }
                return BadRequest(new ResponseResult(400, notfications));
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                var result = await userManager.UpdateAsync(user);
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
        [Authorize(Roles = "Admin")]
        [HttpDelete("{userName}")]
        public async Task<IActionResult> Delete(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                var result = await userManager.DeleteAsync(user);
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

        [Authorize(Roles = "Admin")]
        [HttpGet("get-all")]
        public List<IdentityUser> GetAll()
        {
            var users = userManager.Users.ToList();
            return users.OrderBy(s => s.UserName).ToList();
        }
        [HttpGet("get-by-name/{userName}")]
        public async Task<IdentityUser> GetByUserName(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            return user;
        }
        /// <summary>
        /// Inportaint API
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    // start create claims

                    var roles = (await userManager.GetRolesAsync(user)).ToList();

                    string strRole = "";

                    foreach (var item in roles)
                    {
                        strRole += item;
                    }

                    List<Claim> infomationClaim = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim("Email", user.Email),
                        new Claim("Id", user.Id),
                        new Claim("StrRole", strRole)
                    };
                    // create the calimIdentity to store these claims
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(infomationClaim);

                    List<Claim> rolesClaim = new List<Claim>();
                    foreach (var item in roles)
                    {
                        rolesClaim.Add(new Claim(ClaimTypes.Role, item));
                    }

                    claimsIdentity.AddClaims(rolesClaim);


                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken
                    (
                        configuration["Jwt:Issuer"],
                        configuration["Jwt:Audience"],
                        claimsIdentity.Claims,
                        expires: DateTime.UtcNow.AddDays(1),
                        signingCredentials: signIn);
                    string strToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(new ResponseResult(200, strToken));
                }
                else
                {
                    return NotFound(new ResponseResult(404));
                }
            }
        }
        [Authorize(Roles = "Admin, Operator")]
        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    return Ok(new ResponseResult(200));
                }
                else
                {
                    List<string> errors = new List<string>();
                    foreach (var item in result.Errors)
                    {
                        errors.Add(item.Description);
                    }
                    return BadRequest(new ResponseResult(400, errors));

                }
            }

        }
    }
}
