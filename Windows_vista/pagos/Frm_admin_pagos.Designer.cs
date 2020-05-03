namespace Windows_vista.pagos
{
    partial class Frm_admin_pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_admin_pagos));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_pagos = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_estudiantes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_busquedaCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_pagos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_concepto_pago = new System.Windows.Forms.ComboBox();
            this.Btn_detalle = new System.Windows.Forms.Button();
            this.id_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_abonado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_secretaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_concepto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_concepto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_acudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Btn_usuarios = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagos)).BeginInit();
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 673);
            this.panel4.TabIndex = 13;
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
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1052, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 30);
            this.button2.TabIndex = 62;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_busquedaCedula
            // 
            this.Txt_busquedaCedula.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_busquedaCedula.Location = new System.Drawing.Point(386, 75);
            this.Txt_busquedaCedula.Name = "Txt_busquedaCedula";
            this.Txt_busquedaCedula.Size = new System.Drawing.Size(266, 22);
            this.Txt_busquedaCedula.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Num. documento :";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(1090, 629);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 57;
            this.btn_guardar.Text = "Registrar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_pagos
            // 
            this.dgv_pagos.AllowUserToAddRows = false;
            this.dgv_pagos.AllowUserToDeleteRows = false;
            this.dgv_pagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_pagos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_pagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pagos.ColumnHeadersHeight = 30;
            this.dgv_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pago,
            this.Estado_pago,
            this.Valor_monto,
            this.Valor_abonado,
            this.Descripcion_pago,
            this.id_secretaria,
            this.Usuario_creacion,
            this.Fecha_registro,
            this.id_concepto_pago,
            this.nombre_concepto_pago,
            this.Id_matricula,
            this.Numero_Matricula,
            this.id_estudiante,
            this.Documento_estudiante,
            this.Nombre_estudiante,
            this.nombre_acudiente,
            this.Correo_electronico,
            this.Telefono,
            this.Celular,
            this.Direccion});
            this.dgv_pagos.EnableHeadersVisualStyles = false;
            this.dgv_pagos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_pagos.Location = new System.Drawing.Point(277, 106);
            this.dgv_pagos.Name = "dgv_pagos";
            this.dgv_pagos.ReadOnly = true;
            this.dgv_pagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pagos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_pagos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pagos.Size = new System.Drawing.Size(937, 505);
            this.dgv_pagos.TabIndex = 56;
            this.dgv_pagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pagos_CellContentClick);
            this.dgv_pagos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_pagos_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Gestión de pagos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Concepto pago:";
            // 
            // combo_concepto_pago
            // 
            this.combo_concepto_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_concepto_pago.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_concepto_pago.FormattingEnabled = true;
            this.combo_concepto_pago.Location = new System.Drawing.Point(766, 70);
            this.combo_concepto_pago.Name = "combo_concepto_pago";
            this.combo_concepto_pago.Size = new System.Drawing.Size(271, 28);
            this.combo_concepto_pago.TabIndex = 63;
            // 
            // Btn_detalle
            // 
            this.Btn_detalle.BackColor = System.Drawing.Color.Teal;
            this.Btn_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_detalle.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_detalle.ForeColor = System.Drawing.Color.White;
            this.Btn_detalle.Location = new System.Drawing.Point(959, 629);
            this.Btn_detalle.Name = "Btn_detalle";
            this.Btn_detalle.Size = new System.Drawing.Size(120, 32);
            this.Btn_detalle.TabIndex = 65;
            this.Btn_detalle.Text = "Ver detalle";
            this.Btn_detalle.UseVisualStyleBackColor = false;
            this.Btn_detalle.Click += new System.EventHandler(this.Btn_detalle_Click);
            // 
            // id_pago
            // 
            this.id_pago.HeaderText = "# de pago";
            this.id_pago.Name = "id_pago";
            this.id_pago.ReadOnly = true;
            // 
            // Estado_pago
            // 
            this.Estado_pago.HeaderText = "Estado";
            this.Estado_pago.Name = "Estado_pago";
            this.Estado_pago.ReadOnly = true;
            // 
            // Valor_monto
            // 
            this.Valor_monto.HeaderText = "Valor monto";
            this.Valor_monto.Name = "Valor_monto";
            this.Valor_monto.ReadOnly = true;
            // 
            // Valor_abonado
            // 
            this.Valor_abonado.HeaderText = "Valor abonado";
            this.Valor_abonado.Name = "Valor_abonado";
            this.Valor_abonado.ReadOnly = true;
            // 
            // Descripcion_pago
            // 
            this.Descripcion_pago.HeaderText = "Descripción";
            this.Descripcion_pago.Name = "Descripcion_pago";
            this.Descripcion_pago.ReadOnly = true;
            // 
            // id_secretaria
            // 
            this.id_secretaria.HeaderText = "id_secretaria";
            this.id_secretaria.Name = "id_secretaria";
            this.id_secretaria.ReadOnly = true;
            this.id_secretaria.Visible = false;
            // 
            // Usuario_creacion
            // 
            this.Usuario_creacion.HeaderText = "Secretaria";
            this.Usuario_creacion.Name = "Usuario_creacion";
            this.Usuario_creacion.ReadOnly = true;
            // 
            // Fecha_registro
            // 
            this.Fecha_registro.HeaderText = "Fecha de registro";
            this.Fecha_registro.Name = "Fecha_registro";
            this.Fecha_registro.ReadOnly = true;
            // 
            // id_concepto_pago
            // 
            this.id_concepto_pago.HeaderText = "id_concepto_pago";
            this.id_concepto_pago.Name = "id_concepto_pago";
            this.id_concepto_pago.ReadOnly = true;
            this.id_concepto_pago.Visible = false;
            // 
            // nombre_concepto_pago
            // 
            this.nombre_concepto_pago.HeaderText = "Concepto pago";
            this.nombre_concepto_pago.Name = "nombre_concepto_pago";
            this.nombre_concepto_pago.ReadOnly = true;
            // 
            // Id_matricula
            // 
            this.Id_matricula.HeaderText = "Id_matricula";
            this.Id_matricula.Name = "Id_matricula";
            this.Id_matricula.ReadOnly = true;
            this.Id_matricula.Visible = false;
            // 
            // Numero_Matricula
            // 
            this.Numero_Matricula.HeaderText = "Numero de la Matricula";
            this.Numero_Matricula.Name = "Numero_Matricula";
            this.Numero_Matricula.ReadOnly = true;
            // 
            // id_estudiante
            // 
            this.id_estudiante.HeaderText = "id_estudiante";
            this.id_estudiante.Name = "id_estudiante";
            this.id_estudiante.ReadOnly = true;
            this.id_estudiante.Visible = false;
            // 
            // Documento_estudiante
            // 
            this.Documento_estudiante.HeaderText = "Documento estudiante";
            this.Documento_estudiante.Name = "Documento_estudiante";
            this.Documento_estudiante.ReadOnly = true;
            // 
            // Nombre_estudiante
            // 
            this.Nombre_estudiante.HeaderText = "Nombre estudiante";
            this.Nombre_estudiante.Name = "Nombre_estudiante";
            this.Nombre_estudiante.ReadOnly = true;
            // 
            // nombre_acudiente
            // 
            this.nombre_acudiente.HeaderText = "Nombre acudiente";
            this.nombre_acudiente.Name = "nombre_acudiente";
            this.nombre_acudiente.ReadOnly = true;
            // 
            // Correo_electronico
            // 
            this.Correo_electronico.HeaderText = "Correo Electrónico";
            this.Correo_electronico.Name = "Correo_electronico";
            this.Correo_electronico.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Frm_admin_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.Btn_detalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_concepto_pago);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_busquedaCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_pagos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_admin_pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_admin_pagos_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_estudiantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_pagos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_busquedaCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_pagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_concepto_pago;
        private System.Windows.Forms.Button Btn_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_abonado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_secretaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_concepto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_concepto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_acudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}