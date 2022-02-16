using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class UsuarioDAO
    {
        private GestorFichero gf;

        public UsuarioDAO(string rutaFichero)
        {
            gf = new GestorFichero(rutaFichero);
        }

        public UsuarioDAO(GestorFichero gf)
        {
            this.gf = gf;
        }

        public List<Usuario> selectAll()
        {
            List<Usuario> users = new List<Usuario>();
            foreach (string line in gf.leerlinea())
            {
                string[] data = line.Split(':');
                users.Add(new Usuario(data[0], data[1], data[2]));
            }
            return users;
        }

        public Usuario select(string user)
        {
            List<Usuario> users = new List<Usuario>();
            foreach (string line in gf.leerlinea())
            {
                string[] data = line.Split(':');
                if (data[0].Equals(user))
                    return new Usuario(data[0], data[1], data[2]);
            }
            return null;
        }
    }
}

