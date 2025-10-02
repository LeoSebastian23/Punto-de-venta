using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    public class SaleItem
    {
        // 🔑 Clave primaria
        public int Id { get; private set; }

        // 📌 Relación con Product
        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        // 📊 Cantidad y precio de la venta
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        // 💰 Subtotal calculado
        public decimal Subtotal => Quantity * UnitPrice;

        // 📌 Relación con Sale
        public int SaleId { get; private set; }
        public Sale Sale { get; private set; }

        // 🔨 Constructor protegido para EF
        protected SaleItem() { }

        // 🚀 Constructor público
        public SaleItem(Product product, int quantity, decimal unitPrice)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
            ProductId = product.Id;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}

