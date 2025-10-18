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
        public decimal PurchasePrice { get; private set; }  // costo de compra
        public decimal SalePrice { get; private set; }      // precio de venta
        public int Stock { get; private set; }



        // Relaciones
        public int? SupplierId { get; private set; }
        public Supplier? Supplier { get; private set; }
        public ICollection<BuyItem> BuyItems { get; private set; } = new List<BuyItem>();
        public ICollection<SaleItem> SaleItems { get; private set; } = new List<SaleItem>();

        // Constructor protegido (para EF)
        protected Product() { }


        // Constructor de dominio
        public Product(string name, string code, decimal purchasePrice, decimal salePrice, int stock, int? supplierId = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre del producto es obligatorio");

            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("El código del producto es obligatorio");

            if (salePrice <= 0)
                throw new ArgumentException("El precio de venta debe ser mayor a 0");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo");

            Name = name;
            Code = code;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
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

        public void UpdateSalePrice(decimal newSalePrice)
        {
            if (newSalePrice <= 0) throw new ArgumentException("El precio de venta debe ser mayor a 0");
            SalePrice = newSalePrice;
        }
    }
}

