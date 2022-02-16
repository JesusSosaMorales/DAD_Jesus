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
    public partial class Add : Form
    {
        
        int id;
        String producto;
        String precio;
        String nombre;
        double precioUnidad;
        int stock;
        int nuevoStock;
        int cantidadpedida;
        public Add()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            

            stock = Convert.ToInt32(txtStock.Text);
            cantidadpedida = Convert.ToInt32(txtCantidad.Text);
            precioUnidad = Convert.ToDouble(txtPreciouni.Text);
            nombre = txtNombreProducto.Text;
            id = Convert.ToInt32(txtProducto.Text);

            



            if (cantidadpedida > stock)
            {
                MessageBox.Show("Se ha solicitado una cantidad mayor al stock disponible, se ha cancelado el registro por seguridad.");
                txtCantidad.Text = "";

            }
            else
            {
                double precioTotal = (cantidadpedida * precioUnidad);
                nuevoStock = stock - cantidadpedida;
                precio = precioTotal.ToString();
                /**
                 * Creo el pedido
                 */
                connection con = new connection();
                Basket b = new Basket(nombre,id,precio);
                BasketDAO basketDao = new BasketDAO(con);
                basketDao.insert(b);
                /**
                 * Actualizo en stock
                 */
                connection con2 = new connection();
                CatmanDAO catmanDAO = new CatmanDAO(con2);
                catmanDAO.update(id, nuevoStock);
                MessageBox.Show("Pedido realizado, yendo al menu principal");
                
                Main m = new Main();
                m.Show();
                this.Close();

            }



        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
