using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AwesomeAdminsEventManager.Models;

namespace AwesomeAdminsEventManager.Controllers {
    public class HomeController : Controller {
        

        public HomeController() {
            
        }

        public IActionResult Index() {

            List<Event> events = new List<Event>();
            for(int i = 0; i <= 20; i++) {
                events.Add(new Event {
                    EventId = i,
                    Title = "sample event " + i,
                    Description = "description for sample event " + i,
                    EventDate = DateTime.Now.AddDays(i * 10),
                    EventTime = DateTime.Now.AddHours(i),
                    Location = "Sample location for sample event " + i,
                    Owner = "John Doe",
                    Created = DateTime.Now
                });
            }
            return View(events);
        }

        public IActionResult Privacy() {
            return View();
        }
        public IActionResult Details(int id) {
            var myEvent = new Event {
                EventId = id,
                Title = "Sample Event " + id,
                Description = "This is a sample event description for event " + id + ".",
                EventDate = DateTime.Now.AddDays(10 * id),
                EventTime = DateTime.Now.AddHours(5 * id),
                Location = (id % 2 == 0) ? "456 Elm St, Townsville" : "123 Main St, Cityville",
                Owner = (id % 2 == 0) ? "Jane Smith" : "John Doe",
                Created = DateTime.Now
            };
            return View(myEvent);
        }
    }
}
