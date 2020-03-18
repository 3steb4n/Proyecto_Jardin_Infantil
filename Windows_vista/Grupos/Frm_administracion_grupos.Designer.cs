namespace Windows_vista
{
    partial class Frm_administracion_grupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_administracion_grupos));
            this.button7 = new System.Windows.Forms.Button();
            this.Txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_grupos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_materias = new System.Windows.Forms.Button();
            this.BtnGrupos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos_docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Btn_usuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grupos)).BeginInit();
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.BackgroundImage = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(617, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 30);
            this.button7.TabIndex = 40;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Txt_busqueda
            // 
            this.Txt_busqueda.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_busqueda.Location = new System.Drawing.Point(345, 69);
            this.Txt_busqueda.Name = "Txt_busqueda";
            this.Txt_busqueda.Size = new System.Drawing.Size(266, 22);
            this.Txt_busqueda.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cod. grupo :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(813, 603);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 32);
            this.button6.TabIndex = 37;
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
            this.button5.Location = new System.Drawing.Point(953, 603);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 36;
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
            this.btn_guardar.Location = new System.Drawing.Point(1091, 603);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 35;
            this.btn_guardar.Text = "Registrar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_grupos
            // 
            this.dgv_grupos.AllowUserToAddRows = false;
            this.dgv_grupos.AllowUserToDeleteRows = false;
            this.dgv_grupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_grupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_grupos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_grupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_grupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_grupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_grupos.ColumnHeadersHeight = 30;
            this.dgv_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grupo,
            this.Nombre_grupo,
            this.Descripcion_Grupo,
            this.Estado_grupo,
            this.Nombre_grado,
            this.id_grado,
            this.id_docente,
            this.nombres_docente,
            this.apellidos_docente});
            this.dgv_grupos.EnableHeadersVisualStyles = false;
            this.dgv_grupos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_grupos.Location = new System.Drawing.Point(269, 120);
            this.dgv_grupos.Name = "dgv_grupos";
            this.dgv_grupos.ReadOnly = true;
            this.dgv_grupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_grupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_grupos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_grupos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_grupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_grupos.Size = new System.Drawing.Size(942, 477);
            this.dgv_grupos.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gestión de grupos";
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
            this.panel4.TabIndex = 41;
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
            this.panel5.Size = new System.Drawing.Size(238, 529);
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
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
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
            this.BtnGrupos.Click += new System.EventHandler(this.BtnGrupos_Click);
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
            // id_grupo
            // 
            this.id_grupo.HeaderText = "";
            this.id_grupo.Name = "id_grupo";
            this.id_grupo.ReadOnly = true;
            this.id_grupo.Visible = false;
            // 
            // Nombre_grupo
            // 
            this.Nombre_grupo.HeaderText = "Grupo";
            this.Nombre_grupo.Name = "Nombre_grupo";
            this.Nombre_grupo.ReadOnly = true;
            // 
            // Descripcion_Grupo
            // 
            this.Descripcion_Grupo.HeaderText = "Descripción";
            this.Descripcion_Grupo.Name = "Descripcion_Grupo";
            this.Descripcion_Grupo.ReadOnly = true;
            // 
            // Estado_grupo
            // 
            this.Estado_grupo.HeaderText = "Estado grupo";
            this.Estado_grupo.Name = "Estado_grupo";
            this.Estado_grupo.ReadOnly = true;
            // 
            // Nombre_grado
            // 
            this.Nombre_grado.HeaderText = "Grado";
            this.Nombre_grado.Name = "Nombre_grado";
            this.Nombre_grado.ReadOnly = true;
            // 
            // id_grado
            // 
            this.id_grado.HeaderText = "id_grado";
            this.id_grado.Name = "id_grado";
            this.id_grado.ReadOnly = true;
            this.id_grado.Visible = false;
            // 
            // id_docente
            // 
            this.id_docente.HeaderText = "id_docente";
            this.id_docente.Name = "id_docente";
            this.id_docente.ReadOnly = true;
            this.id_docente.Visible = false;
            // 
            // nombres_docente
            // 
            this.nombres_docente.HeaderText = "Nombre docente";
            this.nombres_docente.Name = "nombres_docente";
            this.nombres_docente.ReadOnly = true;
            // 
            // apellidos_docente
            // 
            this.apellidos_docente.HeaderText = "Apellidos docente";
            this.apellidos_docente.Name = "apellidos_docente";
            this.apellidos_docente.ReadOnly = true;
            // 
            // Frm_administracion_grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Txt_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_grupos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_administracion_grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grupos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox Txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_grupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_materias;
        private System.Windows.Forms.Button BtnGrupos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres_docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos_docente;
    }
}