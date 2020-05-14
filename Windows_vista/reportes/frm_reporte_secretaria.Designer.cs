namespace Windows_vista.reportes
{
    partial class frm_reporte_secretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reporte_secretaria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Volver = new System.Windows.Forms.Button();
            this.Listar_EstudiantevsGrupo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe_nombre_usuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_rol = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Controls.Add(this.Volver);
            this.panel1.Controls.Add(this.Listar_EstudiantevsGrupo);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 526);
            this.panel1.TabIndex = 0;
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Volver.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.Volver.Location = new System.Drawing.Point(0, 282);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(238, 47);
            this.Volver.TabIndex = 1;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Listar_EstudiantevsGrupo
            // 
            this.Listar_EstudiantevsGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Listar_EstudiantevsGrupo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Listar_EstudiantevsGrupo.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.Listar_EstudiantevsGrupo.Image = global::Windows_vista.Properties.Resources.ListarE;
            this.Listar_EstudiantevsGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Listar_EstudiantevsGrupo.Location = new System.Drawing.Point(0, 0);
            this.Listar_EstudiantevsGrupo.Name = "Listar_EstudiantevsGrupo";
            this.Listar_EstudiantevsGrupo.Size = new System.Drawing.Size(238, 47);
            this.Listar_EstudiantevsGrupo.TabIndex = 0;
            this.Listar_EstudiantevsGrupo.Text = "Listar Estudiante Por Grupo";
            this.Listar_EstudiantevsGrupo.UseVisualStyleBackColor = false;
            this.Listar_EstudiantevsGrupo.Click += new System.EventHandler(this.Listar_EstudiantevsGrupo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labe_nombre_usuario);
            this.panel2.Location = new System.Drawing.Point(1011, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 33);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labe_nombre_usuario
            // 
            this.labe_nombre_usuario.AutoSize = true;
            this.labe_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_nombre_usuario.Location = new System.Drawing.Point(84, 0);
            this.labe_nombre_usuario.Name = "labe_nombre_usuario";
            this.labe_nombre_usuario.Size = new System.Drawing.Size(157, 26);
            this.labe_nombre_usuario.TabIndex = 0;
            this.labe_nombre_usuario.Text = "imput temporal";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_rol);
            this.panel3.Location = new System.Drawing.Point(1077, 595);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 26);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label_rol
            // 
            this.label_rol.AutoSize = true;
            this.label_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rol.Location = new System.Drawing.Point(77, 0);
            this.label_rol.Name = "label_rol";
            this.label_rol.Size = new System.Drawing.Size(98, 17);
            this.label_rol.TabIndex = 0;
            this.label_rol.Text = "input temporal";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 157);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = global::Windows_vista.Properties.Resources.LOGO_EVOLUTION_KIDS_01___copia;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_reporte_secretaria
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
            this.Name = "frm_reporte_secretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_reporte_secretaria";
            this.Load += new System.EventHandler(this.frm_reporte_secretaria_Load);
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
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Listar_EstudiantevsGrupo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labe_nombre_usuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_rol;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}