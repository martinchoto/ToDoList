using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
	public class ToDoListController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
