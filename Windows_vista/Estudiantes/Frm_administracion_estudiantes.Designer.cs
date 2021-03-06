﻿namespace Windows_vista
{
    partial class Frm_administracion_estudiantes
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
            System.Windows.Forms.Button Btn_usuarios;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_administracion_estudiantes));
            this.Txt_busquedaCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_estudiantes = new System.Windows.Forms.DataGridView();
            this.id_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_acudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta_foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_pagos = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_estudiantes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Matriculas = new System.Windows.Forms.Button();
            Btn_usuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_usuarios
            // 
            Btn_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            Btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            Btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_usuarios.Image = global::Windows_vista.Properties.Resources.grupo__1_;
            Btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Btn_usuarios.Location = new System.Drawing.Point(0, 90);
            Btn_usuarios.Name = "Btn_usuarios";
            Btn_usuarios.Size = new System.Drawing.Size(238, 45);
            Btn_usuarios.TabIndex = 1;
            Btn_usuarios.Text = "Docentes";
            Btn_usuarios.UseVisualStyleBackColor = false;
            Btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click);
            // 
            // Txt_busquedaCedula
            // 
            this.Txt_busquedaCedula.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_busquedaCedula.Location = new System.Drawing.Point(409, 73);
            this.Txt_busquedaCedula.Name = "Txt_busquedaCedula";
            this.Txt_busquedaCedula.Size = new System.Drawing.Size(266, 22);
            this.Txt_busquedaCedula.TabIndex = 48;
            this.Txt_busquedaCedula.TextChanged += new System.EventHandler(this.Txt_busquedaCedula_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Num. documento :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(809, 615);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 32);
            this.button6.TabIndex = 46;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(935, 615);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 45;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(1061, 615);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 44;
            this.btn_guardar.Text = "Registrar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_estudiantes
            // 
            this.dgv_estudiantes.AllowUserToAddRows = false;
            this.dgv_estudiantes.AllowUserToDeleteRows = false;
            this.dgv_estudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_estudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_estudiantes.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_estudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_estudiantes.ColumnHeadersHeight = 30;
            this.dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_estudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_estudiante,
            this.Documento_estudiante,
            this.Tipo_documento,
            this.Nombres,
            this.Apellidos,
            this.Fecha_nacimiento,
            this.Nombre_acudiente,
            this.Direccion,
            this.Genero,
            this.Telefono,
            this.Celular,
            this.Correo_electronico,
            this.Observaciones,
            this.Estado,
            this.ruta_foto,
            this.NombreGrupo,
            this.IdGrupo});
            this.dgv_estudiantes.EnableHeadersVisualStyles = false;
            this.dgv_estudiantes.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_estudiantes.Location = new System.Drawing.Point(298, 104);
            this.dgv_estudiantes.Name = "dgv_estudiantes";
            this.dgv_estudiantes.ReadOnly = true;
            this.dgv_estudiantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_estudiantes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estudiantes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_estudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estudiantes.Size = new System.Drawing.Size(881, 505);
            this.dgv_estudiantes.TabIndex = 43;
            this.dgv_estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estudiantes_CellContentClick);
            // 
            // id_estudiante
            // 
            this.id_estudiante.HeaderText = "";
            this.id_estudiante.Name = "id_estudiante";
            this.id_estudiante.ReadOnly = true;
            this.id_estudiante.Visible = false;
            this.id_estudiante.Width = 19;
            // 
            // Documento_estudiante
            // 
            this.Documento_estudiante.HeaderText = "Documento identificación";
            this.Documento_estudiante.Name = "Documento_estudiante";
            this.Documento_estudiante.ReadOnly = true;
            this.Documento_estudiante.Width = 152;
            // 
            // Tipo_documento
            // 
            this.Tipo_documento.HeaderText = "Tipo de documento";
            this.Tipo_documento.Name = "Tipo_documento";
            this.Tipo_documento.ReadOnly = true;
            this.Tipo_documento.Width = 124;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 74;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            this.Fecha_nacimiento.Width = 116;
            // 
            // Nombre_acudiente
            // 
            this.Nombre_acudiente.HeaderText = "Nombre acudiente";
            this.Nombre_acudiente.Name = "Nombre_acudiente";
            this.Nombre_acudiente.ReadOnly = true;
            this.Nombre_acudiente.Width = 119;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccción";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 83;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 67;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono Acudiente";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular acudiente";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 114;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.HeaderText = "Correo Electrónico";
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            this.Correo_electronico.Width = 119;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 103;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado_Estudiante";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 121;
            // 
            // ruta_foto
            // 
            this.ruta_foto.HeaderText = "ruta_foto";
            this.ruta_foto.Name = "ruta_foto";
            this.ruta_foto.ReadOnly = true;
            this.ruta_foto.Width = 74;
            // 
            // NombreGrupo
            // 
            this.NombreGrupo.HeaderText = "Grupo";
            this.NombreGrupo.Name = "NombreGrupo";
            this.NombreGrupo.ReadOnly = true;
            this.NombreGrupo.Visible = false;
            this.NombreGrupo.Width = 61;
            // 
            // IdGrupo
            // 
            this.IdGrupo.HeaderText = "";
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            this.IdGrupo.Visible = false;
            this.IdGrupo.Width = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gestión de estudiantes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(712, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 30);
            this.button2.TabIndex = 52;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 673);
            this.panel4.TabIndex = 55;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Btn_cerrar);
            this.panel5.Controls.Add(this.Btn_pagos);
            this.panel5.Controls.Add(Btn_usuarios);
            this.panel5.Controls.Add(this.Btn_reportes);
            this.panel5.Controls.Add(this.Btn_estudiantes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 532);
            this.panel5.TabIndex = 12;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_cerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cerrar.Image = global::Windows_vista.Properties.Resources.flecha;
            this.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cerrar.Location = new System.Drawing.Point(0, 179);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(238, 44);
            this.Btn_cerrar.TabIndex = 9;
            this.Btn_cerrar.Text = "Cerrar sesión";
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // Btn_pagos
            // 
            this.Btn_pagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_pagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pagos.Image = global::Windows_vista.Properties.Resources.pagar;
            this.Btn_pagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_pagos.Location = new System.Drawing.Point(0, 135);
            this.Btn_pagos.Name = "Btn_pagos";
            this.Btn_pagos.Size = new System.Drawing.Size(238, 44);
            this.Btn_pagos.TabIndex = 8;
            this.Btn_pagos.Text = "Pagos";
            this.Btn_pagos.UseVisualStyleBackColor = false;
            this.Btn_pagos.Click += new System.EventHandler(this.Btn_pagos_Click);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = global::Windows_vista.Properties.Resources.tablero__1_;
            this.Btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reportes.Location = new System.Drawing.Point(0, 45);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(238, 45);
            this.Btn_reportes.TabIndex = 4;
            this.Btn_reportes.Text = "Reportes";
            this.Btn_reportes.UseVisualStyleBackColor = false;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // Btn_estudiantes
            // 
            this.Btn_estudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_estudiantes.Image = global::Windows_vista.Properties.Resources.equipo__1_;
            this.Btn_estudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_estudiantes.Location = new System.Drawing.Point(0, 0);
            this.Btn_estudiantes.Name = "Btn_estudiantes";
            this.Btn_estudiantes.Size = new System.Drawing.Size(238, 45);
            this.Btn_estudiantes.TabIndex = 7;
            this.Btn_estudiantes.Text = "Estudiantes";
            this.Btn_estudiantes.UseVisualStyleBackColor = false;
            this.Btn_estudiantes.Click += new System.EventHandler(this.Btn_estudiantes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 141);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = global::Windows_vista.Properties.Resources.LOGO_EVOLUTION_KIDS_01___copia;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Matriculas
            // 
            this.Matriculas.BackColor = System.Drawing.Color.Teal;
            this.Matriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Matriculas.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matriculas.ForeColor = System.Drawing.Color.White;
            this.Matriculas.Location = new System.Drawing.Point(683, 615);
            this.Matriculas.Name = "Matriculas";
            this.Matriculas.Size = new System.Drawing.Size(120, 32);
            this.Matriculas.TabIndex = 56;
            this.Matriculas.Text = "Matriculados";
            this.Matriculas.UseVisualStyleBackColor = false;
            this.Matriculas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_administracion_estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.Matriculas);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_busquedaCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_estudiantes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_administracion_estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de estudiantes";
            this.Load += new System.EventHandler(this.Frm_administracion_estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_busquedaCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_estudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_estudiantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_acudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta_foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.Button Matriculas;
    }
}