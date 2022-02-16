using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class BasketDAO
    {
        connection c;


        public BasketDAO(connection con)
        {
            this.c = con;
        }

        public void insert(Basket b)
        {
            c.Open();
            string query = "INSERT INTO basket (id,name,total) VALUES ('" + b.Id + "','" + b.Name + "','" + b.Total + "');";
            c.ExecuteNonQuery(query);
            c.Close();
        }

    }
}
