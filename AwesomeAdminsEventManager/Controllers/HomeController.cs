using AwesomeAdminsPartyManager.Models;
using AwesomeAdminsPartyManager.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AwesomeAdminsPartyManager.Controllers {
    public class HomeController: Controller {
        private readonly AwesomeAdminsPartyManagerContext _context;

        public HomeController(AwesomeAdminsPartyManagerContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            var parties = await _context.Party.ToListAsync();
            return View(parties);
        }

        public IActionResult Privacy() {
            return View();
        }
    }
}
