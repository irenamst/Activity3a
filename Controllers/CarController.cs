using Microsoft.AspNetCore.Mvc;
using Activity3a.Models;
using System.Globalization;
using Activity3a.ServicesCar;

namespace Activity3a.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            HardCodedDataRepository hardCodedDataRepository = new HardCodedDataRepository();
            return View(hardCodedDataRepository.GetAllCars());
        }
        public IActionResult Message()
        {
            return View("Message");
        }
        public IActionResult Welcome(string name, int secretNumber)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
