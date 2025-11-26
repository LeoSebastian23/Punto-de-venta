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
            var services = new ServiceCollection()
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;"))

                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<ProductService>()
                .AddScoped<ProductController>()
                .AddScoped<ProductView>()

                .AddScoped<ISupplierRepository, SupplierRepository>()
                .AddScoped<SupplierService>()
                .AddScoped<SupplierController>()
                .AddScoped<SupplierView>()

                .AddScoped<IBuyRepository, BuyRepository>()
                .AddScoped<BuyService>()
                .AddScoped<BuyController>()
                .AddScoped<BuyView>()

                .AddScoped<ISaleRepository, SaleRepository>()
                .AddScoped<SaleService>()
                .AddScoped<SaleController>()
                .AddScoped<FormVentaTest>()

                .AddScoped<StockService>()
                .AddScoped<PricingService>()

                .AddScoped<LoadBuyItem>()
                .AddScoped<MainMenuView>()

                .BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = services.GetRequiredService<MainMenuView>();
            Application.Run(form);
        }
    }
}
