using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eDziennik.Data;
using eDziennik.Models;

namespace eDziennik.Controllers
{
    public class CalendarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalendarController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.Include(e => e.User).ToListAsync();
            return View(events);
        }
    }
}
