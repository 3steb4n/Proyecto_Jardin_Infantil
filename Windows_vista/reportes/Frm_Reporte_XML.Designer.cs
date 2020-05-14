namespace Windows_vista.reportes
{
    partial class Frm_Reporte_XML
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
            this.btnReportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Grado = new System.Windows.Forms.DataGridView();
            this.IdGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Area = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IdArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btnReportes.Image = global::Windows_vista.Properties.Resources.Atras;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(321, 468);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(131, 38);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Volver";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.75F);
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(362, 39);
            this.label1.TabIndex = 58;
            this.label1.Text = "Reporte en XML de Grado y Area";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_Grado
            // 
            this.dgv_Grado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrado,
            this.NombreGrado,
            this.Descripcion,
            this.EstadoGrado});
            this.dgv_Grado.Location = new System.Drawing.Point(54, 135);
            this.dgv_Grado.Name = "dgv_Grado";
            this.dgv_Grado.Size = new System.Drawing.Size(345, 213);
            this.dgv_Grado.TabIndex = 59;
            // 
            // IdGrado
            // 
            this.IdGrado.Frozen = true;
            this.IdGrado.HeaderText = "";
            this.IdGrado.Name = "IdGrado";
            this.IdGrado.Visible = false;
            // 
            // NombreGrado
            // 
            this.NombreGrado.HeaderText = "Nombre Grado";
            this.NombreGrado.Name = "NombreGrado";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion Grado";
            this.Descripcion.Name = "Descripcion";
            // 
            // EstadoGrado
            // 
            this.EstadoGrado.HeaderText = "Estado Grado";
            this.EstadoGrado.Name = "EstadoGrado";
            // 
            // dgv_Area
            // 
            this.dgv_Area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Area.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArea,
            this.NombreArea});
            this.dgv_Area.Location = new System.Drawing.Point(514, 135);
            this.dgv_Area.Name = "dgv_Area";
            this.dgv_Area.Size = new System.Drawing.Size(146, 213);
            this.dgv_Area.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.button1.Image = global::Windows_vista.Properties.Resources.gol;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(127, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 61;
            this.button1.Text = "Exportar Grado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.button2.Image = global::Windows_vista.Properties.Resources.gol;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(497, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 38);
            this.button2.TabIndex = 62;
            this.button2.Text = "Exportar Area";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdArea
            // 
            this.IdArea.Frozen = true;
            this.IdArea.HeaderText = "";
            this.IdArea.Name = "IdArea";
            this.IdArea.Visible = false;
            // 
            // NombreArea
            // 
            this.NombreArea.HeaderText = "Nombre Area";
            this.NombreArea.Name = "NombreArea";
            // 
            // Frm_Reporte_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Area);
            this.Controls.Add(this.dgv_Grado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReportes);
            this.Name = "Frm_Reporte_XML";
            this.Text = "Frm_Reporte_XML";
            this.Load += new System.EventHandler(this.Frm_Reporte_XML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Grado;
        private System.Windows.Forms.DataGridView dgv_Area;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArea;
    }
}