using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CategoriaDAO
    {
        connection c;


        public CategoriaDAO(connection con)
        {
            this.c = con;


        }

        public List<Categoria> selectAll()
        {
            String id,desc;

            List < Categoria > lista = new List<Categoria>();
            c.Open();
            string query = "select * from categories";
            MySqlDataReader row;
            row = c.ExecuteReader(query);
            while (row.Read())
            {


                id = row["id_category"].ToString();
                desc = row["description"].ToString();

                Categoria c = new Categoria(id, desc);

                lista.Add(c);

            }

                return lista;
            c.Close();
        }


    }
}
