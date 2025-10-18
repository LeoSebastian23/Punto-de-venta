using Punto_de_venta.Models;

namespace Punto_de_venta.Repositories.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product? GetById(int id);
        IEnumerable<Product> GetAll();
        void Update(Product product);
        void Delete(Product product);
        void Save();
    }
}


