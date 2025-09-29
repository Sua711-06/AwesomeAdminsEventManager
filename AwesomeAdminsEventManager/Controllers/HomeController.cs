using AwesomeAdminsPartyManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AwesomeAdminsPartyManager.Controllers {
    public class HomeController: Controller {
        public HomeController() {
            
        }

        public IActionResult Index() {
            List<Party> events = simulateGetData();
            return View(events);
        }

        public IActionResult Privacy() {
            return View();
        }
        public IActionResult Details(int id) {
            List<Party> events = simulateGetData();
            var selectedEvent = events.FirstOrDefault(e => e.PartyId == id);
            if (selectedEvent == null) {
                return NotFound();
            }


            return View(selectedEvent);
        }        
    }
}
