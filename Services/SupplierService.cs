using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Punto_de_venta.Models;
using Punto_de_venta.Repositories.Interfaces;
using System.Collections.Generic;

namespace Punto_de_venta.Services
{
    public class SupplierService
    {
        private readonly ISupplierRepository _repository;

        public SupplierService(ISupplierRepository repository)
        {
            _repository = repository;
        }

        //  Crear nuevo proveedor
        public void CreateSupplier(Supplier supplier)
        {
            _repository.Add(supplier);
        }

        //  Obtener todos
        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _repository.GetAll();
        }

        //  Actualizar proveedor existente
        public void UpdateSupplier(int id, string name, string phoneNumber)
        {
            var supplier = _repository.GetById(id);
            if (supplier == null)
                throw new KeyNotFoundException("Proveedor no encontrado.");

            supplier.UpdateInfo(name, phoneNumber);
            _repository.Update(supplier);
        }

        //  Eliminar proveedor
        public void DeleteSupplier(int id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (InvalidOperationException ex)
            {
                // Lógica para manejar errores de negocio
                throw new InvalidOperationException(ex.Message);
            }
            catch (Exception)
            {
                // Cualquier otro error inesperado
                throw new Exception("Error al eliminar el proveedor.");
            }
        }
    }
}

