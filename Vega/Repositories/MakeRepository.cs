using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Models;
using Vega.Persistence;

namespace Vega.Repositories
{
    public class MakeRepository : IMakeRepository
    {
        private readonly VegaDbContext _context;

        public MakeRepository(VegaDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Make>> GetAll()
        {
            return await _context.Makes.Include(m => m.Models).ToListAsync();
        }

        public async Task<Make> GetSingle(int id)
        {
            return await _context.Makes.Include(m => m.Models).FirstOrDefaultAsync(m => m.Id == id);
        }


        public void Add(Make make)
        {
            _context.Makes.Add(make);
        }

        public void Delete(Make make)
        {
            _context.Makes.Remove(make);
        }

        public void Update(Make make)
        {
            _context.Makes.Update(make);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

    }
}
