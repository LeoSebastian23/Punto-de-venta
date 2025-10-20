
using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace Punto_de_venta.Models
{
    public class Buy
    {
        // Clave primaria
        public int Id { get; private set; }

        // Relaciones
        public int? SupplierId { get; private set; }  // Nullable = compra sin proveedor
        public Supplier? Supplier { get; private set; }

        // Atributos
        public DateTime Date { get; private set; } = DateTime.Now;
        public decimal TotalAmount { get; private set; }

        // Relación con BuyItem
        public ICollection<BuyItem> Items { get; private set; } = new List<BuyItem>();

        // Constructor vacío (para EF)
        protected Buy() { }

        // Constructor de dominio
        public Buy(int? supplierId = null)
        {
            SupplierId = supplierId;
        }

        // Agregar ítem de compra
        public void AddItem(BuyItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            Items.Add(item);
            TotalAmount += item.Subtotal;
        }
    }
}



