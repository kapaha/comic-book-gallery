using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
	public class HomeController : Controller
	{
		public string Index()
		{
			return "Hello From Home";
		}
	}
}
