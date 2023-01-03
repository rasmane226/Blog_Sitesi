using Blog_Sitesi.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Blog_Sitesi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Blog_Sitesi.Controllers
{
    public class KayitController : Controller
    {
            Context c = new Context();
            [HttpGet]
            public IActionResult Kayityap()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Kayityap(Models.Kayit k)
            {
                c.kayits.Add(k);
                c.SaveChanges();
                return View();

            }
        
    }
}
