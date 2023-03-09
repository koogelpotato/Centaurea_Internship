using Centaurea_Project.Data;
using Centaurea_Project.Interfaces.GenericInterfaces;
using Centaurea_Project.Models;

namespace Centaurea_Project.Repository.GenericRepository
{
    public class GenericRegularRepository : GenericRepository<RegularConcert>, IRegularGenericRepository
    {
        public GenericRegularRepository(AppDbContext context) : base(context)
        {
        }
    }
}
