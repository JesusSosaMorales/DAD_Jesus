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
    public partial class BuscarPaciente : Form
    {
        BuscarPacienteController controlador;
        
        public BuscarPaciente()
        {
            InitializeComponent();
            controlador = new BuscarPacienteController();
        }

        private void BuscarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = controlador.BuscarPaciente(txtDNI.Text,txtNHC.Text);
            llenarlista(pacientes);

            */
            List<Paciente> pacientes = new List<Paciente>();

            if (String.IsNullOrEmpty(txtDNI.Text) && String.IsNullOrEmpty(txtNHC.Text))
            {
                
                pacientes = controlador.BuscarTodosLosPacientes();
                MessageBox.Show("Se han encontrado " + pacientes.Count + " pacientes, para buscar un paciente en concreto rellene los campos a buscar");

            }
            else
            {
                if (String.IsNullOrEmpty(txtDNI.Text))
                {
                    
                    if (controlador.comprobarNHC(txtNHC.Text))
                    {
                        MessageBox.Show("Se ha buscado por NHC");
                        pacientes = controlador.BuscarPacienteByNHC(txtNHC.Text);
                    }
                    else
                    {
                        MessageBox.Show("EL NHC que se ha buscado no existe");
                    }


                }
                else if(String.IsNullOrEmpty(txtNHC.Text))
                {

                    if (controlador.comprobarDNI(txtDNI.Text))
                    {
                        MessageBox.Show("Se ha buscado por DNI");
                        pacientes = controlador.BuscarPacienteByDNI(txtDNI.Text);
                    }
                    else
                    {
                        MessageBox.Show("EL DNI que se ha buscado no existe");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede buscar por los dos campos.");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cancelar la creación del paciente?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNHC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
