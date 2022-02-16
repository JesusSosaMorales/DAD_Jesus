using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaAPP
{
    public partial class Categorias : Form
    {
        String id_category, description;
        connection con = new connection();
        public Categorias()
        {
            InitializeComponent();
            crearbtn();
            
            

        }

      


        public void crearbtn()
        {
            int i = 0;
            List<Categoria> list = new List<Categoria>();
            connection con = new connection();
            CategoriaDAO categoriaDAO = new CategoriaDAO(con);
            list = categoriaDAO.selectAll();

            foreach (Categoria c in list)
            {
                Button b = new Button();
                b.ForeColor = Color.White;
                b.Margin = new Padding(4, 3, 4, 3);
                b.BackColor = Color.Black;
                b.Location = new Point(30, 30 + i * 60);
                b.Size = new Size(125, 54);
                b.Text = c.description;

                if (c.description.Equals("man"))
                {
                    b.Click += button1_Click;
                }
                else
                {
                    b.Click += button2_Click;
                }
                this.Controls.Add(b);
                i++;
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion no se encuentran disponible");
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
