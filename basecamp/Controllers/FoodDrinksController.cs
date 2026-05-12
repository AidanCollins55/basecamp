using Microsoft.AspNetCore.Mvc;

namespace basecamp.Controllers
{
    public class FoodDrinksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
