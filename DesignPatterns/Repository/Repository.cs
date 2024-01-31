using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private BeerContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(BeerContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public IEnumerable<TEntity> Get() => _dbSet.ToList();
        public TEntity GetById(int id) => _dbSet.Find(id);
        public void Add(TEntity data) => _dbSet.Add(data);
        public void Delete(int id)
        {
            var dataToDelete = _dbSet.Find(id);
            _dbSet.Remove(dataToDelete);
        }
        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
        public void Save() => _context.SaveChanges();
    }
}
