
namespace Clinica
{
    partial class CrearPacienteOtrosDatos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.txtAddTlf = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProfecion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTelefonos = new System.Windows.Forms.ListView();
            this.btnAddTlf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNumAsegurado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEntidadSanitaria = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEnfermedades = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 390);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar2);
            this.tabPage1.Controls.Add(this.txtAddTlf);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cbxSexo);
            this.tabPage1.Controls.Add(this.txtFechaNacimiento);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtProfecion);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listViewTelefonos);
            this.tabPage1.Controls.Add(this.btnAddTlf);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTlf);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.Location = new System.Drawing.Point(565, 308);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(201, 23);
            this.btnLimpiar2.TabIndex = 41;
            this.btnLimpiar2.Text = "🗑️ Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // txtAddTlf
            // 
            this.txtAddTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTlf.Location = new System.Drawing.Point(565, 39);
            this.txtAddTlf.Mask = "+(99) 000 000 000";
            this.txtAddTlf.Name = "txtAddTlf";
            this.txtAddTlf.Size = new System.Drawing.Size(202, 22);
            this.txtAddTlf.TabIndex = 6;
            this.txtAddTlf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(27, 39);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(437, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(23, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombre y apellidos del paciente";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Mujer",
            "Hombre"});
            this.cbxSexo.Location = new System.Drawing.Point(317, 106);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(147, 24);
            this.cbxSexo.TabIndex = 2;
            this.cbxSexo.SelectedIndexChanged += new System.EventHandler(this.cbxSexo_SelectedIndexChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(27, 108);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.PromptChar = '-';
            this.txtFechaNacimiento.Size = new System.Drawing.Size(159, 22);
            this.txtFechaNacimiento.TabIndex = 1;
            this.txtFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(313, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sexo";
            // 
            // txtProfecion
            // 
            this.txtProfecion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfecion.Location = new System.Drawing.Point(27, 176);
            this.txtProfecion.MaxLength = 50;
            this.txtProfecion.Name = "txtProfecion";
            this.txtProfecion.Size = new System.Drawing.Size(437, 22);
            this.txtProfecion.TabIndex = 3;
            this.txtProfecion.TextChanged += new System.EventHandler(this.txtProfecion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Profeción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(27, 239);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(437, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "E-Mail";
            // 
            // listViewTelefonos
            // 
            this.listViewTelefonos.BackColor = System.Drawing.Color.White;
            this.listViewTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTelefonos.HideSelection = false;
            this.listViewTelefonos.Location = new System.Drawing.Point(564, 137);
            this.listViewTelefonos.Name = "listViewTelefonos";
            this.listViewTelefonos.Size = new System.Drawing.Size(202, 159);
            this.listViewTelefonos.TabIndex = 30;
            this.listViewTelefonos.UseCompatibleStateImageBehavior = false;
            this.listViewTelefonos.View = System.Windows.Forms.View.List;
            // 
            // btnAddTlf
            // 
            this.btnAddTlf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddTlf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddTlf.FlatAppearance.BorderSize = 0;
            this.btnAddTlf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnAddTlf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.btnAddTlf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTlf.ForeColor = System.Drawing.Color.Black;
            this.btnAddTlf.Location = new System.Drawing.Point(566, 82);
            this.btnAddTlf.Name = "btnAddTlf";
            this.btnAddTlf.Size = new System.Drawing.Size(201, 29);
            this.btnAddTlf.TabIndex = 7;
            this.btnAddTlf.Text = "☎ Añadir teléfono";
            this.btnAddTlf.UseVisualStyleBackColor = false;
            this.btnAddTlf.Click += new System.EventHandler(this.btnAddTlf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(562, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Teléfonos secundarios";
            // 
            // txtTlf
            // 
            this.txtTlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTlf.Location = new System.Drawing.Point(27, 309);
            this.txtTlf.MaxLength = 50;
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(437, 22);
            this.txtTlf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teléfono principal";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.txtNumAsegurado);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtEntidadSanitaria);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cbxGrupoSanguineo);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtEnfermedades);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtAlergias);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos médicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnLimpiar.Location = new System.Drawing.Point(26, 295);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(201, 23);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "🗑️ Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNumAsegurado
            // 
            this.txtNumAsegurado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumAsegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAsegurado.Location = new System.Drawing.Point(429, 296);
            this.txtNumAsegurado.MaxLength = 50;
            this.txtNumAsegurado.Name = "txtNumAsegurado";
            this.txtNumAsegurado.Size = new System.Drawing.Size(340, 22);
            this.txtNumAsegurado.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(426, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "Numero asegurado";
            // 
            // txtEntidadSanitaria
            // 
            this.txtEntidadSanitaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntidadSanitaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidadSanitaria.Location = new System.Drawing.Point(429, 226);
            this.txtEntidadSanitaria.MaxLength = 50;
            this.txtEntidadSanitaria.Name = "txtEntidadSanitaria";
            this.txtEntidadSanitaria.Size = new System.Drawing.Size(340, 22);
            this.txtEntidadSanitaria.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(426, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Entidad sanitaria";
            // 
            // cbxGrupoSanguineo
            // 
            this.cbxGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupoSanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrupoSanguineo.FormattingEnabled = true;
            this.cbxGrupoSanguineo.Items.AddRange(new object[] {
            "0 Negativo",
            "0 Positivo",
            "B Negativo",
            "B Positivo",
            "A Negativo",
            "A Positivo",
            "AB Negativo",
            "AB Positivo"});
            this.cbxGrupoSanguineo.Location = new System.Drawing.Point(26, 226);
            this.cbxGrupoSanguineo.Name = "cbxGrupoSanguineo";
            this.cbxGrupoSanguineo.Size = new System.Drawing.Size(341, 24);
            this.cbxGrupoSanguineo.TabIndex = 10;
            this.cbxGrupoSanguineo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupoSanguineo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(24, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Grupo sanguíneo";
            // 
            // txtEnfermedades
            // 
            this.txtEnfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnfermedades.Location = new System.Drawing.Point(429, 43);
            this.txtEnfermedades.MaxLength = 50;
            this.txtEnfermedades.Multiline = true;
            this.txtEnfermedades.Name = "txtEnfermedades";
            this.txtEnfermedades.Size = new System.Drawing.Size(340, 132);
            this.txtEnfermedades.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(426, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Enfermedades";
            // 
            // txtAlergias
            // 
            this.txtAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlergias.Location = new System.Drawing.Point(27, 43);
            this.txtAlergias.MaxLength = 50;
            this.txtAlergias.Multiline = true;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(340, 132);
            this.txtAlergias.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(23, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Alergias";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(463, 407);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(201, 23);
            this.btnAñadir.TabIndex = 30;
            this.btnAñadir.Text = "✓ Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(201, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "✘ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CrearPacienteOtrosDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.tabControl1);
            this.Name = "CrearPacienteOtrosDatos";
            this.Text = "CrearPacienteOtrosDatos";
            this.Load += new System.EventHandler(this.CrearPacienteOtrosDatos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox txtAddTlf;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProfecion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTelefonos;
        private System.Windows.Forms.Button btnAddTlf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNumAsegurado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEntidadSanitaria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxGrupoSanguineo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEnfermedades;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnCancelar;
    }
}