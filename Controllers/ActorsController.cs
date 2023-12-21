using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Tickets_Booking.Data;

namespace Movie_Tickets_Booking.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDBContext context;

        public ActorsController(AppDBContext _context)
        {
            context = _context;
        }
        public async Task< IActionResult> Index()
        {
            var data = await context.Actors.ToListAsync();
            return View(data);
        }
    }
}
