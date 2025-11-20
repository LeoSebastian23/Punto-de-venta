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

        public void CreateProduct(string name, string code, decimal salePrice, int stock)
        {
            var product = new Product(name, code, salePrice, stock);
            _repository.Add(product);
            _repository.Save();
        }

        public void UpdateProduct(int id, string name, string code, decimal salePrice, int stock)
        {
            var product = _repository.GetById(id);
            if (product == null) throw new Exception("Producto no encontrado.");

            // Actualizar propiedades
            typeof(Product).GetProperty("Name")!.SetValue(product, name);
            typeof(Product).GetProperty("Code")!.SetValue(product, code);
            typeof(Product).GetProperty("SalePrice")!.SetValue(product, salePrice);
            typeof(Product).GetProperty("Stock")!.SetValue(product, stock);

            _repository.Update(product);
            _repository.Save();
        }

        public void DeleteProduct(int id)
        {
            try
            {
                var product = _repository.GetById(id, includeRelations: false);
                if (product == null)
                    throw new Exception("El producto no existe.");

                _repository.Delete(product);
                _repository.Save();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                if (ex.InnerException != null && ex.InnerException.Message.Contains("FOREIGN KEY"))
                {
                    throw new Exception("El producto no se puede eliminar porque está asociado a una compra o venta.");
                }

                throw;
            }
        }


    }
}

