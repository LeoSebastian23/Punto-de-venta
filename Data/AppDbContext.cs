using Microsoft.EntityFrameworkCore;
using Punto_de_venta.Models;

namespace Punto_de_venta.Data
{
    public class AppDbContext : DbContext
    {
        // ==========================
        // TABLAS PRINCIPALES
        // ==========================
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Buy> Buys { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<User> Users { get; set; }

        // ==========================
        // CONSTRUCTORES
        // ==========================
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Constructor adicional para migraciones
        public AppDbContext() { }

        // ==========================
        // CONFIGURACIÓN
        // ==========================
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PuntoDeVentaDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        // ==========================
        // RELACIONES Y REGLAS
        // ==========================
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ==========================
            // BUY → BUYITEM → PRODUCT
            // ==========================
            modelBuilder.Entity<Buy>()
                .HasMany(b => b.Items)
                .WithOne()
                .HasForeignKey("BuyId")
                .OnDelete(DeleteBehavior.Cascade); // al borrar una compra, se borran sus items

            modelBuilder.Entity<BuyItem>()
                .HasOne(i => i.Product)
                .WithMany() // Product no conoce sus BuyItems
                .HasForeignKey("ProductId")
                .OnDelete(DeleteBehavior.Restrict); // no se puede borrar un producto con compras asociadas

            modelBuilder.Entity<Buy>()
                .HasOne(b => b.Supplier)
                .WithMany(s => s.Buys)
                .HasForeignKey("SupplierId")
                .OnDelete(DeleteBehavior.Restrict); // no se puede borrar un supplier con compras

            // Configurar campo InvoiceNumber (texto obligatorio)
            modelBuilder.Entity<Buy>()
                .Property(b => b.InvoiceNumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar(50)");

            // ==========================
            // SALE → SALEITEM → PRODUCT
            // ==========================
            modelBuilder.Entity<Sale>()
                .HasMany(s => s.Items)
                .WithOne(i => i.Sale)
                .HasForeignKey(i => i.SaleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SaleItem>()
                .HasOne(i => i.Product)
                .WithMany() // Product no conoce sus SaleItems
                .HasForeignKey("ProductId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Restrict);

            // ==========================
            // USER
            // ==========================
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();

            // ==========================
            // PRODUCT
            // ==========================
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}



