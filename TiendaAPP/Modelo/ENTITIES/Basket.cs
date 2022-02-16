using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Basket
    {
        private String name;
        private int id;
        private String total;

        public Basket(string name, int id, String total)
        {
            this.name = name;
            this.id = id;
            this.total = total;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Total { get => total; set => total = value; }
    }
}
