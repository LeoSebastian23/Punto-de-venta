using System.Collections.Generic;
using Punto_de_venta.Models;

namespace Punto_de_venta.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product? GetById(int id);
        Product? GetByCode(string code);
        IEnumerable<Product> GetAll();

        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
        void Save();
        void Delete(Product product);


    }
}
