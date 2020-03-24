namespace Windows_vista.reportes
{
    partial class Frm_Listado_Estudiantes_vs_Grupos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ListarEstudiantePorGrupo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_grupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Acudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Acudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular_Acudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta_Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarEstudiantePorGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(41, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado De Estudiantes Por Grupos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_ListarEstudiantePorGrupo
            // 
            this.dgv_ListarEstudiantePorGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListarEstudiantePorGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_estudiante,
            this.Documento_estudiante,
            this.Tipo_Documento,
            this.Nombres,
            this.Apellidos,
            this.Fecha_De_Nacimiento,
            this.Nombre_Acudiente,
            this.Direccion,
            this.Genero,
            this.Telefono_Acudiente,
            this.Celular_Acudiente,
            this.Correo_Electronico,
            this.Observaciones,
            this.Estado_Estudiante,
            this.Grupo,
            this.Ruta_Foto});
            this.dgv_ListarEstudiantePorGrupo.Location = new System.Drawing.Point(39, 108);
            this.dgv_ListarEstudiantePorGrupo.Name = "dgv_ListarEstudiantePorGrupo";
            this.dgv_ListarEstudiantePorGrupo.Size = new System.Drawing.Size(1020, 275);
            this.dgv_ListarEstudiantePorGrupo.TabIndex = 1;
            this.dgv_ListarEstudiantePorGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exportar Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_grupo
            // 
            this.combo_grupo.FormattingEnabled = true;
            this.combo_grupo.Location = new System.Drawing.Point(542, 84);
            this.combo_grupo.Name = "combo_grupo";
            this.combo_grupo.Size = new System.Drawing.Size(112, 21);
            this.combo_grupo.TabIndex = 3;
            this.combo_grupo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grupo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(41, 35);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Volver";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button2.Location = new System.Drawing.Point(660, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 30);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_estudiante
            // 
            this.id_estudiante.HeaderText = "";
            this.id_estudiante.Name = "id_estudiante";
            this.id_estudiante.Visible = false;
            this.id_estudiante.Width = 19;
            // 
            // Documento_estudiante
            // 
            this.Documento_estudiante.HeaderText = "Documento Identificacion";
            this.Documento_estudiante.Name = "Documento_estudiante";
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.HeaderText = "Tipo Documento";
            this.Tipo_Documento.Name = "Tipo_Documento";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Fecha_De_Nacimiento
            // 
            this.Fecha_De_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_De_Nacimiento.Name = "Fecha_De_Nacimiento";
            // 
            // Nombre_Acudiente
            // 
            this.Nombre_Acudiente.HeaderText = "Nombre Acudiente";
            this.Nombre_Acudiente.Name = "Nombre_Acudiente";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // Telefono_Acudiente
            // 
            this.Telefono_Acudiente.HeaderText = "Telefono acudiente";
            this.Telefono_Acudiente.Name = "Telefono_Acudiente";
            this.Telefono_Acudiente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Celular_Acudiente
            // 
            this.Celular_Acudiente.HeaderText = "Celular Acudiente";
            this.Celular_Acudiente.Name = "Celular_Acudiente";
            // 
            // Correo_Electronico
            // 
            this.Correo_Electronico.HeaderText = "Correo Electronico";
            this.Correo_Electronico.Name = "Correo_Electronico";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            // 
            // Estado_Estudiante
            // 
            this.Estado_Estudiante.HeaderText = "Estado Estudiante";
            this.Estado_Estudiante.Name = "Estado_Estudiante";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            // 
            // Ruta_Foto
            // 
            this.Ruta_Foto.HeaderText = "Ruta Foto";
            this.Ruta_Foto.Name = "Ruta_Foto";
            // 
            // Frm_Listado_Estudiantes_vs_Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_grupo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_ListarEstudiantePorGrupo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Listado_Estudiantes_vs_Grupos";
            this.Text = "Frm_Listado_Estudiantes_vs_Grupos";
            this.Load += new System.EventHandler(this.Frm_Listado_Estudiantes_vs_Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarEstudiantePorGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ListarEstudiantePorGrupo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Acudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Acudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular_Acudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta_Foto;
    }
}