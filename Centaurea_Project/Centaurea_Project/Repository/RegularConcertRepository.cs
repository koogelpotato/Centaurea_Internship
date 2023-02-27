using Centaurea_Project.Data;
using Centaurea_Project.Interfaces;
using Centaurea_Project.Models;

namespace Centaurea_Project.Repository
{
    public class RegularConcertRepository : IRegularConcertRepository
    {
        private readonly AppDbContext _context;

        public RegularConcertRepository(AppDbContext context)
        {
            _context = context;
        }

        public ICollection<RegularConcert> GetRegularConcerts()
        {
            return _context.RegularConcerts.OrderBy(r => r.ConcertId).ToArray();
        }
    }
}
