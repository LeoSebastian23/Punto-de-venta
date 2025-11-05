using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;
using Punto_de_venta.Repositories.Implementations;
using Punto_de_venta.Services;
using Punto_de_venta.Controllers;
using Punto_de_venta.Views;
using punto_venta;

class Program
{
    static void Main(string[] args)
    {
        //var services = new ServiceCollection()
        //    .AddDbContext<AppDbContext>(options =>
        //        options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;"))
        //    .AddScoped<ISupplierRepository, SupplierRepository>()
        //    .AddScoped<SupplierService>()
        //    .AddScoped<SupplierController>()
        //    .AddScoped<SupplierView>() 
        //    .BuildServiceProvider();

        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);


        //// ? Se obtiene la instancia del formulario desde el ServiceProvider
        //var form = services.GetRequiredService<SupplierView>();
        //Application.Run(form);

        /*var services = new ServiceCollection()
            .AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<ProductService>()
            .AddScoped<ProductController>()
            .AddScoped<ProductView>()
            .BuildServiceProvider();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var form = services.GetRequiredService<SupplierView>();
        Application.Run(form);*/


        var services = new ServiceCollection()
            .AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            .AddScoped<ISupplierRepository, SupplierRepository>()
            .AddScoped<SupplierService>()
            .AddScoped<SupplierController>()
            .AddScoped<SupplierView>()

            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<ProductService>()
            .AddScoped<ProductController>()
            .AddScoped<ProductView>()
            //.AddScoped<ProductsList>()

            .AddScoped<IBuyRepository, BuyRepository>()
            .AddScoped<BuyService>()
            .AddScoped<BuyController>()
            .AddScoped<BuyView>()

            .BuildServiceProvider();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var form = services.GetRequiredService</*ProductsList/SupplierView*/BuyView/*ProductView*/>();
        Application.Run(form);
        
    }
}

