using System.Collections.Generic;
namespace Punto_de_venta.Models
{
    public class Supplier
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string CUIT { get; private set; }

        public string? PhoneNumber { get; private set; } // ← opcional (puede ser null)

        // Relaciones
        public ICollection<Product> Products { get; private set; } = new List<Product>();
        public ICollection<Buy> Buys { get; private set; } = new List<Buy>();

        // Constructor requerido por EF
        protected Supplier() { }

        // Constructor principal
        public Supplier(string name, string cuit, string? phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre del proveedor es obligatorio.");

            if (string.IsNullOrWhiteSpace(cuit))
                throw new ArgumentException("El CUIT es obligatorio.");

            Name = name;
            CUIT = cuit;
            PhoneNumber = phoneNumber;
        }

        // Método para actualizar datos del proveedor
        public void UpdateInfo(string name, string? phone)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;

            if (!string.IsNullOrWhiteSpace(phone))
                PhoneNumber = phone;
        }
    }
}

