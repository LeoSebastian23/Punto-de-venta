using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;

namespace Punto_de_venta.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        void Add(Supplier supplier);
        Supplier? GetById(int id);
        IEnumerable<Supplier> GetAll();
        void Update(Supplier supplier);
        void Delete(int id);
        void Save();
  
    }
}

