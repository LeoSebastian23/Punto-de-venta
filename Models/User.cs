using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    public class User   
    {
        public int Id { get; private set; }  
        public string Name { get; private set; }
        public string Password { get; private set; }

        protected User() { } // EF necesita constructor vacío

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}



