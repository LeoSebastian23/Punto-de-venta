using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;
using Punto_de_venta.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Services
{
    public class PricingService
    {
        private readonly IProductRepository _productRepository;

        public PricingService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void ApplyProfitMargin(Product product, decimal unitCost, decimal porcentajeGanancia)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (porcentajeGanancia < 0) throw new ArgumentException("El porcentaje no puede ser negativo.");

            decimal nuevoPrecio = PriceCalculator.CalcularPrecioVenta(unitCost, porcentajeGanancia);
            decimal redondeado = PriceCalculator.Redondear(nuevoPrecio);
            product.UpdateSalePrice(redondeado);

            _productRepository.Update(product);
        }
    }
}

