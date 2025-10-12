using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                _saleService.RegisterSale(sale);
                Console.WriteLine("✅ Venta registrada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al registrar la venta: {ex.Message}");
            }
        }

        public void ShowAllSales()
        {
            var sales = _saleService.GetAllSales();
            foreach (var s in sales)
            {
                Console.WriteLine($"\n🧾 Venta #{s.Id} - Fecha: {s.Date} - Total: {s.TotalAmount}");
                foreach (var item in s.Items)
                {
                    Console.WriteLine($"  {item.Quantity} x {item.Product.Name} - ${item.Subtotal}");
                }
            }
        }
    }
}
