using Blog_Sitesi.Models;
using Blog_Sitesi.Models.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Blog_Sitesi.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Girisyap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Girisyap(Login loginModel)
        {
            var datavalue = c.logins.FirstOrDefault(x => x.username == loginModel.username
           && x.password == loginModel.password);
            if (datavalue != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.username)
            };

                var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                //Just redirect to our index after logging in. 
                return RedirectToAction("home", "Home");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Girisyap");
        }

    }
}   

