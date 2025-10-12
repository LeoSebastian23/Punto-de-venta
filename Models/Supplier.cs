using System.Collections.Generic;

namespace Punto_de_venta.Models
{
    public class Supplier
    {
        // Clave primaria
        public int Id { get; private set; }

        // Atributos obligatorios
        public string Name { get; private set; }
        public string CUIT { get; private set; }
        public string PhoneNumber { get; private set; }

        // Relaciones (navegación)
        public ICollection<Product> Products { get; private set; } = new List<Product>();
        public ICollection<Buy> Buys { get; private set; } = new List<Buy>();

        // Constructor vacío (requerido por EF)
        private Supplier() { }

        // Constructor controlado (creación válida desde el inicio)
        public Supplier(string name, string cuit, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre del proveedor es obligatorio");

            if (string.IsNullOrWhiteSpace(cuit))
                throw new ArgumentException("El CUIT del proveedor es obligatorio");

            Name = name;
            CUIT = cuit;
            PhoneNumber = phoneNumber;
        }

        // Métodos de dominio (opcional: lógica propia de la entidad)
        public void UpdateContact(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("El teléfono no puede estar vacío");

            PhoneNumber = phoneNumber;
        }
    }
}
