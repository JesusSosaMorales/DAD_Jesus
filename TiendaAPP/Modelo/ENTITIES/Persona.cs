
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private String id;
        private String password;
        private String rol;

        public Persona()
        {
        }

        public Persona(string id, string password, string rol)
        {
            this.Id = id;
            this.Password = password;
            this.Rol = rol;
        }

        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
