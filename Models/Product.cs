using System;
using System.Collections.Generic;

namespace Punto_de_venta.Models
{
    public class Product
    {
        // Clave primaria
        public int Id { get; private set; }

        // Atributos
        public string Name { get; private set; }
        public string Code { get; private set; }
        public decimal PurchasePrice { get; private set; }
        public decimal UnitCost { get; private set; }
        public int Stock { get; private set; }

        // Relaciones
        public int SupplierId { get; private set; }
        public Supplier Supplier { get; private set; }

        public ICollection<Buy> Buys { get; private set; } = new List<Buy>();

        // Constructor vacío (para EF)
        private Product() { }

        // Constructor controlado
        public Product(string name, string code, decimal purchasePrice, decimal unitCost, int stock, int supplierId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre del producto es obligatorio");

            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("El código del producto es obligatorio");

            if (unitCost <= 0)
                throw new ArgumentException("El precio unitario debe ser mayor a 0");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo");

            Name = name;
            Code = code;
            PurchasePrice = purchasePrice;
            UnitCost = unitCost;
            Stock = stock;
            SupplierId = supplierId;
        }

        // Métodos de dominio
        public void AddStock(int amount)
        {
            if (amount <= 0) throw new ArgumentException("La cantidad debe ser positiva");
            Stock += amount;
        }

        public void RemoveStock(int amount)
        {
            if (amount <= 0) throw new ArgumentException("La cantidad debe ser positiva");
            if (Stock - amount < 0) throw new InvalidOperationException("No hay suficiente stock");
            Stock -= amount;
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice <= 0) throw new ArgumentException("El precio debe ser mayor a 0");
            UnitCost = newPrice;
        }
    }
}

