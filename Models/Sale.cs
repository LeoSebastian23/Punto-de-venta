using System;
using System.Collections.Generic;
using System.Linq;

namespace Punto_de_venta.Models
{
    public class Sale
    {
        public int Id { get; private set; }

        public DateTime Date { get; private set; }

        public decimal TotalAmount => Items.Sum(i => i.Subtotal);

        public List<SaleItem> Items { get; private set; } = new();

        // Constructor protegido para EF
        protected Sale() { }

        // Constructor de dominio
        public Sale(bool autoSetDate = true)
        {
            if (autoSetDate)
                Date = DateTime.Now;
        }

        /// <summary>
        /// Agrega un ítem a la venta, trabajando con objetos.
        /// </summary>
        public void AddItem(Product product, int quantity, decimal? unitPriceOverride = null)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "La cantidad debe ser mayor a cero.");

            var unitPrice = unitPriceOverride ?? product.SalePrice;

            var item = new SaleItem(product, quantity, unitPrice, this);
            Items.Add(item);
        }
    }
}
