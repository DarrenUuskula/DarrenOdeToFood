using OdeToFood.Models;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using System.Diagnostics;

namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			var controller = RouteData.Values["controller"];
			var action = RouteData.Values["action"];
			var id = RouteData.Values["id"];

			ViewBag.Message = $"{controller}::{action} {id}";

			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		public IActionResult About()
		{
			var model = new AboutModel();
			model.Name = "Darren";
			model.Location = "Tallinn, Estonia";
			return View(model);
		}
	}
}