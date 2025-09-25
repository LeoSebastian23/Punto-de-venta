using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    internal class Sale
    {
        private long Id { get; set; }
        private List<SaleItem> Items { get; set; }
        private int number {  get; set; }
        private DateTime dateSale { get; set; }
        private int amount { get; set; }
        private string client {  get; set; }
        private User user { get; set; }

        public Sale(int id, List<SaleItem> items, int number, DateTime dateSale, int amount, string client, User user)
        {
            Id = id;
            Items = items;
            this.number = number;
            this.dateSale = dateSale;
            this.amount = amount;
            this.client = client;
            this.user = user;
        }

        public Sale(List<SaleItem> items, int number,  string client, User user)
        {
            Items = items;
            this.number = number;
            this.dateSale = dateSale;
            this.amount = amount;
            this.client = client;
            this.user = user;
        }

        Sale() { }

    }
}
