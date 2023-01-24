using Centaurea.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Centaurea.Controllers
{
    public class ConcertController : Controller
    {
        private readonly AppDbContext _context;
        public ConcertController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Concerts()
        {
            return View(await _context.Concerts.ToListAsync());
        }
    }
}
