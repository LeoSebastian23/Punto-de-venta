using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Services
{
    public class StockService
    {
        private readonly IProductRepository _productRepository;

        public StockService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddStock(Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            product.AddStock(quantity);
            _productRepository.Update(product);
        }
    }
}

