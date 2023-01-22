using Microsoft.AspNetCore.Mvc;

namespace DarrenOdeToFood.Filters
{
    public class LogAttribute : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
