namespace TutorizacionBaqueRodriguezPOE
{
    partial class frmMain 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnInfo = new FontAwesome.Sharp.IconButton();
            this.ibtnGitHub = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listadoAlumnos = new System.Windows.Forms.ListView();
            this.Cedula = new System.Windows.Forms.ColumnHeader();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Apellido = new System.Windows.Forms.ColumnHeader();
            this.Carrera = new System.Windows.Forms.ColumnHeader();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listTittle = new System.Windows.Forms.Label();
            this.ibtnListarAgregados = new FontAwesome.Sharp.IconButton();
            this.ibtnDelete = new FontAwesome.Sharp.IconButton();
            this.ibtnListarEliminados = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnAdd = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.ibtnInfo);
            this.panel2.Controls.Add(this.ibtnGitHub);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(784, 50);
            this.panel2.TabIndex = 0;
            // 
            // ibtnInfo
            // 
            this.ibtnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ibtnInfo.FlatAppearance.BorderSize = 0;
            this.ibtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnInfo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.ibtnInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInfo.IconSize = 27;
            this.ibtnInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnInfo.Location = new System.Drawing.Point(688, 8);
            this.ibtnInfo.Name = "ibtnInfo";
            this.ibtnInfo.Size = new System.Drawing.Size(41, 34);
            this.ibtnInfo.TabIndex = 12;
            this.ibtnInfo.UseVisualStyleBackColor = false;
            this.ibtnInfo.Click += new System.EventHandler(this.ibtnInfo_Click);
            // 
            // ibtnGitHub
            // 
            this.ibtnGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ibtnGitHub.FlatAppearance.BorderSize = 0;
            this.ibtnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGitHub.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.ibtnGitHub.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGitHub.IconSize = 27;
            this.ibtnGitHub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnGitHub.Location = new System.Drawing.Point(735, 8);
            this.ibtnGitHub.Name = "ibtnGitHub";
            this.ibtnGitHub.Size = new System.Drawing.Size(41, 34);
            this.ibtnGitHub.TabIndex = 11;
            this.ibtnGitHub.UseVisualStyleBackColor = false;
            this.ibtnGitHub.Click += new System.EventHandler(this.ibtnGitHub_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 52);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 409);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(784, 409);
            this.panel5.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.groupBox2.Location = new System.Drawing.Point(15, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.groupBox2.Size = new System.Drawing.Size(754, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTADO";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listadoAlumnos);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 48);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(734, 157);
            this.panel7.TabIndex = 14;
            // 
            // listadoAlumnos
            // 
            this.listadoAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.listadoAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cedula,
            this.Nombre,
            this.Apellido,
            this.Carrera});
            this.listadoAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.listadoAlumnos.Location = new System.Drawing.Point(0, 0);
            this.listadoAlumnos.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.listadoAlumnos.Name = "listadoAlumnos";
            this.listadoAlumnos.Size = new System.Drawing.Size(734, 157);
            this.listadoAlumnos.TabIndex = 12;
            this.listadoAlumnos.UseCompatibleStateImageBehavior = false;
            this.listadoAlumnos.View = System.Windows.Forms.View.Details;
            // 
            // Cedula
            // 
            this.Cedula.Text = "Cedula";
            this.Cedula.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 120;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 120;
            // 
            // Carrera
            // 
            this.Carrera.Text = "Carrera";
            this.Carrera.Width = 120;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listTittle);
            this.panel6.Controls.Add(this.ibtnListarAgregados);
            this.panel6.Controls.Add(this.ibtnDelete);
            this.panel6.Controls.Add(this.ibtnListarEliminados);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 18);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel6.Size = new System.Drawing.Size(734, 30);
            this.panel6.TabIndex = 13;
            // 
            // listTittle
            // 
            this.listTittle.AutoSize = true;
            this.listTittle.Location = new System.Drawing.Point(3, 6);
            this.listTittle.Name = "listTittle";
            this.listTittle.Size = new System.Drawing.Size(236, 17);
            this.listTittle.TabIndex = 12;
            this.listTittle.Text = "LISTA DE ESTUDIANTES REGISTRADOS";
            // 
            // ibtnListarAgregados
            // 
            this.ibtnListarAgregados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnListarAgregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ibtnListarAgregados.FlatAppearance.BorderSize = 0;
            this.ibtnListarAgregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnListarAgregados.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnListarAgregados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnListarAgregados.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.ibtnListarAgregados.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnListarAgregados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnListarAgregados.IconSize = 20;
            this.ibtnListarAgregados.Location = new System.Drawing.Point(650, 0);
            this.ibtnListarAgregados.Name = "ibtnListarAgregados";
            this.ibtnListarAgregados.Size = new System.Drawing.Size(24, 24);
            this.ibtnListarAgregados.TabIndex = 11;
            this.ibtnListarAgregados.UseVisualStyleBackColor = false;
            this.ibtnListarAgregados.Click += new System.EventHandler(this.ibtnListar_Click);
            // 
            // ibtnDelete
            // 
            this.ibtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ibtnDelete.FlatAppearance.BorderSize = 0;
            this.ibtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDelete.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDelete.IconSize = 20;
            this.ibtnDelete.Location = new System.Drawing.Point(710, 0);
            this.ibtnDelete.Name = "ibtnDelete";
            this.ibtnDelete.Size = new System.Drawing.Size(24, 24);
            this.ibtnDelete.TabIndex = 9;
            this.ibtnDelete.UseVisualStyleBackColor = false;
            this.ibtnDelete.Click += new System.EventHandler(this.ibtnPalLobby_Click);
            // 
            // ibtnListarEliminados
            // 
            this.ibtnListarEliminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnListarEliminados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ibtnListarEliminados.FlatAppearance.BorderSize = 0;
            this.ibtnListarEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnListarEliminados.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnListarEliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnListarEliminados.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.ibtnListarEliminados.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ibtnListarEliminados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnListarEliminados.IconSize = 20;
            this.ibtnListarEliminados.Location = new System.Drawing.Point(680, 0);
            this.ibtnListarEliminados.Name = "ibtnListarEliminados";
            this.ibtnListarEliminados.Size = new System.Drawing.Size(24, 24);
            this.ibtnListarEliminados.TabIndex = 10;
            this.ibtnListarEliminados.UseVisualStyleBackColor = false;
            this.ibtnListarEliminados.Click += new System.EventHandler(this.ibtnListarLobby_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.ibtnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.AutoSize = true;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Controls.Add(this.tbNombre);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.tbCedula);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.tbCarrera);
            this.panel8.Controls.Add(this.tbApellido);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(10, 16);
            this.panel8.MaximumSize = new System.Drawing.Size(900, 90);
            this.panel8.Name = "panel8";
            this.panel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel8.Size = new System.Drawing.Size(734, 90);
            this.panel8.TabIndex = 11;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNombre.ForeColor = System.Drawing.Color.White;
            this.tbNombre.Location = new System.Drawing.Point(370, 51);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PlaceholderText = "Jane";
            this.tbNombre.Size = new System.Drawing.Size(176, 18);
            this.tbNombre.TabIndex = 4;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNombre.WordWrap = false;
            this.tbNombre.TextChanged += new System.EventHandler(this.CamposRellenados_TextChanged);
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "CARRERA:";
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tbCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCedula.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbCedula.ForeColor = System.Drawing.Color.White;
            this.tbCedula.Location = new System.Drawing.Point(6, 51);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.PlaceholderText = "0123456789";
            this.tbCedula.Size = new System.Drawing.Size(176, 18);
            this.tbCedula.TabIndex = 1;
            this.tbCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCedula.WordWrap = false;
            this.tbCedula.TextChanged += new System.EventHandler(this.CamposRellenados_TextChanged);
            this.tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "CEDULA:";
            // 
            // tbCarrera
            // 
            this.tbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tbCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCarrera.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbCarrera.ForeColor = System.Drawing.Color.White;
            this.tbCarrera.Location = new System.Drawing.Point(188, 51);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.PlaceholderText = "Derecho";
            this.tbCarrera.Size = new System.Drawing.Size(176, 18);
            this.tbCarrera.TabIndex = 1;
            this.tbCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCarrera.WordWrap = false;
            this.tbCarrera.TextChanged += new System.EventHandler(this.CamposRellenados_TextChanged);
            this.tbCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCarrera_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.tbApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellido.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbApellido.ForeColor = System.Drawing.Color.White;
            this.tbApellido.Location = new System.Drawing.Point(552, 51);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.PlaceholderText = "Doe";
            this.tbApellido.Size = new System.Drawing.Size(176, 18);
            this.tbApellido.TabIndex = 5;
            this.tbApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbApellido.WordWrap = false;
            this.tbApellido.TextChanged += new System.EventHandler(this.CamposRellenados_TextChanged);
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "APELLIDO:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOMBRE:";
            // 
            // ibtnAdd
            // 
            this.ibtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.ibtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtnAdd.Cursor = System.Windows.Forms.Cursors.No;
            this.ibtnAdd.Enabled = false;
            this.ibtnAdd.FlatAppearance.BorderSize = 0;
            this.ibtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnAdd.ForeColor = System.Drawing.Color.Black;
            this.ibtnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ibtnAdd.IconColor = System.Drawing.Color.Black;
            this.ibtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdd.IconSize = 25;
            this.ibtnAdd.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ibtnAdd.Location = new System.Drawing.Point(10, 110);
            this.ibtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnAdd.Name = "ibtnAdd";
            this.ibtnAdd.Size = new System.Drawing.Size(734, 28);
            this.ibtnAdd.TabIndex = 8;
            this.ibtnAdd.Text = "Añadir";
            this.ibtnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ibtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAdd.UseVisualStyleBackColor = false;
            this.ibtnAdd.Click += new System.EventHandler(this.ibtnAdd_Click);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private TextBox tbCarrera;
        private TextBox tbCedula;
        private FontAwesome.Sharp.IconButton ibtnAdd;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton ibtnListarEliminados;
        private FontAwesome.Sharp.IconButton ibtnDelete;
        private FontAwesome.Sharp.IconButton ibtnListarAgregados;
        private ListView listadoAlumnos;
        private Panel panel6;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton ibtnGitHub;
        private Panel panel8;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton ibtnInfo;
        private ColumnHeader Cedula;
        private ColumnHeader Nombre;
        private ColumnHeader Apellido;
        private ColumnHeader Carrera;
        private Label listTittle;
    }
}