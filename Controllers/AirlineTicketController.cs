using Activity3a.Models;
using Activity3a.ServicesAirline;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Activity3a.Controllers
{
    public class AirlineTicketController : Controller
    {
        public IActionResult Index()
        {
            HardCodedDataRepository hardCodedDataRepository = new HardCodedDataRepository();
            return View(hardCodedDataRepository.GetAllAirlineTickets());
        }
        public IActionResult Message()
        {
            return View("Message");
        }
        public IActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
