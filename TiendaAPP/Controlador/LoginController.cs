using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TiendaAPP;

namespace Controlador
{
    public class LoginController
    {
        connection con = new connection();

        private bool showPassword = false;
        string username, password, rol;

        Persona user;

        public LoginController()
        {

        }

        
        public string redirect()
        {
            if (user != null)
            {
                return user.Rol;
            }
            return null;
        }

        public string getUsername()
        {
            return user.Id;
        }
    }
}
