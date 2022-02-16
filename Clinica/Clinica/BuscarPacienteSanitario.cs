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
    public partial class BuscarPacienteSanitario : Form
    {
        BuscarPacienteController controlador;
        public BuscarPacienteSanitario()
        {
            InitializeComponent();
            controlador = new BuscarPacienteController();
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
                else if (String.IsNullOrEmpty(txtNHC.Text))
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
            Console.WriteLine(pacientes.Count);
            llenarlista(pacientes);
            
        }



        public void llenarlista(List<Paciente> pacientes)
        {
            treeView.Nodes.Clear();
            foreach (Paciente p in pacientes)
            {
                TreeNode nodop = new TreeNode();
                nodop.Text = p.Nombre + " " + p.Apellidos;

                TreeNode dni = new TreeNode();
                TreeNode nhc = new TreeNode();
                TreeNode direccion = new TreeNode();
                TreeNode poblacion = new TreeNode();

                dni.Text = p.Dni;
                nhc.Text = p.Nhc+"";
                direccion.Text = p.Direccion;
                poblacion.Text = p.Poblacion;


                nodop.Nodes.Add(dni.Text);
                nodop.Nodes.Add(nhc.Text);
                nodop.Nodes.Add(direccion.Text);
                nodop.Nodes.Add(poblacion.Text);

                treeView.Nodes.Add(nodop);

            }


        }



    }
}
