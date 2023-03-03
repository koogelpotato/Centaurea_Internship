using Centaurea_Project.Data;
using Centaurea_Project.Interfaces;
using Centaurea_Project.Migrations.Centaurea_Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Centaurea_Project.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public virtual void Delete(object id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(T obj)
        {
            _dbSet.Add(obj);
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public virtual void Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
