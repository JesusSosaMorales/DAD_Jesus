using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Catman
    {
        private int id,cantidad;
        double precio;
        private String nombre, categoria, descripcion;

        public Catman()
        {
        }

        public Catman(int id, double precio, int cantidad, string nombre, string categoria, string descripcion)
        {
            this.id = id;
            this.precio = precio;
            this.cantidad = cantidad;
            this.nombre = nombre;
            this.categoria = categoria;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
