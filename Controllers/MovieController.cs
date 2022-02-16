using Microsoft.AspNetCore.Mvc;
using Activity3a.Models;
using Activity3a.ServicesMovie;
using System.Globalization;

namespace Activity3a.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            HardCodedDataRepository hardCodedDataRepository = new HardCodedDataRepository();
            return View(hardCodedDataRepository.GetAllMovies());
        }
        public IActionResult Message()
        {
            return View("Message");
        }
        public IActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret=secretNumber;
            return View();
        }
    }
}
