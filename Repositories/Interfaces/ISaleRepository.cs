using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;

namespace Punto_de_venta.Repositories.Interfaces
{
    /// Define las operaciones de acceso a datos para la entidad Sale.
    /// No sabe nada de Entity Framework (solo la interfaz).

    public interface ISaleRepository
    {
        Sale? GetById(int id);
        IEnumerable<Sale> GetAll();
        void Add(Sale sale);
        void SaveChanges();
    }
}