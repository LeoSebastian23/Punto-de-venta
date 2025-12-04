using System;
using System.Collections.Generic;
using System.Linq;
using Punto_de_venta.Data;
using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Services
{
    public class SaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;
        private readonly AppDbContext _context;

        public SaleService(
            ISaleRepository saleRepository,
            IProductRepository productRepository,
            AppDbContext context)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
            _context = context;
        }

        public void RegisterSale(Sale sale)
        {
            if (sale == null)
                throw new ArgumentNullException(nameof(sale));

            if (!sale.Items.Any())
                throw new InvalidOperationException("No se puede registrar una venta sin ítems.");

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                foreach (var item in sale.Items)
                {
                    var product = item.Product ?? _productRepository.GetById(item.ProductId);

                    if (product == null)
                        throw new InvalidOperationException($"Producto con id {item.ProductId} no encontrado.");

                    product.RemoveStock(item.Quantity);
                }

                _saleRepository.Add(sale);
                _saleRepository.SaveChanges();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _saleRepository.GetAll();
        }

        public Sale? GetSaleById(int id)
        {
            return _saleRepository.GetById(id);
        }

        public IEnumerable<Sale> GetSalesOfToday()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);

            return _saleRepository.GetByDateRange(today, tomorrow);
        }

        public IEnumerable<Sale> GetSalesOfMonth()
        {
            var firstDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var firstDayNextMonth = firstDay.AddMonths(1);

            return _saleRepository.GetByDateRange(firstDay, firstDayNextMonth);
        }

    }
}
