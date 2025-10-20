using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Punto_de_venta.Models
{
    public class BuyItem
    {
        public int Id { get; private set; }

        // Relaciones
        public int BuyId { get; private set; }
        public Buy Buy { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        // Atributos
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Subtotal => Quantity * UnitPrice;

        protected BuyItem() { }

        public BuyItem(int productId, int quantity, decimal unitPrice)
        {
            if (quantity <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0");

            if (unitPrice <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0");

            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
