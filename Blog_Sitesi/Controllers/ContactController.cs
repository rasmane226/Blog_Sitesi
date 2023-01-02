using Microsoft.AspNetCore.Mvc;

namespace Blog_Sitesi.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult contact()
        {
            return View();
        }
    }
}
