using Centaurea_Project.Data;
using Centaurea_Project.Interfaces;
using Centaurea_Project.Models;

namespace Centaurea_Project.Repository
{
    public class PartyConcertRepository : IPartyConcertRepository
    {
        private readonly AppDbContext _context;
        public PartyConcertRepository(AppDbContext context) 
        {
            _context= context;
        }
        public ICollection<Party> GetParties()
        {
            return _context.Parties.OrderBy(p => p.ConcertId).ToList();
        }
    }
}
