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
        private readonly IProductRepository _productRepository;

        public BuyService(IBuyRepository buyRepo, IProductRepository prodRepo)
        {
            _buyRepository = buyRepo;
            _productRepository = prodRepo;
        }

        public void RegisterBuy(Buy buy)
        {
            foreach (var item in buy.Items)
            {
                var product = _productRepository.GetById(item.ProductId);
                product.AddStock(item.Quantity);
            }

            _buyRepository.Add(buy);
            _buyRepository.Save();
        }

        public IEnumerable<Buy> GetAllBuys() => _buyRepository.GetAll();
    }
}

