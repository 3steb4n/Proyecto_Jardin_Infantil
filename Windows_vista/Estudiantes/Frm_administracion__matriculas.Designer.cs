namespace Windows_vista.estudiantes
{
    partial class Frm_administracion__matriculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_busquedaCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_grupo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_estudiantes = new System.Windows.Forms.DataGridView();
            this.Id_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeromatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anoreguistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadomatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 52);
            this.panel2.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gestión de estudiantes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(651, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 30);
            this.button2.TabIndex = 55;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Txt_busquedaCedula
            // 
            this.Txt_busquedaCedula.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_busquedaCedula.Location = new System.Drawing.Point(126, 95);
            this.Txt_busquedaCedula.Name = "Txt_busquedaCedula";
            this.Txt_busquedaCedula.Size = new System.Drawing.Size(266, 22);
            this.Txt_busquedaCedula.TabIndex = 54;
            this.Txt_busquedaCedula.TextChanged += new System.EventHandler(this.Txt_busquedaCedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Num. documento :";
            // 
            // combo_grupo
            // 
            this.combo_grupo.FormattingEnabled = true;
            this.combo_grupo.Location = new System.Drawing.Point(514, 97);
            this.combo_grupo.Name = "combo_grupo";
            this.combo_grupo.Size = new System.Drawing.Size(121, 21);
            this.combo_grupo.TabIndex = 56;
            this.combo_grupo.SelectedIndexChanged += new System.EventHandler(this.combo_grupo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(466, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Grupo :";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_estudiantes.ColumnHeadersHeight = 30;
            this.dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_estudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_matricula,
            this.Numeromatricula,
            this.Anoreguistro,
            this.Estadomatricula,
            this.Id_estudiante,
            this.NombreEstudiante,
            this.DocumentoEstudiante,
            this.IdGrupo,
            this.NombreGrupo});
            this.dgv_estudiantes.EnableHeadersVisualStyles = false;
            this.dgv_estudiantes.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_estudiantes.Location = new System.Drawing.Point(32, 124);
            this.dgv_estudiantes.Name = "dgv_estudiantes";
            this.dgv_estudiantes.ReadOnly = true;
            this.dgv_estudiantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_estudiantes.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estudiantes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_estudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estudiantes.Size = new System.Drawing.Size(646, 394);
            this.dgv_estudiantes.TabIndex = 59;
            // 
            // Id_matricula
            // 
            this.Id_matricula.HeaderText = "";
            this.Id_matricula.Name = "Id_matricula";
            this.Id_matricula.ReadOnly = true;
            this.Id_matricula.Visible = false;
            this.Id_matricula.Width = 19;
            // 
            // Numeromatricula
            // 
            this.Numeromatricula.HeaderText = "Numero de la Matricula";
            this.Numeromatricula.Name = "Numeromatricula";
            this.Numeromatricula.ReadOnly = true;
            this.Numeromatricula.Width = 141;
            // 
            // Anoreguistro
            // 
            this.Anoreguistro.HeaderText = "Año reguistrado";
            this.Anoreguistro.Name = "Anoreguistro";
            this.Anoreguistro.ReadOnly = true;
            this.Anoreguistro.Width = 106;
            // 
            // Estadomatricula
            // 
            this.Estadomatricula.HeaderText = "Estado de la Matricula";
            this.Estadomatricula.Name = "Estadomatricula";
            this.Estadomatricula.ReadOnly = true;
            this.Estadomatricula.Width = 137;
            // 
            // Id_estudiante
            // 
            this.Id_estudiante.HeaderText = "id_estudiante";
            this.Id_estudiante.Name = "Id_estudiante";
            this.Id_estudiante.ReadOnly = true;
            this.Id_estudiante.Visible = false;
            this.Id_estudiante.Width = 95;
            // 
            // NombreEstudiante
            // 
            this.NombreEstudiante.HeaderText = "Nombre del Estudiante";
            this.NombreEstudiante.Name = "NombreEstudiante";
            this.NombreEstudiante.ReadOnly = true;
            this.NombreEstudiante.Width = 139;
            // 
            // DocumentoEstudiante
            // 
            this.DocumentoEstudiante.HeaderText = "Documento del Estudiante";
            this.DocumentoEstudiante.Name = "DocumentoEstudiante";
            this.DocumentoEstudiante.ReadOnly = true;
            this.DocumentoEstudiante.Width = 157;
            // 
            // IdGrupo
            // 
            this.IdGrupo.HeaderText = "id grupo";
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            this.IdGrupo.Visible = false;
            this.IdGrupo.Width = 70;
            // 
            // NombreGrupo
            // 
            this.NombreGrupo.HeaderText = "Nombre del Grupo";
            this.NombreGrupo.Name = "NombreGrupo";
            this.NombreGrupo.ReadOnly = true;
            this.NombreGrupo.Width = 118;
            // 
            // Frm_administracion__matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 530);
            this.Controls.Add(this.dgv_estudiantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_grupo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_busquedaCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_administracion__matriculas";
            this.Text = "Frm_administracion__matriculas";
            this.Load += new System.EventHandler(this.Frm_administracion__matriculas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_busquedaCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_grupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_estudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeromatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anoreguistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadomatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreGrupo;
    }
}