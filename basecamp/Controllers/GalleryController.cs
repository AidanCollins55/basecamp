using Microsoft.AspNetCore.Mvc;

namespace basecamp.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
