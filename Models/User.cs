using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Models
{
    internal class User
    {
        private long Id { get; set; }
        private string name { get; set; }
        private string password { get; set; }

        public User(long id, string name, string password)
        {
            this.Id = id;
            this.name = name;
            this.password = password;
        }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public User() { }
    }
}
