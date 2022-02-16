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
    public partial class CrearPacienteOtrosDatos : Form
    {
        CrearPacienteController controlador;
        public CrearPacienteOtrosDatos(CrearPacienteController controlador)
        {
            this.controlador = controlador;
            InitializeComponent();
           
        }
        private void CrearPacienteOtrosDatosLoad(object sender, EventArgs e)
        {
            txtNombre.Text = controlador.PacienteCreado.Nombre + " " + controlador.PacienteCreado.Apellidos;
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (txtFechaNacimiento.MaskCompleted)
            {
                bool ok = int.TryParse(txtNumAsegurado.Text, out int numAsegurado);
                if (ok)
                    if (controlador.actualizarPaciente(txtFechaNacimiento.Text, cbxSexo.SelectedItem.Equals("Hombre"),
                    txtProfecion.Text, txtEmail.Text, txtTlf.Text, listViewTelefonos.Items.Cast<ListViewItem>().Select(item => item.Text).ToList(),
                    txtAlergias.Text, txtEnfermedades.Text, cbxGrupoSanguineo.SelectedItem.ToString(), txtEntidadSanitaria.Text,
                    numAsegurado))
                    {
                        MessageBox.Show("Se han guardado los datos del paciente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar guardar los datos");
                    }
                else
                    MessageBox.Show("Ocurrió un error al intentar guardar los datos");
            }

        }

        private void btnAddTlf_Click(object sender, EventArgs e)
        {

            if (txtAddTlf.MaskCompleted)
            {
                listViewTelefonos.Items.Add(txtAddTlf.Text);
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = "";
            txtAddTlf.Text = "";
            txtProfecion.Text = "";
            txtEmail.Text = "";
            txtTlf.Text = "";
        }

        private void txtProfecion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxGrupoSanguineo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cancelar la creación de los datos extras de un paciente?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearPacienteOtrosDatos_Load(object sender, EventArgs e)
        {
            txtNombre.Text = controlador.PacienteCreado.Nombre + " " + controlador.PacienteCreado.Apellidos;
        }
    }
}
