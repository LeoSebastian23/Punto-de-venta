using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public Product? GetById(int id)
        {
            return _context.Products
                .Include(p => p.Supplier)
                .Include(p => p.BuyItems)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products
                .Include(p => p.Supplier)
                .Include(p => p.BuyItems)
                .ToList();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
