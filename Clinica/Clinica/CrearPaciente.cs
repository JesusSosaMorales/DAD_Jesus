using controlador;
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
    public partial class CrearPaciente : Form
    {
        CrearPacienteController controlador;

        public CrearPaciente()
        {
            InitializeComponent();
            controlador = new CrearPacienteController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CrearPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtDNI.Text = "";
            txtNHC.Text = "";
            txtNombre.Text = "";
            txtPoblacion.Text = "";


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool nhcValido = int.TryParse(txtNHC.Text, out int nhc);
            if (nhcValido && txtNHC.Text.Length == 10)
            {
                /*if (controlador.comprobarExistenciaDNI(txtDNI.Text))
                {
                    MessageBox.Show("Ese DNI ya esta registrado");
                }
                else
                {
                */

                    if (controlador.crearPaciente(txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtPoblacion.Text, txtDNI.Text, nhc))
                    {
                        btnAñadirDatos.Enabled = true;
                        MessageBox.Show("Se creó el paciente correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el paciente. Compruebe que todos los campos son correctos");
                    }
               // }

               
            }
            else
            {
                MessageBox.Show("El numero NHC es invalido, tiene que tener un tamaño de 10 numeros.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cancelar la creación del paciente?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAñadirDatos_Click(object sender, EventArgs e)
        {
           
            new CrearPacienteOtrosDatos(controlador).ShowDialog();
        }
    }
}

