using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Models;

namespace Punto_de_venta.Data
{
    public class AppDbContext : DbContext
    {
        // DbSets -> equivalen a tablas
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Buy> Buys { get; set; }

        // Constructor requerido
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Configuraciones adicionales
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ejemplo: Supplier.Name es obligatorio
            modelBuilder.Entity<Supplier>()
                .Property(s => s.Name)
                .IsRequired();

            // Ejemplo: relación Product -> Supplier (1:N)
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId);

            // Ejemplo: relación Buy -> Product (N:1)
            modelBuilder.Entity<Buy>()
                .HasOne(b => b.Product)
                .WithMany(p => p.Buys)
                .HasForeignKey(b => b.ProductId);

            // Ejemplo: relación Buy -> Supplier (N:1)
            modelBuilder.Entity<Buy>()
                .HasOne(b => b.Supplier)
                .WithMany(s => s.Buys)
                .HasForeignKey(b => b.SupplierId);
        }
    }
}

