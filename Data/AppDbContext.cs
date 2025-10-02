using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Models;

namespace Punto_de_venta.Data
{
    public class AppDbContext : DbContext
    {
        // DbSets = Tablas en la BD
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Buy> Buys { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<User> Users { get; set; }

        // Constructor que usa DI
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // ✅ Constructor adicional para migraciones
        public AppDbContext() { }

        // ✅ OnConfiguring: se usa solo si no está configurado por DI
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        // Configuración de relaciones y restricciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- PRODUCT ---
            // Un Product tiene un Supplier
            // Un Supplier tiene muchos Products
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict); // no borrar supplier en cascada

            // --- BUY ---
            // Un Buy tiene un Product
            modelBuilder.Entity<Buy>()
                .HasOne(b => b.Product)
                .WithMany(p => p.Buys)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Un Buy tiene un Supplier
            modelBuilder.Entity<Buy>()
                .HasOne(b => b.Supplier)
                .WithMany(s => s.Buys)
                .HasForeignKey(b => b.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            // --- SALE ---
            // Un Sale tiene muchos SaleItems
            modelBuilder.Entity<Sale>()
                .HasMany(s => s.Items)
                .WithOne(i => i.Sale)
                .HasForeignKey(i => i.SaleId)
                .OnDelete(DeleteBehavior.Cascade); // si borro la venta, se borran sus items

            // Un Sale tiene un User
            modelBuilder.Entity<Sale>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict); // no borrar usuario si tiene ventas

            // --- SALEITEM ---
            // Un SaleItem tiene un Product
            modelBuilder.Entity<SaleItem>()
                .HasOne(i => i.Product)
                .WithMany(p => p.SaleItems)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // no borrar producto si tiene ventas

            // --- USER ---
            // Nombre de usuario único
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();

            // --- PRODUCT extra ---
            // Nombre requerido y máx 100 chars
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

