using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public interface IRepository<TEntity>
    {
        public IEnumerable<TEntity> Get();
        public TEntity GetById(int id);
        public void Add(TEntity data);
        public void Update(TEntity data);
        public void Delete(int id);
        public void Save();
    }
}
