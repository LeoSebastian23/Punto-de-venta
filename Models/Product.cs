using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    internal class Product
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private string code { get; set; }
        private decimal purchasePrice { get; set; }
        private decimal profitMargin { get; set; }
        private decimal salePrice { get; set; }
        private int stock {  get; set; }

        public Product(string name, string code,  decimal purchasePrice, decimal profitMargin, decimal salePrice)
        {
            this.Name = name;
            this.code = code;
            this.purchasePrice = purchasePrice;
            this.profitMargin = profitMargin;
            this.salePrice = salePrice;
        }

        public Product(long id, string name, string code, decimal purchasePrice, decimal profitMargin, decimal salePrice) {
            this.Id = id;
            this.Name = name;
            this.code = code;
            this.purchasePrice = purchasePrice;
            this.profitMargin = profitMargin;
            this.salePrice = salePrice;
        }

        public Product() { }

        public decimal applyPercentageToSalesPrice(decimal profitMargin, decimal purchasePrice)
        {
            decimal salePrice = purchasePrice * (1 + profitMargin);
            return salePrice;
        }

    }
}
