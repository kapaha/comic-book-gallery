using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public string Detail()
        {
            return "<h1>Hello from the comic books  controller!</h1>";
        }
    }
}
