using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using SharedObject.Extentions;
using SharedObject.ViewModels;

namespace WebAdmin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;
        private readonly IConfiguration configuration;

        public AccountController(IAccountService accountService, IConfiguration configuration)
        {
            this.accountService = accountService;
            this.configuration = configuration;
        }


        private ClaimsPrincipal ValidateToken(string token)
        {
            IdentityModelEventSource.ShowPII = true;
            SecurityToken validateToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();
            validationParameters.ValidateLifetime = true;
            validationParameters.ValidAudience = configuration["Jwt:Audience"];
            validationParameters.ValidIssuer = configuration["Jwt:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out validateToken);



            List<Claim> claims = new List<Claim>() { new Claim("token", token), };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims);

            principal.AddIdentity(claimsIdentity);

            return principal;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();

        }
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var responseResult = await accountService.Login(model);
            if (responseResult.StatusCode == 200)
            {
                var userPrincipal = this.ValidateToken(responseResult.Message);
                var authProperty = new AuthenticationProperties
                {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(2),
                    IsPersistent = model.RememberMe

                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperty);
                return Redirect("/");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Sai tên đăng nhập hoặc mật khẩu!");
                return View(model);
            }
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Account/Login");

        }
        public async Task<IActionResult> GetAll()
        {
            var token = User.GetSpecificClaim("token");
            var users = await accountService.GetAll(token);
            return View(users);

        }
        public IActionResult Add()
        {

            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Add(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                var token = User.GetSpecificClaim("token");
                var result = await accountService.Add(model, token);
                if (result.StatusCode == 200)
                {
                    return Redirect("/Account/GetAll");
                }
                else
                {
                    foreach (var item in result.Notifications)
                    {
                        ModelState.AddModelError("", item);
                    }
                    return View(model);
                }
            }

        }
        [HttpPost]
        public async Task<IActionResult> GetByName(string username)
        {
            var token = User.GetSpecificClaim("token");
            var user = await accountService.GetByName(token, username);
            return Json(new { result = user });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] UpdateUserViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await accountService.Update(model, token);
            return Json(new { statusCode = result.StatusCode });

        }
        [HttpPost]

        public async Task<IActionResult> Delete(string username)
        {
            var token = User.GetSpecificClaim("token");
            var result = await accountService.Delete(username, token);
            return Json(new { statusCode = result.StatusCode });
        }
        [HttpGet]
        public IActionResult ChangePassword(string userName)
        {
            ViewBag.UserName = userName;
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                var result = await accountService.ChangePassword(model, token);
                if (result.StatusCode == 400)
                {
                    foreach (var item in result.Notifications)
                    {
                        ModelState.AddModelError("", item);
                    }
                    return View(model);
                }
                else if (result.StatusCode == 404)
                {
                    ModelState.AddModelError("", "Sai tên tài khoản");
                    return View(model);
                }
                else
                {
                    TempData["Message"] = "Đổi password thành công";
                    return Redirect("/Home/Index");
                }
            }
        }




    }
}
