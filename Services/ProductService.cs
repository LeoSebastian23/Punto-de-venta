using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Product? GetProductById(int id)
        {
            return _repository.GetById(id);
        }

        public void CreateProduct(string name, string code, decimal purchasePrice, decimal salePrice, int stock, int? supplierId = null)
        {
            var product = new Product(name, code, purchasePrice, salePrice, stock, supplierId);
            _repository.Add(product);
            _repository.Save();
        }

        public void UpdateProduct(Product product)
        {
            _repository.Update(product);
            _repository.Save();
        }

        public void DeleteProduct(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
                throw new Exception("El producto no existe o ya fue eliminado.");

            if (product.BuyItems.Any())
                throw new InvalidOperationException("No se puede eliminar un producto asociado a compras registradas.");

            _repository.Delete(product);
            _repository.Save();
        }
    }
}

