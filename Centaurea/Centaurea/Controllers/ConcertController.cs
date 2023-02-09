using Centaurea.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

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
            dynamic allConcerts = new ExpandoObject();
            allConcerts.RegularConcerts = _context.RegularConcerts.ToListAsync();
            allConcerts.Parties = _context.Parties.ToListAsync();
            allConcerts.ClassicalConcerts = _context.ClassicalConcerts.ToListAsync();
            return View(allConcerts);
        }
    }
}
