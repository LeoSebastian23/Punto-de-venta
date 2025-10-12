using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;
using Punto_de_venta.Repositories.Implementations;
using Punto_de_venta.Services;
using Punto_de_venta.Controllers;

class Program
{
    static void Main(string[] args)
    {
        // --- Configurar Dependencias (DI Container) ---
        var serviceProvider = new ServiceCollection()
            .AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<ISaleRepository, SaleRepository>()
            .AddScoped<SaleService>()
            .AddScoped<SaleController>()
            .BuildServiceProvider();

        using var scope = serviceProvider.CreateScope();
        var controller = scope.ServiceProvider.GetRequiredService<SaleController>();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        // --- Datos base (ya deberían existir en BD) ---
        var user = context.Users.FirstOrDefault() ?? new User("Leo", "1234");
        if (user.Id == 0)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        var supplier = context.Suppliers.FirstOrDefault() ?? new Supplier("LimpiezaPro", "20123456789", "1122334455");
        if (supplier.Id == 0)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }

        // --- Crear productos de limpieza ---
        var product1 = context.Products.FirstOrDefault(p => p.Name == "Detergente Multiusos")
            ?? new Product("Detergente Multiusos", "DET-001", 200, 450, 40, supplier.Id);

        var product2 = context.Products.FirstOrDefault(p => p.Name == "Desinfectante Floral")
            ?? new Product("Desinfectante Floral", "DES-002", 300, 700, 25, supplier.Id);

        var product3 = context.Products.FirstOrDefault(p => p.Name == "Lavandina Concentrada")
            ?? new Product("Lavandina Concentrada", "LAV-003", 150, 400, 60, supplier.Id);

        if (product1.Id == 0 || product2.Id == 0 || product3.Id == 0)
        {
            context.Products.AddRange(product1, product2, product3);
            context.SaveChanges();
        }

        // --- Crear una venta ---
        var sale = new Sale(user);
        sale.AddItem(product1, 2, product1.SalePrice); 
        sale.AddItem(product3, 1, product3.SalePrice); 

        // --- Registrar la venta ---
        controller.CreateSale(sale);

        // --- Mostrar todas las ventas ---
        controller.ShowAllSales();
    }
}

