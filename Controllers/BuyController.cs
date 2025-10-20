using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Services;
using Punto_de_venta.Models;

namespace Punto_de_venta.Controllers
{
    public class BuyController
    {
        private readonly BuyService _service;

        public BuyController(BuyService service)
        {
            _service = service;
        }
        public void RegisterBuy(int? supplierId, int productId, int quantity, decimal unitPrice)
        {
            var buy = new Buy(supplierId);
            var item = new BuyItem(productId, quantity, unitPrice);
            buy.AddItem(item);

            _service.RegisterBuy(buy);
        }


        public IEnumerable<Buy> GetAllBuys() => _service.GetAllBuys();
    }
}
