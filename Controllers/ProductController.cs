using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;
using Punto_de_venta.Services;

namespace Punto_de_venta.Controllers
{
    public class ProductController
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        public void CreateProduct(string name, string code, decimal purchasePrice, decimal salePrice, int stock, int? supplierId = null)
        {
            _service.CreateProduct(name, code, purchasePrice, salePrice, stock, supplierId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _service.GetAllProducts();
        }

        public void DeleteProduct(int id)
        {
            _service.DeleteProduct(id);
        }
    }
}

