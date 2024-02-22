using Microsoft.AspNetCore.Mvc;

namespace Treehouse.Controllers
{
    public class VideoGamesController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.Title = "Super Mario 63";
            ViewBag.Description = "Super Mario 63 is a 1996 platform video game developed and published by Nintendo for the Nintendo 64.";
            ViewBag.Characters = new string[]
            {
                "Mario",
                "Princess Peach",
                "Bowser",
                "Toad",
                "Yoshi"
            };

            return View();
        }
    }
}