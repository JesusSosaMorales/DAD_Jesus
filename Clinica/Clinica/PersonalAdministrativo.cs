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
    public partial class PersonalAdministrativo : Form
    {
        public PersonalAdministrativo()
        {
            InitializeComponent();
        }
        private void enConstruccion(string text)
        {
            MessageBox.Show("Esto se encuentra en construcción. Has clicado en " + text);
        }

        private void centroDeDóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("centro de dia");
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void PersonalAdministrativo_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir del programa?", "¿Cerrar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new CrearPaciente().ShowDialog();
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("cita");
        }

        private void guardarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("guardar actividad");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new BuscarPaciente().ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new BorrarPaciente().ShowDialog();
        }
    }
}
