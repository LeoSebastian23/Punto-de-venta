using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Repositories.Interfaces
{
    public interface ITaxStrategy
    {
        decimal CalculateTotal(decimal subtotal);
    }

}
