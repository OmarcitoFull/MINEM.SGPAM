using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.ClienteInterno.Helpers;
using Minem.Sgpam.ClienteInterno.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    public class IntroController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var vRecord = new SessionUserModel();
                vRecord.SystemID = 666;
                vRecord.UserId = 1;
                vRecord.UserName = "OMAR RODRIGUEZ M.";
                vRecord.SessionName = "ORODRIGUEZ";
                vRecord.Roles = new List<UserRolesUserModel>();
                vRecord.Roles.Add(new UserRolesUserModel { RoleId = 1, RoleName = "ADMINISTRADOR" });

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, IdentityGenerator.Execute(vRecord), new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.Now.AddHours(8),
                    IsPersistent = true
                });
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpGet]
        public async Task<IActionResult> SignOff()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
