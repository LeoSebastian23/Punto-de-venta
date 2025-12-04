using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Repositories.Implementations
{
    public class SaleRepository : ISaleRepository
    {
        private readonly AppDbContext _context;

        public SaleRepository(AppDbContext context)
        {
            _context = context;
        }

        public Sale? GetById(int id)
        {
            return _context.Sales
                .Include(s => s.Items)
                .ThenInclude(i => i.Product)
                .FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Sale> GetAll()
        {
            return _context.Sales
                .Include(s => s.Items)
                .ThenInclude(i => i.Product)
                .AsNoTracking()
                .ToList();
        }

        public void Add(Sale sale)
        {
            _context.Sales.Add(sale);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public IEnumerable<Sale> GetByDateRange(DateTime start, DateTime end)
        {
            return _context.Sales
                .Include(s => s.Items)
                .ThenInclude(i => i.Product)
                .Where(s => s.Date >= start && s.Date <= end)
                .AsNoTracking()
                .ToList();
        }
    }
}
