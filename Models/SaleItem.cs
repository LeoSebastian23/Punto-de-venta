using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    internal class SaleItem
    {
        private long Id { get; set; }
        private Product Product { get; set; }
        private int amount { get; set; }
        private decimal totalPrice { get; set; }

        public SaleItem(long id, Product product, int amount, decimal totalPrice)
        {
            Id = id;
            Product = product;
            this.amount = amount;
            this.totalPrice = totalPrice;
        }

        public SaleItem(Product product, int amount, decimal totalPrice)
        {
            this.Product = product;
            this.amount = amount;
            this.totalPrice = totalPrice;
        }

        public SaleItem() { }

    }
}
