using AwesomeAdminsPartyManager.Models;
using Microsoft.AspNetCore.Mvc;
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

        //pretends to retreive data from a database. placeholder for now
        public List<Party> simulateGetData() {
            List<Party> parties = new List<Party>();
            for(int i = 0; i <= 20; i++) {
                parties.Add(new Party {
                    PartyId = i,
                    Name = "sample party " + i,
                    Description = "description for sample party " + i,
                    EventDate = DateTime.Now.AddDays(i * 10),
                    Location = "Sample location for sample party " + i,
                    Owner = "John Doe",
                    Created = DateTime.Now
                });
            }
            return parties;
        }
    }
}
