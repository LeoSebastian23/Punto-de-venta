using Punto_de_venta.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models.IVAStrategy
{
        // Factura tipo B: IVA 21% 
        public class FacturaB : ITaxStrategy {
            public decimal CalculateTotal(decimal subtotal)
            {
                return subtotal * 1.21m;
            } 
        }
}
