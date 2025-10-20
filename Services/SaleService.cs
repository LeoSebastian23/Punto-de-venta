using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Services
{
    /// Lógica de negocio para registrar ventas, validar stock y actualizar productos.
    public class SaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;

        public SaleService(ISaleRepository saleRepository, IProductRepository productRepository)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
        }

        /// Registra una venta, valida stock y descuenta productos.

        public void RegisterSale(Sale sale)
        {
            foreach (var item in sale.Items)
            {
                var product = _productRepository.GetById(item.ProductId);
                if (product == null)
                    throw new KeyNotFoundException($"Producto con ID {item.ProductId} no encontrado.");

                if (product.Stock < item.Quantity)
                    throw new InvalidOperationException($"Stock insuficiente para el producto '{product.Name}'.");

                // Descontar stock
                product.RemoveStock(item.Quantity);

                // Persistir cambios del producto
                _productRepository.Update(product);
            }

            // Registrar venta
            _saleRepository.Add(sale);
            _saleRepository.SaveChanges();
        }

        /// Obtiene todas las ventas registradas.
        public IEnumerable<Sale> GetAllSales()
        {
            return _saleRepository.GetAll();
        }

        /// Busca una venta por ID.
        public Sale GetSaleById(int id)
        {
            var sale = _saleRepository.GetById(id);
            if (sale == null)
                throw new KeyNotFoundException("Venta no encontrada.");
            return sale;
        }
    }
}

