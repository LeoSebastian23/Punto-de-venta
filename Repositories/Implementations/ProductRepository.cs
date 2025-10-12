using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Repositories.Implementations
{
    /// Implementación concreta del repositorio de productos.
    /// Utiliza Entity Framework Core para el acceso a datos.

    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        // Inyección de dependencias
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        // Obtener todos los productos
        public IEnumerable<Product> GetAll()
        {
            return _context.Products
                           .Include(p => p.Supplier)
                           .AsNoTracking()
                           .ToList();
        }

        // Obtener un producto por Id
        public Product? GetById(int id)
        {
            return _context.Products
                           .Include(p => p.Supplier)
                           .FirstOrDefault(p => p.Id == id);
        }

        // Agregar producto
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // Actualizar producto
        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        // Eliminar producto
        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                throw new KeyNotFoundException("Producto no encontrado");

            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        // Buscar por nombre o código
        public IEnumerable<Product> Search(string keyword)
        {
            return _context.Products
                           .Where(p => p.Name.Contains(keyword) || p.Code.Contains(keyword))
                           .Include(p => p.Supplier)
                           .AsNoTracking()
                           .ToList();
        }
    }
}
