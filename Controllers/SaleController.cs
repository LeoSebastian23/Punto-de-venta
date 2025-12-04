using System.Collections.Generic;
using Punto_de_venta.Models;
using Punto_de_venta.Services;

namespace Punto_de_venta.Controllers
{
    public class SaleController
    {
        private readonly SaleService _saleService;

        public SaleController(SaleService saleService)
        {
            _saleService = saleService;
        }

        public void CreateSale(Sale sale)
        {
            _saleService.RegisterSale(sale);
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _saleService.GetAllSales();
        }

        public Sale? GetSaleById(int id)
        {
            return _saleService.GetSaleById(id);
        }

        public IEnumerable<Sale> GetSalesOfToday()
        {
            return _saleService.GetSalesOfToday();
        }

        public IEnumerable<Sale> GetSalesOfMonth()
        {
            return _saleService.GetSalesOfMonth();
        }

    }
}
