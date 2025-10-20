using Punto_de_venta.Models;

namespace Punto_de_venta.Repositories.Interfaces
{
    /// Define las operaciones básicas de acceso a datos para la entidad Product.

    public interface IProductRepository
    {
        // 🔍 Obtener un producto por su Id
        Product? GetById(int id);

        // 📋 Obtener todos los productos
        IEnumerable<Product> GetAll();

        // ➕ Agregar un nuevo producto
        void Add(Product product);

        // ✏️ Actualizar un producto existente
        void Update(Product product);

        // ❌ Eliminar un producto por Id
        void Delete(int id);

        // 🔎 Buscar productos por nombre o código
        IEnumerable<Product> Search(string keyword);
    }
}

