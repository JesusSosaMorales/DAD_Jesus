
namespace Clinica
{
    partial class PersonalSanitario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actasClínicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeDóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizaActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanaActivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodasLasVentanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.centroDeDóaToolStripMenuItem,
            this.ventanasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.verFichaToolStripMenuItem,
            this.sacarFichaToolStripMenuItem,
            this.actasClínicasToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // verFichaToolStripMenuItem
            // 
            this.verFichaToolStripMenuItem.Name = "verFichaToolStripMenuItem";
            this.verFichaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.verFichaToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.verFichaToolStripMenuItem.Text = "Ver ficha";
            this.verFichaToolStripMenuItem.Click += new System.EventHandler(this.verFichaToolStripMenuItem_Click);
            // 
            // sacarFichaToolStripMenuItem
            // 
            this.sacarFichaToolStripMenuItem.Name = "sacarFichaToolStripMenuItem";
            this.sacarFichaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.sacarFichaToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.sacarFichaToolStripMenuItem.Text = "Sacar etiquetas";
            this.sacarFichaToolStripMenuItem.Click += new System.EventHandler(this.sacarFichaToolStripMenuItem_Click);
            // 
            // actasClínicasToolStripMenuItem
            // 
            this.actasClínicasToolStripMenuItem.Name = "actasClínicasToolStripMenuItem";
            this.actasClínicasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.actasClínicasToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.actasClínicasToolStripMenuItem.Text = "Actas clínicas";
            this.actasClínicasToolStripMenuItem.Click += new System.EventHandler(this.actasClínicasToolStripMenuItem_Click);
            // 
            // centroDeDóaToolStripMenuItem
            // 
            this.centroDeDóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarNotaToolStripMenuItem,
            this.eliminarNotaToolStripMenuItem,
            this.crearNotaToolStripMenuItem,
            this.modificarNotaToolStripMenuItem});
            this.centroDeDóaToolStripMenuItem.Name = "centroDeDóaToolStripMenuItem";
            this.centroDeDóaToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.centroDeDóaToolStripMenuItem.Text = "Notas";
            // 
            // buscarNotaToolStripMenuItem
            // 
            this.buscarNotaToolStripMenuItem.Name = "buscarNotaToolStripMenuItem";
            this.buscarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.buscarNotaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.buscarNotaToolStripMenuItem.Text = "Buscar nota";
            this.buscarNotaToolStripMenuItem.Click += new System.EventHandler(this.buscarNotaToolStripMenuItem_Click);
            // 
            // eliminarNotaToolStripMenuItem
            // 
            this.eliminarNotaToolStripMenuItem.Name = "eliminarNotaToolStripMenuItem";
            this.eliminarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarNotaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.eliminarNotaToolStripMenuItem.Text = "Eliminar nota";
            this.eliminarNotaToolStripMenuItem.Click += new System.EventHandler(this.eliminarNotaToolStripMenuItem_Click);
            // 
            // crearNotaToolStripMenuItem
            // 
            this.crearNotaToolStripMenuItem.Name = "crearNotaToolStripMenuItem";
            this.crearNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.crearNotaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.crearNotaToolStripMenuItem.Text = "Crear nota";
            this.crearNotaToolStripMenuItem.Click += new System.EventHandler(this.crearNotaToolStripMenuItem_Click);
            // 
            // modificarNotaToolStripMenuItem
            // 
            this.modificarNotaToolStripMenuItem.Name = "modificarNotaToolStripMenuItem";
            this.modificarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modificarNotaToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.modificarNotaToolStripMenuItem.Text = "Modificar nota";
            this.modificarNotaToolStripMenuItem.Click += new System.EventHandler(this.modificarNotaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizarToolStripMenuItem,
            this.minimizaActualToolStripMenuItem,
            this.cerrarVentanaActivaToolStripMenuItem,
            this.cerrarTodasLasVentanasToolStripMenuItem,
            this.cascadaToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.minimizarToolStripMenuItem.Text = "Minimizar Todas";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // minimizaActualToolStripMenuItem
            // 
            this.minimizaActualToolStripMenuItem.Name = "minimizaActualToolStripMenuItem";
            this.minimizaActualToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.minimizaActualToolStripMenuItem.Text = "Maximizar Todas";
            this.minimizaActualToolStripMenuItem.Click += new System.EventHandler(this.minimizaActualToolStripMenuItem_Click);
            // 
            // cerrarVentanaActivaToolStripMenuItem
            // 
            this.cerrarVentanaActivaToolStripMenuItem.Name = "cerrarVentanaActivaToolStripMenuItem";
            this.cerrarVentanaActivaToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.cerrarVentanaActivaToolStripMenuItem.Text = "Cerrar Ventana Activa";
            this.cerrarVentanaActivaToolStripMenuItem.Click += new System.EventHandler(this.cerrarVentanaActivaToolStripMenuItem_Click);
            // 
            // cerrarTodasLasVentanasToolStripMenuItem
            // 
            this.cerrarTodasLasVentanasToolStripMenuItem.Name = "cerrarTodasLasVentanasToolStripMenuItem";
            this.cerrarTodasLasVentanasToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.cerrarTodasLasVentanasToolStripMenuItem.Text = "Cerrar Todas Las Ventanas";
            this.cerrarTodasLasVentanasToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodasLasVentanasToolStripMenuItem_Click);
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // PersonalSanitario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 978);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonalSanitario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal - Sanitario";
            this.Load += new System.EventHandler(this.PersonalSanitario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroDeDóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actasClínicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizaActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanaActivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodasLasVentanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
    }
}