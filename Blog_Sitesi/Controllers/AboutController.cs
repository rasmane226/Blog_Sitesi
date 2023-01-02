using Microsoft.AspNetCore.Mvc;

namespace Blog_Sitesi.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
