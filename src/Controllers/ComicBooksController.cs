using ComicBookGallery.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		public ActionResult Detail()
		{
			var comicBook = GetComicBook();

			return View(comicBook);
		}
	}
}
