namespace Windows_vista
{
    partial class Frm_administracion_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_administracion_usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_busquedaCedula = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_materias = new System.Windows.Forms.Button();
            this.BtnGrupos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Btn_usuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
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
            Btn_usuarios.Location = new System.Drawing.Point(0, 135);
            Btn_usuarios.Name = "Btn_usuarios";
            Btn_usuarios.Size = new System.Drawing.Size(238, 45);
            Btn_usuarios.TabIndex = 1;
            Btn_usuarios.Text = "Usuarios";
            Btn_usuarios.UseVisualStyleBackColor = false;
            Btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de usuarios";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_usuarios.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usuarios.ColumnHeadersHeight = 30;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Documento,
            this.Tipo_Documento,
            this.Nombres,
            this.Apellidos,
            this.Dirección,
            this.Celular,
            this.Telefono,
            this.Correo_Electronico,
            this.Estado_usuario,
            this.Estado_clave,
            this.Tipo_usuario});
            this.dgv_usuarios.EnableHeadersVisualStyles = false;
            this.dgv_usuarios.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_usuarios.Location = new System.Drawing.Point(261, 94);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_usuarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_usuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(931, 504);
            this.dgv_usuarios.TabIndex = 25;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.HeaderText = "Tipo documento";
            this.Tipo_Documento.Name = "Tipo_Documento";
            this.Tipo_Documento.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.HeaderText = "Correo electrónico";
            this.Correo_Electronico.Name = "Correo_Electronico";
            this.Correo_Electronico.ReadOnly = true;
            // 
            // Estado_usuario
            // 
            this.Estado_usuario.HeaderText = "Estado usuario";
            this.Estado_usuario.Name = "Estado_usuario";
            this.Estado_usuario.ReadOnly = true;
            // 
            // Estado_clave
            // 
            this.Estado_clave.HeaderText = "Estado clave";
            this.Estado_clave.Name = "Estado_clave";
            this.Estado_clave.ReadOnly = true;
            // 
            // Tipo_usuario
            // 
            this.Tipo_usuario.HeaderText = "Tipo usuario";
            this.Tipo_usuario.Name = "Tipo_usuario";
            this.Tipo_usuario.ReadOnly = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(1072, 616);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Registrar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(934, 616);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 27;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(793, 616);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 32);
            this.button6.TabIndex = 28;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Num. documento :";
            // 
            // Txt_busquedaCedula
            // 
            this.Txt_busquedaCedula.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_busquedaCedula.Location = new System.Drawing.Point(373, 62);
            this.Txt_busquedaCedula.Name = "Txt_busquedaCedula";
            this.Txt_busquedaCedula.Size = new System.Drawing.Size(266, 22);
            this.Txt_busquedaCedula.TabIndex = 30;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button7.BackgroundImage = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(655, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 30);
            this.button7.TabIndex = 31;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 671);
            this.panel4.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Btn_cerrar);
            this.panel5.Controls.Add(Btn_usuarios);
            this.panel5.Controls.Add(this.Btn_reportes);
            this.panel5.Controls.Add(this.Btn_materias);
            this.panel5.Controls.Add(this.BtnGrupos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 518);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(0, 180);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(238, 44);
            this.Btn_cerrar.TabIndex = 5;
            this.Btn_cerrar.Text = "Cerrar sesión";
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click_1);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = global::Windows_vista.Properties.Resources.tablero__1_;
            this.Btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reportes.Location = new System.Drawing.Point(0, 90);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(238, 45);
            this.Btn_reportes.TabIndex = 4;
            this.Btn_reportes.Text = "Reportes";
            this.Btn_reportes.UseVisualStyleBackColor = false;
            // 
            // Btn_materias
            // 
            this.Btn_materias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_materias.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_materias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_materias.Image = global::Windows_vista.Properties.Resources.cuaderno__1_;
            this.Btn_materias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_materias.Location = new System.Drawing.Point(0, 45);
            this.Btn_materias.Name = "Btn_materias";
            this.Btn_materias.Size = new System.Drawing.Size(238, 45);
            this.Btn_materias.TabIndex = 2;
            this.Btn_materias.Text = "Materias";
            this.Btn_materias.UseVisualStyleBackColor = false;
            this.Btn_materias.Click += new System.EventHandler(this.Btn_materias_Click);
            // 
            // BtnGrupos
            // 
            this.BtnGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.BtnGrupos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrupos.Image = global::Windows_vista.Properties.Resources.grupo__1_;
            this.BtnGrupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGrupos.Location = new System.Drawing.Point(0, 0);
            this.BtnGrupos.Name = "BtnGrupos";
            this.BtnGrupos.Size = new System.Drawing.Size(238, 45);
            this.BtnGrupos.TabIndex = 6;
            this.BtnGrupos.Text = "Grupos";
            this.BtnGrupos.UseVisualStyleBackColor = false;
            this.BtnGrupos.Click += new System.EventHandler(this.button1_Click_1);
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
            // Frm_administracion_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1211, 671);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Txt_busquedaCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_administracion_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_busquedaCedula;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_materias;
        private System.Windows.Forms.Button BtnGrupos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_usuario;
    }
}