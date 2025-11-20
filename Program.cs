using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Punto_de_venta.Controllers;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Implementations;
using Punto_de_venta.Repositories.Interfaces;
using Punto_de_venta.Services;
using Punto_de_venta.Views;


namespace Punto_de_venta
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // 🧩 Configuración del contenedor de dependencias
            var services = new ServiceCollection()
                // --- Base de datos ---
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;"))

                // --- PRODUCTOS ---
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<ProductService>()
                .AddScoped<ProductController>()
                .AddScoped<ProductView>()

                // --- PROVEEDORES ---
                .AddScoped<ISupplierRepository, SupplierRepository>()
                .AddScoped<SupplierService>()
                .AddScoped<SupplierController>()
                .AddScoped<SupplierView>()

                // --- COMPRAS ---
                .AddScoped<IBuyRepository, BuyRepository>()
                .AddScoped<BuyService>()
                .AddScoped<BuyController>()
                .AddScoped<BuyView>()

                // --- SERVICIOS AUXILIARES ---
                .AddScoped<StockService>()
                .AddScoped<PricingService>()
                .AddScoped<ProductView>()


                // --- VENTANAS DE SOPORTE ---
                .AddScoped<LoadBuyItem>()
                .AddScoped<MainMenuView>()

                .BuildServiceProvider();

            // 🧱 Inicialización de la aplicación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 🚀 Abrir menú principal
            var form = services.GetRequiredService<MainMenuView>();
            Application.Run(form);
        }
    }
}






