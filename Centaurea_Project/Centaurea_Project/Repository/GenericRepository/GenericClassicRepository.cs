using Centaurea_Project.Data;
using Centaurea_Project.Interfaces.GenericInterfaces;
using Centaurea_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Centaurea_Project.Repository.GenericRepository
{
    public class GenericClassicRepository : GenericRepository<ClassicalConcert>, IClassicGenericRepository
    {
        public GenericClassicRepository(AppDbContext context) : base(context)
        {

        }
    }
}
