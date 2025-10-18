using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;

namespace Punto_de_venta.Repositories.Interfaces
{
    public interface IBuyRepository
    {
        void Add(Buy buy);
        IEnumerable<Buy> GetAll();
        void Save();
    }
}
