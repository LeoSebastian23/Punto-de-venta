using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Implementations;
using Punto_de_venta.Services;
using Punto_de_venta.Controllers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Test de flujo completo de BUY ===");

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new AppDbContext(options);

        // 1️ Buscar o crear Supplier
        var supplier = context.Suppliers.FirstOrDefault(s => s.Name == "LimpiezaPro");
        if (supplier == null)
        {
            supplier = new Supplier("LimpiezaPro", "20123456789", null);
            context.Suppliers.Add(supplier);
            context.SaveChanges();
            Console.WriteLine("Proveedor 'LimpiezaPro' creado.");
        }

        // 2️ Crear o recuperar productos
        var productos = new List<Product>
        {
            new Product("Lavandina ALA", "LA001", 150, 20),
            new Product("Detergente LimpiMax", "DE002", 180, 15),
            new Product("Desinfectante PinoPlus", "PI003", 220, 10),
            new Product("Jabón Líquido Suave", "JA004", 200, 25),
            new Product("Limpiavidrios Azulino", "LI005", 130, 30)
        };

        for (int i = 0; i < productos.Count; i++)
        {
            var existente = context.Products.FirstOrDefault(x => x.Code == productos[i].Code);
            if (existente == null)
            {
                context.Products.Add(productos[i]);
                Console.WriteLine($"Producto '{productos[i].Name}' agregado.");
            }
            else
            {
                productos[i] = existente;
                Console.WriteLine($"Producto '{productos[i].Name}' ya existe.");
            }
        }
        context.SaveChanges();

        // 3️ Crear servicios y controladores
        var buyRepo = new BuyRepository(context);
        var productRepo = new ProductRepository(context);
        var supplierRepo = new SupplierRepository(context);

        var stockService = new StockService(productRepo);
        var pricingService = new PricingService(productRepo);
        var buyService = new BuyService(buyRepo, stockService, pricingService);
        var supplierService = new SupplierService(supplierRepo);

        var buyController = new BuyController(buyService);

        // 4️ Crear items de la compra
        var items = new List<(Product product, int quantity, decimal unitPrice)>
        {
            (productos[0], 10, 120),
            (productos[1], 8, 100),
            (productos[2], 5, 180),
            (productos[3], 6, 150),
            (productos[4], 12, 90)
        };

        // 5️ Registrar la compra (Factura tipo B con 40% de ganancia)
        buyController.RegisterBuy(
            supplier,
            "B-0001-00000005",
            items,
            "B",
            40
        );

        Console.WriteLine("\nCompra registrada correctamente.\n");

        // 6️ Mostrar resultados
        var buys = context.Buys
            .Include(b => b.Supplier)
            .Include(b => b.Items)
            .ThenInclude(i => i.Product)
            .ToList();

        Console.WriteLine("=== COMPRAS REGISTRADAS ===");
        foreach (var buy in buys)
        {
            Console.WriteLine($"Compra #{buy.Id} | Proveedor: {buy.Supplier?.Name ?? "Sin proveedor"} | Total: {buy.TotalAmount:C}");
            foreach (var item in buy.Items)
            {
                Console.WriteLine($"   → {item.Product.Name} x{item.Quantity}u a ${item.UnitPrice} = {item.Subtotal:C}");
            }
        }

        Console.WriteLine("\n=== FIN DEL TEST ===");
    }
}




