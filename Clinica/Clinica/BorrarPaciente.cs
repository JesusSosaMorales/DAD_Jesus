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
    public partial class BorrarPaciente : Form
    {
        BuscarPacienteController controlador;

        public BorrarPaciente()
        {
            InitializeComponent();
            cmbElementos.SelectedIndex = 1;
            controlador = new BuscarPacienteController();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            List<Paciente> pacientes = new List<Paciente>();
            if (String.IsNullOrEmpty(txtElemento.Text))
            {

                pacientes = controlador.BuscarTodosLosPacientes();
                MessageBox.Show("Se han encontrado " + pacientes.Count + " pacientes, para buscar un paciente en concreto rellene los campos a buscar, si lo dejas vacios apareceran todos");

            }
            else
            {
                if (cmbElementos.SelectedItem.ToString().Equals("DNI"))
                {
                    if (controlador.comprobarDNI(txtElemento.Text))
                    {
                        MessageBox.Show("Se ha buscado por DNI");
                        pacientes = controlador.BuscarPacienteByDNI(txtElemento.Text);
                    }
                    else
                    {
                        MessageBox.Show("EL DNI que se ha buscado no existe");
                    }

                }
                if (cmbElementos.SelectedItem.ToString().Equals("NHC"))
                {
                    if (controlador.comprobarNHC(txtElemento.Text))
                    {
                        MessageBox.Show("Se ha buscado por NHC");
                        pacientes = controlador.BuscarPacienteByNHC(txtElemento.Text);
                    }
                    else
                    {
                        MessageBox.Show("EL NHC que se ha buscado no existe");
                    }


                }
            }
            llenarlista(pacientes);

        }
        public void llenarlista(List<Paciente> pacientes)
        {
            listView1.Items.Clear();
            foreach (Paciente p in pacientes)
            {


                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(p.Dni);
                //item.SubItems.Add(p.Dni);
                item.SubItems.Add(p.Nombre);
                item.SubItems.Add(p.Apellidos);
                item.SubItems.Add(p.Nhc + "");
                item.SubItems.Add(p.Direccion);
                item.SubItems.Add(p.Poblacion);
                // listView1.Items.Add(item);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = controlador.BuscarTodosLosPacientes();

            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    if (MessageBox.Show("¿Seguro que quieres eliminar el paciente con DNI: "+ focusedItem.SubItems[0].Text + "?", "Eliminar paciente",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        controlador.buscarParaBorrar(focusedItem.SubItems[0].Text,
                            focusedItem.SubItems[1].Text, 
                            focusedItem.SubItems[2].Text,
                            Int32.Parse(focusedItem.SubItems[3].Text),
                            focusedItem.SubItems[4].Text, focusedItem.SubItems[5].Text);
                        pacientes = controlador.BuscarPacienteByDNI(txtElemento.Text);
                        llenarlista(pacientes);


                    }

                }
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

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

