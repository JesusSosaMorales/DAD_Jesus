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
    public partial class Main : Form
    {
        String id,name,category,description,price,quantity;

        public Main()
        {
            InitializeComponent();
        }

        public void llenarData(DataGridView grind)
        {
            connection con = new connection();
            CatmanDAO catmanDAO = new CatmanDAO(con);
            grind.DataSource = catmanDAO.selectAll();

        }

        public void selectJeans(DataGridView grind)
        {
            connection con = new connection();
            CatmanDAO catmanDAO = new CatmanDAO(con);
            grind.DataSource = catmanDAO.selectByCategoria("Jeans");

            
        }

        public void selectShirts(DataGridView grind)
        {
            connection con = new connection();
            CatmanDAO catmanDAO = new CatmanDAO(con);
            grind.DataSource = catmanDAO.selectByCategoria("Shirts");
        }
        public void selectTshirts(DataGridView grind)
        {
            connection con = new connection();
            CatmanDAO catmanDAO = new CatmanDAO(con);
            grind.DataSource = catmanDAO.selectByCategoria("T-shirts");
   
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID: " + id +
                "\nNAME: " + Name +
                "\nCATEGORY: " + category +
                "\nDESCRIPTION: " + description +
                "\nPRICE: " + price +
                "\nQUANTITY: " + quantity);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                String opcion = lista.SelectedItem.ToString();
                if (opcion.Equals("Jeans"))
                {

                    selectJeans(dataview);
                    MessageBox.Show("Se ha filtrado por  Jeans");

                }
                if (opcion.Equals("Shirts"))
                {
                    selectShirts(dataview);
                    MessageBox.Show("Se ha filtrado por  Shirts");

                }
                if (opcion.Equals("T-shirts"))
                {
                    selectTshirts(dataview);
                    MessageBox.Show("Se ha filtrado por  T-shirts");

                }
                if (opcion.Equals("ALL"))
                {
                    llenarData(dataview);
                    MessageBox.Show("Se ha mostrado todos el catalogo");
                }

            }
            else
            {
                MessageBox.Show("Selecciona la categoria por la que quieras filtrar");
            }
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (id != null && !id.Equals(""))
            {
                Add a = new Add();
                a.txtProducto.Text = id;
                a.txtStock.Text = quantity;
                a.txtNombreProducto.Text = name;
                a.txtPreciouni.Text = price;

                a.Show();
                this.Close();

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataview.RowHeadersVisible = false;
            llenarData(dataview);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if(dataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataview.CurrentRow.Selected = true;
                id = dataview.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                price = dataview.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString();
                name = dataview.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                category = dataview.Rows[e.RowIndex].Cells["Categoria"].FormattedValue.ToString();
                description = dataview.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                quantity = dataview.Rows[e.RowIndex].Cells["Cantidad"].FormattedValue.ToString();
               
            }
            

        }
    }
}
