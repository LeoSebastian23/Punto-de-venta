using System.Collections.Generic;
using Punto_de_venta.Models;

namespace Punto_de_venta.Repositories.Interfaces
{
    public interface ISaleRepository
    {
        Sale? GetById(int id);
        IEnumerable<Sale> GetAll();
        void Add(Sale sale);
        void SaveChanges();
    }
}
