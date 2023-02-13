using Centaurea.Data;
using Centaurea.Models;
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
            //allConcerts.RegularConcerts = await _context.RegularConcerts.ToListAsync();
            //allConcerts.ClassicalConcerts = await _context.ClassicalConcerts.ToListAsync();
            //allConcerts.Parties = await _context.Parties.ToListAsync();
            return View();
        }
    }
}
