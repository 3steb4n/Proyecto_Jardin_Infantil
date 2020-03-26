namespace Windows_vista.reportes
{
    partial class Frm_reporte_admin
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
            System.Windows.Forms.Button btnEstudiantesGrupos;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reporte_admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btnReporteXML = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe_nombre_usuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_rol = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnEstudiantesGrupos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btn_Volver);
            this.panel1.Controls.Add(this.btnReporteXML);
            this.panel1.Controls.Add(btnEstudiantesGrupos);
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 526);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.btn_Volver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Volver.Image = global::Windows_vista.Properties.Resources.Atras;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(3, 263);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(238, 47);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporteXML
            // 
            this.btnReporteXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnReporteXML.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteXML.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.btnReporteXML.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReporteXML.Image = global::Windows_vista.Properties.Resources.ListarE;
            this.btnReporteXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteXML.Location = new System.Drawing.Point(0, 47);
            this.btnReporteXML.Name = "btnReporteXML";
            this.btnReporteXML.Size = new System.Drawing.Size(238, 47);
            this.btnReporteXML.TabIndex = 1;
            this.btnReporteXML.Text = "Reporte XML";
            this.btnReporteXML.UseVisualStyleBackColor = false;
            // 
            // btnEstudiantesGrupos
            // 
            btnEstudiantesGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            btnEstudiantesGrupos.Dock = System.Windows.Forms.DockStyle.Top;
            btnEstudiantesGrupos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            btnEstudiantesGrupos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnEstudiantesGrupos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnEstudiantesGrupos.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            btnEstudiantesGrupos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnEstudiantesGrupos.Image = global::Windows_vista.Properties.Resources.ListarE;
            btnEstudiantesGrupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEstudiantesGrupos.Location = new System.Drawing.Point(0, 0);
            btnEstudiantesGrupos.Name = "btnEstudiantesGrupos";
            btnEstudiantesGrupos.Size = new System.Drawing.Size(238, 47);
            btnEstudiantesGrupos.TabIndex = 6;
            btnEstudiantesGrupos.Text = "Lista Estudiantes Por Grupos";
            btnEstudiantesGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEstudiantesGrupos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEstudiantesGrupos.UseVisualStyleBackColor = false;
            btnEstudiantesGrupos.Click += new System.EventHandler(this.btnEstudiantesGrupos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labe_nombre_usuario);
            this.panel2.Location = new System.Drawing.Point(980, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 40);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labe_nombre_usuario
            // 
            this.labe_nombre_usuario.AutoSize = true;
            this.labe_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_nombre_usuario.Location = new System.Drawing.Point(110, 0);
            this.labe_nombre_usuario.Name = "labe_nombre_usuario";
            this.labe_nombre_usuario.Size = new System.Drawing.Size(157, 26);
            this.labe_nombre_usuario.TabIndex = 0;
            this.labe_nombre_usuario.Text = "imput temporal";
            this.labe_nombre_usuario.Click += new System.EventHandler(this.labe_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_rol);
            this.panel3.Location = new System.Drawing.Point(1066, 611);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 27);
            this.panel3.TabIndex = 2;
            // 
            // label_rol
            // 
            this.label_rol.AutoSize = true;
            this.label_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rol.Location = new System.Drawing.Point(83, 0);
            this.label_rol.Name = "label_rol";
            this.label_rol.Size = new System.Drawing.Size(98, 17);
            this.label_rol.TabIndex = 0;
            this.label_rol.Text = "input temporal";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 151);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = global::Windows_vista.Properties.Resources.LOGO_EVOLUTION_KIDS_01___copia;
            this.pictureBox1.Location = new System.Drawing.Point(47, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_reporte_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_reporte_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_reporte_admin";
            this.Load += new System.EventHandler(this.Frm_reporte_admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteXML;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labe_nombre_usuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_rol;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}