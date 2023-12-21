using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Tickets_Booking.Data;

namespace Movie_Tickets_Booking.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDBContext _context;

        public CinemasController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
