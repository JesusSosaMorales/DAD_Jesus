using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    
    public class UserDAO
    {
       connection c;


        public UserDAO(connection con)
        {
            this.c = con;


        }

		public Persona select(String nombre,String password)
		{
            Persona p = new Persona(); ;
            String name, pass, role;
            c.Open();
            string query = "select * from users WHERE id_staff ='" + nombre + "' AND password ='" + password + "'";
            MySqlDataReader row;
            row = c.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {

                    name = row["id_staff"].ToString();
                    pass = row["password"].ToString();
                    role = row["role"].ToString();

                    p = new Persona(name, pass, role);
                }
            }
            else
            {
                return null;
            }
            return p;
            c.Close();
                
		}

	}

    


}
