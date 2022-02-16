using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public string id;
        public string description;
        //public string id { get => id; set => id = value; }
        //public string description { get => description; set => description = value; }

        public Categoria()
        {
        }

        public Categoria(string id, string description)
        {
            this.id = id;
            this.description = description;
        }

        
    }
}
