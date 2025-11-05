
using Punto_de_venta.Repositories.Interfaces;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;

namespace Punto_de_venta.Models
{
    public class Buy
    {
        // Clave primaria
        public int Id { get; private set; }

        // Relaciones
        public Supplier? Supplier { get; private set; }


        // Atributos
        public string InvoiceNumber { get; private set; } = string.Empty;
        public DateTime Date { get; private set; } = DateTime.Now;
        public decimal TotalAmount { get; private set; }

        // Relación con BuyItem
        public ICollection<BuyItem> Items { get; private set; } = new List<BuyItem>();

        // Constructor protegido para EF
        protected Buy() { }

        // Fábrica de dominio
        public static Buy Create(Supplier? supplier, string invoiceNumber)
        {
            if (string.IsNullOrWhiteSpace(invoiceNumber))
                throw new ArgumentException("El número de factura es obligatorio.");

            return new Buy
            {
                Supplier = supplier,
                InvoiceNumber = invoiceNumber,
                Date = DateTime.Now
            };
        }

        // Agregar ítem de compra
        public void AddItem(BuyItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            Items.Add(item);
            TotalAmount += item.Subtotal;
        }

        public void CalculateTotal(ITaxStrategy taxStrategy)
        {
            if (taxStrategy == null)
                throw new ArgumentNullException(nameof(taxStrategy));

            TotalAmount = taxStrategy.CalculateTotal(Items.Sum(i => i.Subtotal));
        }
    }
}



