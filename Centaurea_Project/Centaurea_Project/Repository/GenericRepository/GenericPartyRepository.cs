using Centaurea_Project.Data;
using Centaurea_Project.Interfaces.GenericInterfaces;
using Centaurea_Project.Models;

namespace Centaurea_Project.Repository.GenericRepository
{
    public class GenericPartyRepository : GenericRepository<Party>, IPartyGenericRepository
    {
        public GenericPartyRepository(AppDbContext context) : base(context)
        {
        }
    }
}
