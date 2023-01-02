using Blog_Sitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog_Sitesi.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult home()
        {
            return View();  
        }
    }
}