using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo;
namespace controlador
{
    public class LoginController
    {
        private GestorFichero gf;
        public LoginController()
        {
            gf = new GestorFichero("users.txt");
        }

        public Usuario login(string userStr, string pwdStr)
        {
            UsuarioDAO userDao = new UsuarioDAO(gf);
            Usuario user = null;
            if (!String.IsNullOrEmpty(userStr))
            {
                user = userDao.select(userStr);
                if (user != null)
                    if (checkCredentials(user, pwdStr))
                        return user;
            }
            return null;
        }
        public Boolean checkCredentials(Usuario user, string pwdStr)
        {
            if (!String.IsNullOrEmpty(pwdStr))
                if (user.Password.Equals(pwdStr))
                    return true;
            return false;
        }
    }
}
