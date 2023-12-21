using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Tickets_Booking.Data;

namespace Movie_Tickets_Booking.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext context;

        public ProducersController(AppDBContext _context)
        {
            context = _context;
        }
        public async  Task<IActionResult> Index()
        {
            var data = await context.Producers.ToListAsync();
            return View(data);
        }
    }
}
