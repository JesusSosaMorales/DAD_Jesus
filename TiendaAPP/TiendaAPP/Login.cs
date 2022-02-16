using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using MySql.Data.MySqlClient;
namespace TiendaAPP
{
    public partial class Login : Form
    {
        connection con = new connection();

        private bool showPassword = false;
        string username, password,rol;

        public Login()
        {
            InitializeComponent();
            panelLogin.BackColor = Color.FromArgb(155, Color.Black);
            
    }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            if (!showPassword)
            {
                showPassword = true;
                txtPassword.PasswordChar = '\0';
                btnViewPass.BackgroundImage = Properties.Resources._lock;
            }
            else
            {
                showPassword = false;
                txtPassword.PasswordChar = '•';
                btnViewPass.BackgroundImage = Properties.Resources.key_variant;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            connection c=new connection();
            UserDAO userDAO = new UserDAO(c);
            try
            {
                if (txtNombre.Text != "" && txtPassword.Text != "")
                {
                    /*
                                con.Open();
                                string query = "select * from users WHERE id_staff ='" + txtNombre.Text + "' AND password ='" + txtPassword.Text + "'";
                                MySqlDataReader row;
                                row = con.ExecuteReader(query);
                                if (row.HasRows)
                                {
                                    while (row.Read())
                                    {

                                        username = row["id_staff"].ToString();
                                        password = row["password"].ToString();
                                        rol = row["role"].ToString();


                                    }

                                */
                    Persona p = new Persona();

                    p = userDAO.select(txtNombre.Text, txtPassword.Text);
                    if (p !=null){
                                    cambiarForm();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña vacia", "Información");
                }
                limpiarTxt();
            }
            catch
            {
                MessageBox.Show("Error de conexion, contacte con un Admin o intentelo mas tarde", "Error");
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAcceder.PerformClick();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAcceder.PerformClick();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAcceder.PerformClick();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAcceder.PerformClick();
        }

        public void limpiarTxt()
        {
            txtNombre.Text = "";
            txtPassword.Text = "";

        }

        public void cambiarForm()
        {
            MessageBox.Show("Usuario correcto");
            Categorias c = new Categorias();
            c.Show();
        }
    }

    
}
