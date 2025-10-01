using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Punto_de_venta.Data;
using Punto_de_venta.Models;

class Program
{
    static void Main(string[] args)
    {
        // Configurar servicios y DbContext
        var serviceProvider = new ServiceCollection()
            .AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=localhost;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            .BuildServiceProvider();

        using var context = serviceProvider.GetRequiredService<AppDbContext>();

        // Asegurar que la BD se crea (solo para pruebas iniciales)
        context.Database.EnsureCreated();

        // ----- INSERT -----
        var supplier = new Supplier("Proveedor Test", "20-12345678-9", "223-5555555");
        context.Suppliers.Add(supplier);
        context.SaveChanges();

        var product = new Product("Mouse Logitech", "M-123", 800, 1200, 50, supplier.Id);
        context.Products.Add(product);
        context.SaveChanges();

        var buy = new Buy(10, 1150, DateTime.Now, 1001, product.Id, supplier.Id);
        context.Buys.Add(buy);
        context.SaveChanges();

        // ----- SELECT -----
        var suppliers = context.Suppliers
                               .Include(s => s.Products)
                               .ThenInclude(p => p.Buys)
                               .ToList();

        foreach (var s in suppliers)
        {
            Console.WriteLine($"Proveedor: {s.Name}, CUIT: {s.CUIT}");
            foreach (var p in s.Products)
            {
                Console.WriteLine($"  Producto: {p.Name}, Stock: {p.Stock}");
                foreach (var b in p.Buys)
                {
                    Console.WriteLine($"    Compra: {b.Quantity} unidades, Precio Unitario: {b.UnitCost}, Factura: {b.InvoiceNumber}");
                }
            }
        }
    }
}
