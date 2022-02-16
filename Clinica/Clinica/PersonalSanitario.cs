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
    public partial class PersonalSanitario : Form
    {
        public PersonalSanitario()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir del programa?", "¿Salir?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
        private void enConstruccion(string text)
        {
            MessageBox.Show("Esto se encuentra en construcción. Has clicado en " + text);
        }
  

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPacienteSanitario buscarPacienteSanitario = new BuscarPacienteSanitario();
            buscarPacienteSanitario.MdiParent = this;
            buscarPacienteSanitario.Show();

              
        }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("ver ficha pciente");
        }

        private void sacarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("sacar etiquetas paciente");
        }

        private void actasClínicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("actas clínicas del paciente");
        }

        private void buscarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("buscar nota");
        }

        private void eliminarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("eliminar nota");
        }

        private void crearNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("crear nota");
        }

        private void modificarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enConstruccion("modificar nota");
        }

        private void PersonalSanitario_Load(object sender, EventArgs e)
        {

        }

        private void minimizaActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void cerrarTodasLasVentanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            
        }

        private void cerrarVentanaActivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Minimized;
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
