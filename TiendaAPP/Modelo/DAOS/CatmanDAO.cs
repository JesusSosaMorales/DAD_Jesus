using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public class CatmanDAO
    {
        connection c;


        public CatmanDAO(connection con)
        {
            this.c = con;
        }
		public List<Catman> selectAll()
		{
            int id, cantidad;
            double precio;
            String nombre, categoria, descripcion;

            List<Catman> lista = new List<Catman>();
            c.Open();
            string query = "select * from catman";
            MySqlDataReader row;
            row = c.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    id = Int32.Parse(row["id"].ToString());
                    nombre = row["name"].ToString();
                    categoria = row["category"].ToString();
                    descripcion = row["description"].ToString();
                    precio = Convert.ToDouble(row["price"].ToString());
                    cantidad = Int32.Parse(row["quantity"].ToString());

                    Catman c = new Catman(id,precio,cantidad,nombre,categoria,descripcion);
                    lista.Add(c);
                }
            }
            else
            {
                return null;
            }
            return lista;
            c.Close();
        }

        public List<Catman> selectByCategoria(String cat)
        {
            int id, cantidad;
            double precio;
            String nombre, categoria, descripcion;

            List<Catman> lista = new List<Catman>();
            c.Open();
            string query = "select * from catman WHERE category ='" + cat + "'";
            MySqlDataReader row;
            row = c.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    id = Int32.Parse(row["id"].ToString());
                    nombre = row["name"].ToString();
                    categoria = row["category"].ToString();
                    descripcion = row["description"].ToString();
                    precio = Convert.ToDouble(row["price"].ToString());
                    cantidad = Int32.Parse(row["quantity"].ToString());

                    Catman c = new Catman(id, precio, cantidad, nombre, categoria, descripcion);
                    lista.Add(c);
                }
            }
            else
            {
                return null;
            }
            return lista;
            c.Close();
        }

        public void update(int id,int nuevoStock)
        {
            c.Open();
            string query = "UPDATE catman SET  quantity='" + nuevoStock + "' WHERE id ='" + id + "';";
            c.ExecuteNonQuery(query);
            c.Close();

        }
    }

}
