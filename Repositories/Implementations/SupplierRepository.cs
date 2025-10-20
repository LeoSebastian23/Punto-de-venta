using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

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
            var supplier = _context.Suppliers.Find(id);
            if (supplier == null)
                throw new Exception("Proveedor no encontrado.");

            _context.Suppliers.Remove(supplier);
            _context.SaveChanges(); 
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

