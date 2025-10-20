using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Repositories.Implementations
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext _context;

        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public Supplier? GetById(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public void Update(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
        }

        public void Delete(int id)
        {
            var supplier = _context.Suppliers
                .Include(s => s.Products)
                .FirstOrDefault(s => s.Id == id);

            if (supplier == null)
                throw new Exception("Proveedor no encontrado.");

            if (supplier.Products.Any())
                throw new InvalidOperationException("No se puede eliminar el proveedor porque tiene productos asociados.");

            _context.Suppliers.Remove(supplier);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

