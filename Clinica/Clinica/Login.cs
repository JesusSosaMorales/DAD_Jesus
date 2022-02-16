using controlador;
using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Login : Form
    {
        LoginController controlador;
        public Login(LoginController controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = controlador.login(txtUser.Text, txtPswd.Text);
            if (user == null)
            {
                txtUser.Text = "";
                txtPswd.Text = "";
                error.Visible = true;
            }
            else
            {
                redirect(user);
                this.Hide();
            }
        }
        private void redirect(Usuario user)
        {
            switch (user.AccessLevel)
            {
                case AccessLevel.ADMINISTRATIVO:
                    new PersonalAdministrativo().Visible = true;
                    break;
                case AccessLevel.PERSONAL_SANITARIO:
                    new PersonalSanitario().Visible = true;
                    break;
                default:
                    MessageBox.Show("Bienvenido " + user.Username + "\nTe has registrado correctamente\n" +
                        "Lo lamentamos, esta sección está en construcción");
                    break;
            }
        }
    }
    
}
