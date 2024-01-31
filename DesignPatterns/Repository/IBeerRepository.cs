using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public interface IBeerRepository
    {
        public IEnumerable<Beer> Get();
        public Beer GetById(int id);
        public void Add(Beer data);
        public void Update(Beer data);
        public void Delete(int id);
        public void Save();
    }
}
