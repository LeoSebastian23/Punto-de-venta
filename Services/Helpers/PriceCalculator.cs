using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Services.Helpers
{
    public static class PriceCalculator
    {
        // Calcula el precio de venta a partir del costo y porcentaje de ganancia
        public static decimal CalcularPrecioVenta(decimal costo, decimal porcentajeGanancia)
        {
            if (costo <= 0) throw new ArgumentException("El costo debe ser mayor que cero.");
            if (porcentajeGanancia < 0) throw new ArgumentException("El porcentaje no puede ser negativo.");

            return Math.Round(costo * (1 + porcentajeGanancia / 100), 2);
        }

        // Calcula el porcentaje de ganancia real a partir del costo y el precio de venta
        public static decimal CalcularPorcentajeGanancia(decimal costo, decimal precioVenta)
        {
            if (costo <= 0) throw new ArgumentException("El costo debe ser mayor que cero.");
            if (precioVenta <= costo) throw new ArgumentException("El precio de venta no puede ser menor que el costo.");

            return Math.Round(((precioVenta - costo) / costo) * 100, 2);
        }

        // Permite redondear el precio de venta a la decena más cercana
        public static decimal Redondear(decimal precio)
        {
            return Math.Round(precio / 10) * 10;
        }
    }
}

