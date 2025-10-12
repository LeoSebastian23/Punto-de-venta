using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    public class Sale
    {
        // Clave primaria
        public int Id { get; private set; }

        // Datos básicos
        public DateTime Date { get; private set; }
        public decimal TotalAmount => Items.Sum(i => i.Subtotal);

        // Relación con Items
        private readonly List<SaleItem> _items = new();
        public IReadOnlyCollection<SaleItem> Items => _items.AsReadOnly();

        // Relación con User (cajero)
        public int UserId { get; private set; }
        public User User { get; private set; }

        // Constructor protegido para EF
        protected Sale() { }

        // Constructor público
        public Sale(User user)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            UserId = user.Id;
            Date = DateTime.Now;
        }

        // ➕ Método para agregar productos
        public void AddItem(Product product, int quantity, decimal unitPrice)
        {
            if (quantity <= 0) throw new ArgumentException("La cantidad debe ser mayor a 0.");
            if (unitPrice <= 0) throw new ArgumentException("El precio debe ser mayor a 0.");

            var item = new SaleItem(product, quantity, unitPrice);
            _items.Add(item);
        }
    }
}

