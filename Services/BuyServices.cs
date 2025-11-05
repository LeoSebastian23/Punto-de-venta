using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;

namespace Punto_de_venta.Services
{
    public class BuyService
    {
        private readonly IBuyRepository _buyRepository;
        private readonly StockService _stockService;
        private readonly PricingService _pricingService;

        public BuyService(IBuyRepository buyRepo, StockService stockService, PricingService pricingService)
        {
            _buyRepository = buyRepo;
            _stockService = stockService;
            _pricingService = pricingService;
        }

        public void RegisterBuy(Buy buy, ITaxStrategy taxStrategy, decimal? porcentajeGanancia = null)
        {
            if (buy == null)
                throw new ArgumentNullException(nameof(buy));

            foreach (var item in buy.Items)
            {
                // Actualiza el stock
                _stockService.AddStock(item.Product, item.Quantity);

                // Aplica ganancia si corresponde
                if (porcentajeGanancia.HasValue)
                    _pricingService.ApplyProfitMargin(item.Product, item.UnitPrice, porcentajeGanancia.Value);
            }

            // Calcula total con impuestos
            buy.CalculateTotal(taxStrategy);

            // Persiste la compra
            _buyRepository.Add(buy);
            _buyRepository.Save();
        }
    }
}

