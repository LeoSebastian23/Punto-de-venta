using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    internal class Supplier
    {
        private long Id {  get; set; }
        private string name { get; set; }
        private long cuit {  get; set; }
        private long phoneNumber { get; set; }

        public Supplier(long Id, string name, long cuit, long phoneNumber)
        {
            this.Id = Id;
            this.name = name;
            this.cuit = cuit;
            this.phoneNumber = phoneNumber;
        }

        public Supplier(string name, long cuit, long phoneNumber)
        {
            this.name = name;
            this.cuit = cuit;
            this.phoneNumber = phoneNumber;
        }

        public Supplier() { }

    }
}
