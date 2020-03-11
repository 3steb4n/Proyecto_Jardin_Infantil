namespace Windows_vista.Materia
{
    partial class Frm_admin_materia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_admin_materia));
            this.Txt_busquedaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_materias = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas_Maximas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.Btn_logros = new System.Windows.Forms.Button();
            this.Btn_materias = new System.Windows.Forms.Button();
            this.Btn_usuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materias)).BeginInit();
            this.PanelMenuLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_busquedaNombre
            // 
            this.Txt_busquedaNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_busquedaNombre.Location = new System.Drawing.Point(306, 93);
            this.Txt_busquedaNombre.Name = "Txt_busquedaNombre";
            this.Txt_busquedaNombre.Size = new System.Drawing.Size(266, 22);
            this.Txt_busquedaNombre.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Materia:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(760, 563);
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
            this.button5.Location = new System.Drawing.Point(886, 563);
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
            this.btn_guardar.Location = new System.Drawing.Point(1012, 563);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 44;
            this.btn_guardar.Text = "Registrar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dgv_materias
            // 
            this.dgv_materias.AllowUserToAddRows = false;
            this.dgv_materias.AllowUserToDeleteRows = false;
            this.dgv_materias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_materias.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_materias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_materias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_materias.ColumnHeadersHeight = 30;
            this.dgv_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.Nombre_materia,
            this.Descripcion_materia,
            this.EstadoMateria,
            this.Horas_Maximas,
            this.idArea,
            this.NombreArea,
            this.idGrado,
            this.NombreGrado});
            this.dgv_materias.EnableHeadersVisualStyles = false;
            this.dgv_materias.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_materias.Location = new System.Drawing.Point(253, 131);
            this.dgv_materias.Name = "dgv_materias";
            this.dgv_materias.ReadOnly = true;
            this.dgv_materias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_materias.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_materias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_materias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_materias.Size = new System.Drawing.Size(881, 426);
            this.dgv_materias.TabIndex = 43;
            this.dgv_materias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_materias_CellContentClick);
            // 
            // idMateria
            // 
            this.idMateria.HeaderText = "";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            // 
            // Nombre_materia
            // 
            this.Nombre_materia.HeaderText = "Materia";
            this.Nombre_materia.Name = "Nombre_materia";
            this.Nombre_materia.ReadOnly = true;
            // 
            // Descripcion_materia
            // 
            this.Descripcion_materia.HeaderText = "Descripción";
            this.Descripcion_materia.Name = "Descripcion_materia";
            this.Descripcion_materia.ReadOnly = true;
            // 
            // EstadoMateria
            // 
            this.EstadoMateria.HeaderText = "Estado";
            this.EstadoMateria.Name = "EstadoMateria";
            this.EstadoMateria.ReadOnly = true;
            // 
            // Horas_Maximas
            // 
            this.Horas_Maximas.HeaderText = "Horas maximas";
            this.Horas_Maximas.Name = "Horas_Maximas";
            this.Horas_Maximas.ReadOnly = true;
            // 
            // idArea
            // 
            this.idArea.HeaderText = "idArea";
            this.idArea.Name = "idArea";
            this.idArea.ReadOnly = true;
            // 
            // NombreArea
            // 
            this.NombreArea.HeaderText = "Area";
            this.NombreArea.Name = "NombreArea";
            this.NombreArea.ReadOnly = true;
            // 
            // idGrado
            // 
            this.idGrado.HeaderText = "idGrado";
            this.idGrado.Name = "idGrado";
            this.idGrado.ReadOnly = true;
            // 
            // NombreGrado
            // 
            this.NombreGrado.HeaderText = "Grado";
            this.NombreGrado.Name = "NombreGrado";
            this.NombreGrado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "Gestión de materias";
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.BackColor = System.Drawing.Color.Teal;
            this.PanelMenuLateral.Controls.Add(this.button2);
            this.PanelMenuLateral.Controls.Add(this.Btn_cerrar);
            this.PanelMenuLateral.Controls.Add(this.button1);
            this.PanelMenuLateral.Controls.Add(this.Btn_reportes);
            this.PanelMenuLateral.Controls.Add(this.Btn_logros);
            this.PanelMenuLateral.Controls.Add(this.Btn_materias);
            this.PanelMenuLateral.Controls.Add(this.Btn_usuarios);
            this.PanelMenuLateral.Controls.Add(this.panel1);
            this.PanelMenuLateral.Location = new System.Drawing.Point(-8, -9);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(236, 704);
            this.PanelMenuLateral.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Grupos";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_cerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cerrar.Location = new System.Drawing.Point(0, 329);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(236, 45);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.Text = "Cerrar sesión";
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mi Perfil";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reportes.Location = new System.Drawing.Point(0, 284);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(250, 45);
            this.Btn_reportes.TabIndex = 4;
            this.Btn_reportes.Text = "Reportes";
            this.Btn_reportes.UseVisualStyleBackColor = false;
            // 
            // Btn_logros
            // 
            this.Btn_logros.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_logros.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_logros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_logros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_logros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_logros.Location = new System.Drawing.Point(0, 239);
            this.Btn_logros.Name = "Btn_logros";
            this.Btn_logros.Size = new System.Drawing.Size(236, 45);
            this.Btn_logros.TabIndex = 3;
            this.Btn_logros.Text = "Logros";
            this.Btn_logros.UseVisualStyleBackColor = false;
            // 
            // Btn_materias
            // 
            this.Btn_materias.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_materias.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_materias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_materias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_materias.Location = new System.Drawing.Point(0, 194);
            this.Btn_materias.Name = "Btn_materias";
            this.Btn_materias.Size = new System.Drawing.Size(236, 45);
            this.Btn_materias.TabIndex = 2;
            this.Btn_materias.Text = "Materias";
            this.Btn_materias.UseVisualStyleBackColor = false;
            // 
            // Btn_usuarios
            // 
            this.Btn_usuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_usuarios.Location = new System.Drawing.Point(0, 149);
            this.Btn_usuarios.Name = "Btn_usuarios";
            this.Btn_usuarios.Size = new System.Drawing.Size(236, 45);
            this.Btn_usuarios.TabIndex = 1;
            this.Btn_usuarios.Text = "Usuarios";
            this.Btn_usuarios.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 149);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = global::Windows_vista.Properties.Resources.LOGO_EVOLUTION_KIDS_01___copia;
            this.pictureBox1.Location = new System.Drawing.Point(38, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.BackgroundImage = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(588, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 30);
            this.button7.TabIndex = 50;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // Frm_admin_materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 613);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Txt_busquedaNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_materias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_admin_materia";
            this.Text = "Administración de materias";
            this.Load += new System.EventHandler(this.Frm_admin_materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materias)).EndInit();
            this.PanelMenuLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_busquedaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_materias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_logros;
        private System.Windows.Forms.Button Btn_materias;
        private System.Windows.Forms.Button Btn_usuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas_Maximas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreGrado;
        private System.Windows.Forms.Button button7;
    }
}