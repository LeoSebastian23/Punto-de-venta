using System;

namespace Punto_de_venta.Models
{
    public class Buy
    {
        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitCost { get; private set; }
        public DateTime DateBuy { get; private set; }
        public int InvoiceNumber { get; private set; }

        // Relaciones
        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int SupplierId { get; private set; }
        public Supplier Supplier { get; private set; }

        // Constructor vacío (para EF)
        private Buy() { }

        // Constructor controlado
        public Buy(int quantity, decimal unitCost, DateTime dateBuy, int invoiceNumber, int productId, int supplierId)
        {
            if (quantity <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0");

            if (unitCost <= 0)
                throw new ArgumentException("El costo unitario debe ser mayor a 0");

            if (invoiceNumber <= 0)
                throw new ArgumentException("El número de factura debe ser válido");

            Quantity = quantity;
            UnitCost = unitCost;
            DateBuy = dateBuy;
            InvoiceNumber = invoiceNumber;
            ProductId = productId;
            SupplierId = supplierId;
        }
    }
}

