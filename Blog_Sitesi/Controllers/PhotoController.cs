using Microsoft.AspNetCore.Mvc;

namespace Blog_Sitesi.Controllers
{
    public class PhotoController : Controller
    {
        public IActionResult photo()
        {
            return View();
        }
    }
}
