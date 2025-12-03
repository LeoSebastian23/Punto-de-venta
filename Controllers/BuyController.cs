using Punto_de_venta.Models;
using Punto_de_venta.Models.IVAStrategy;
using Punto_de_venta.Repositories.Interfaces;
using Punto_de_venta.Services;
using static Punto_de_venta.Models.IVAStrategy.FacturaExenta;

namespace Punto_de_venta.Controllers
{
    public class BuyController
    {
        private readonly BuyService _service;

        public BuyController(BuyService service)
        {
            _service = service;
        }

        public void RegisterBuy(Supplier supplier, string invoiceNumber, List<(Product product, int quantity, decimal unitCost)> items, string invoiceType, decimal? porcentajeGanancia = null)
        {
            var buy = Buy.Create(supplier, invoiceNumber);

            foreach (var (product, quantity, unitCost) in items)
            {
                buy.AddItem(new BuyItem(product, quantity, unitCost));
            }

            ITaxStrategy taxStrategy = invoiceType switch
            {
                "A" => new FacturaA(),
                "B" => new FacturaB(),
                "E" => new FacturaExenta(),
                _ => throw new ArgumentException("Tipo de factura inválido")
            };

            _service.RegisterBuy(buy, taxStrategy, porcentajeGanancia);
        }

        public IEnumerable<Buy> GetAllBuys()
        {
            return _service.GetAllBuys();
        }

    }
}

