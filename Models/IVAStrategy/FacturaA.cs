using Punto_de_venta.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models.IVAStrategy
{
        // Factura tipo A: IVA 10.5% 
        public class FacturaA: ITaxStrategy
        {
            public decimal CalculateTotal(decimal subtotal)
            {
                return subtotal * 1.105m;
            }
        }
}
