using Centaurea_Project.Data;
using Centaurea_Project.Interfaces;
using Centaurea_Project.Models;

namespace Centaurea_Project.Repository
{
    public class ClassicalConcertRepository : IClassicalConcertRepository
    {
        private readonly AppDbContext _context;
        public ClassicalConcertRepository(AppDbContext context)
        {
            _context = context;
        }
        public ICollection<ClassicalConcert> GetClassicalConcerts()
        {
            return _context.ClassicalConcerts.OrderBy(c => c.ConcertId).ToList();
        }
    }
}
