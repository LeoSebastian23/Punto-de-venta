using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Repositories.Implementations
{
    public class BuyRepository : IBuyRepository
    {
        private readonly AppDbContext _context;

        public BuyRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Buy buy)
        {
            _context.Buys.Add(buy);
            Save();
        }

        public IEnumerable<Buy> GetAll()
        {
            return _context.Buys
                .Include(b => b.Items)
                .ThenInclude(i => i.Product)
                .ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
