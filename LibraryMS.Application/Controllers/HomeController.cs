using Microsoft.AspNetCore.Mvc;

namespace LibraryMS.Application.Controllers
{
	public class HomeController : Controller
	{
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
