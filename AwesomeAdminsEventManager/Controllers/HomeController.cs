using AwesomeAdminsEventManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AwesomeAdminsEventManager.Controllers {
    public class HomeController: Controller {


        public HomeController() {
            
        }

        public IActionResult Index() {
            List<Event> events = simulateGetData();
            return View(events);
        }

        public IActionResult Privacy() {
            return View();
        }
        public IActionResult Details(int id) {
            List<Event> events = simulateGetData();
            var selectedEvent = events.FirstOrDefault(e => e.EventId == id);
            if (selectedEvent == null) {
                return NotFound();
            }


            return View(selectedEvent);
        }

        //pretends to retreive data from a database. placeholder for now
        public List<Event> simulateGetData() {
            List<Event> events = new List<Event>();
            for(int i = 0; i <= 20; i++) {
                events.Add(new Event {
                    EventId = i,
                    Name = "sample event " + i,
                    Description = "description for sample event " + i,
                    EventDate = DateTime.Now.AddDays(i * 10),
                    Location = "Sample location for sample event " + i,
                    Owner = "John Doe",
                    Created = DateTime.Now
                });
            }
            return events;
        }
    }
}
