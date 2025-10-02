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
            .AddDbContext<AppDbContext>()
            .BuildServiceProvider();

        using (var context = serviceProvider.GetRequiredService<AppDbContext>())
        {
            context.Database.Migrate();

            // --- 1. Crear Usuario (cajero)
            var user = new User("Leo", "1234");
            context.Users.Add(user);
            context.SaveChanges();

            // --- 2. Crear Proveedor
            var supplier = new Supplier("Proveedor X", "20123456789", "1122334455");
            context.Suppliers.Add(supplier);
            context.SaveChanges();

            // --- 3. Crear Productos
            var product1 = new Product("Jabon ALA", "Liquido", 500, 1200, 50, supplier.Id);
            var product2 = new Product("Lavandina", "Ayudin", 300, 800, 30, supplier.Id);
            context.Products.AddRange(product1, product2);
            context.SaveChanges();

            // --- 4. Crear Venta con ítems
            var sale = new Sale(user);
            sale.AddItem(product1, 2, product1.SalePrice); 
            sale.AddItem(product2, 1, product2.SalePrice); 

            context.Sales.Add(sale);
            context.SaveChanges();

            // --- 5. Consultar y mostrar resultados
            var sales = context.Sales
                .Include(s => s.Items)
                .ThenInclude(i => i.Product)
                .Include(s => s.User)
                .ToList();

            foreach (var s in sales)
            {
                Console.WriteLine($"Venta #{s.Id} por {s.User.Name} el {s.Date} - Total: {s.TotalAmount}");
                foreach (var item in s.Items)
                {
                    Console.WriteLine($"   {item.Quantity} x {item.Product.Name} -> Subtotal {item.Subtotal}");
                }
            }
        }
    }
}

