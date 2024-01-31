﻿using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class BeerRepository : IBeerRepository
    {
        private BeerContext _context;

        public BeerRepository(BeerContext context)
        {
            _context = context;
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();
        public Beer GetById(int id) => _context.Beers.Find(id);
        public void Add(Beer data) => _context.Beers.Add(data);
        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id); 
            _context.Beers.Remove(beer);
        }
        public void Update(Beer data) => _context.Entry(data).State = EntityState.Modified;
        public void Save() => _context.SaveChanges();
    }
}
