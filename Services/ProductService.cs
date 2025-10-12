using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Services
{
    /// Capa intermedia entre los controladores (UI) y los repositorios (datos).
    /// Encapsula la lógica de negocio y validaciones del dominio Product.
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        //  Inyección de dependencias
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //  Obtener todos los productos
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        //  Buscar un producto por Id
        public Product GetProductById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
                throw new KeyNotFoundException("Producto no encontrado.");
            return product;
        }

        //  Agregar un nuevo producto
        public void CreateProduct(Product product)
        {
            // Lógica adicional de negocio
            if (product.SalePrice < product.PurchasePrice)
                throw new InvalidOperationException("El precio de venta no puede ser menor que el de compra.");

            _productRepository.Add(product);
        }

        //  Actualizar un producto
        public void UpdateProduct(Product product)
        {
            var existing = _productRepository.GetById(product.Id);
            if (existing == null)
                throw new KeyNotFoundException("No se puede actualizar un producto inexistente.");

            _productRepository.Update(product);
        }

        //  Eliminar producto
        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }

        //  Buscar productos
        public IEnumerable<Product> SearchProducts(string keyword)
        {
            return _productRepository.Search(keyword);
        }
    }
}
