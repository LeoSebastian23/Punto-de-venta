using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;
using Punto_de_venta.Services;
using System.Collections.Generic;

namespace Punto_de_venta.Controllers
{
    public class SupplierController
    {
        private readonly SupplierService _service;

        public SupplierController(SupplierService service)
        {
            _service = service;
        }

        // ✅ Obtener todos los proveedores
        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _service.GetAllSuppliers();
        }

        // ✅ Crear proveedor (firma compatible con la vista)
        public void CreateSupplier(string name, string cuit, string phoneNumber)
        {
            var supplier = new Supplier(name, cuit, phoneNumber);
            _service.CreateSupplier(supplier);
        }

        // ✅ Actualizar proveedor (firma compatible con la vista)
        public void UpdateSupplier(int id, string name, string phoneNumber)
        {
            _service.UpdateSupplier(id, name, phoneNumber);
        }

        // ✅ Eliminar proveedor (firma compatible con la vista)
        public void DeleteSupplier(int id)
        {
            _service.DeleteSupplier(id);
        }
    }
}


