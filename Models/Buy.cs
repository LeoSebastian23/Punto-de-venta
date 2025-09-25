using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    internal class Buy
    {
        private long Id { get; set; }
        private int quantity { get; set; }
        private decimal unitCost { get; set; }
        private DateTime dateBuy { get; set; }
        private int invoiceNumber { get; set; }
        private Product product { get; set; }
        private Supplier supplier { get; set; } 

        public Buy(int id, int quantity, decimal unitCost, DateTime dateBuy, int invoiceNumber, Product product, Supplier supplier)
        {
            Id = id;
            this.quantity = quantity;
            this.unitCost = unitCost;
            this.dateBuy = dateBuy;
            this.invoiceNumber = invoiceNumber;
            this.product = product;
            this.supplier = supplier;
        }

        public Buy(int quantity, decimal unitCost, DateTime dateBuy, int invoiceNumber, Product product, Supplier supplier)
        {
            this.quantity = quantity;
            this.unitCost = unitCost;
            this.dateBuy = dateBuy;
            this.invoiceNumber = invoiceNumber;
            this.product = product;
            this.supplier = supplier;
        }

        public Buy() { }
    }
}
