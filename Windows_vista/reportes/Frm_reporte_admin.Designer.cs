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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_reporte_admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btnReporteXML = new System.Windows.Forms.Button();
            this.btnEstudiantesGrupos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe_nombre_usuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_rol = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btn_Volver);
            this.panel1.Controls.Add(this.btnReporteXML);
            this.panel1.Controls.Add(this.btnEstudiantesGrupos);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 456);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(-3, 282);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(199, 38);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporteXML
            // 
            this.btnReporteXML.Location = new System.Drawing.Point(0, 152);
            this.btnReporteXML.Name = "btnReporteXML";
            this.btnReporteXML.Size = new System.Drawing.Size(199, 39);
            this.btnReporteXML.TabIndex = 1;
            this.btnReporteXML.Text = "Reporte XML";
            this.btnReporteXML.UseVisualStyleBackColor = true;
            // 
            // btnEstudiantesGrupos
            // 
            this.btnEstudiantesGrupos.Location = new System.Drawing.Point(0, 111);
            this.btnEstudiantesGrupos.Name = "btnEstudiantesGrupos";
            this.btnEstudiantesGrupos.Size = new System.Drawing.Size(199, 47);
            this.btnEstudiantesGrupos.TabIndex = 0;
            this.btnEstudiantesGrupos.Text = "Lista Estudiantes Por Grupos";
            this.btnEstudiantesGrupos.UseVisualStyleBackColor = true;
            this.btnEstudiantesGrupos.Click += new System.EventHandler(this.btnEstudiantesGrupos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labe_nombre_usuario);
            this.panel2.Location = new System.Drawing.Point(530, 372);
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
            this.panel3.Location = new System.Drawing.Point(616, 411);
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
            // Frm_reporte_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteXML;
        private System.Windows.Forms.Button btnEstudiantesGrupos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labe_nombre_usuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_rol;
        private System.Windows.Forms.Button btn_Volver;
    }
}