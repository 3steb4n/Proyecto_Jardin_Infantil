﻿namespace Windows_vista
{
    partial class Frm_menu_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu_admin));
            this.Btn_reportes = new System.Windows.Forms.Button();
            this.BtnGrupos = new System.Windows.Forms.Button();
            this.Btn_materias = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_rol = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe_nombre_usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            Btn_usuarios = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_usuarios
            // 
            Btn_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            Btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            Btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_usuarios.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_usuarios.Image = global::Windows_vista.Properties.Resources.grupo__1_;
            Btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Btn_usuarios.Location = new System.Drawing.Point(0, 137);
            Btn_usuarios.Name = "Btn_usuarios";
            Btn_usuarios.Size = new System.Drawing.Size(238, 45);
            Btn_usuarios.TabIndex = 1;
            Btn_usuarios.Text = "Usuarios";
            Btn_usuarios.UseVisualStyleBackColor = false;
            Btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click);
            // 
            // Btn_reportes
            // 
            this.Btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reportes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportes.Image = global::Windows_vista.Properties.Resources.tablero__1_;
            this.Btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reportes.Location = new System.Drawing.Point(0, 92);
            this.Btn_reportes.Name = "Btn_reportes";
            this.Btn_reportes.Size = new System.Drawing.Size(238, 45);
            this.Btn_reportes.TabIndex = 4;
            this.Btn_reportes.Text = "Reportes";
            this.Btn_reportes.UseVisualStyleBackColor = false;
            this.Btn_reportes.Click += new System.EventHandler(this.Btn_reportes_Click);
            // 
            // BtnGrupos
            // 
            this.BtnGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.BtnGrupos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrupos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrupos.Image = global::Windows_vista.Properties.Resources.grupo__1_;
            this.BtnGrupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGrupos.Location = new System.Drawing.Point(0, 0);
            this.BtnGrupos.Name = "BtnGrupos";
            this.BtnGrupos.Size = new System.Drawing.Size(238, 47);
            this.BtnGrupos.TabIndex = 6;
            this.BtnGrupos.Text = "Grupos";
            this.BtnGrupos.UseVisualStyleBackColor = false;
            this.BtnGrupos.Click += new System.EventHandler(this.BtnGrupos_Click);
            // 
            // Btn_materias
            // 
            this.Btn_materias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.Btn_materias.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_materias.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_materias.Image = global::Windows_vista.Properties.Resources.cuaderno__1_;
            this.Btn_materias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_materias.Location = new System.Drawing.Point(0, 47);
            this.Btn_materias.Name = "Btn_materias";
            this.Btn_materias.Size = new System.Drawing.Size(238, 45);
            this.Btn_materias.TabIndex = 2;
            this.Btn_materias.Text = "Materias";
            this.Btn_materias.UseVisualStyleBackColor = false;
            this.Btn_materias.Click += new System.EventHandler(this.Btn_materias_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_rol);
            this.panel3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(1069, 628);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 35);
            this.panel3.TabIndex = 8;
            // 
            // label_rol
            // 
            this.label_rol.AutoSize = true;
            this.label_rol.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_rol.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rol.Location = new System.Drawing.Point(49, 0);
            this.label_rol.Name = "label_rol";
            this.label_rol.Size = new System.Drawing.Size(122, 20);
            this.label_rol.TabIndex = 4;
            this.label_rol.Text = "input temporal";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labe_nombre_usuario);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(848, 583);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 38);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labe_nombre_usuario
            // 
            this.labe_nombre_usuario.AutoSize = true;
            this.labe_nombre_usuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.labe_nombre_usuario.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_nombre_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labe_nombre_usuario.Location = new System.Drawing.Point(250, 0);
            this.labe_nombre_usuario.Name = "labe_nombre_usuario";
            this.labe_nombre_usuario.Size = new System.Drawing.Size(142, 25);
            this.labe_nombre_usuario.TabIndex = 3;
            this.labe_nombre_usuario.Text = "imput temporal";
            this.labe_nombre_usuario.Click += new System.EventHandler(this.labe_nombre_usuario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 135);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 673);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(Btn_usuarios);
            this.panel5.Controls.Add(this.Btn_reportes);
            this.panel5.Controls.Add(this.Btn_materias);
            this.panel5.Controls.Add(this.BtnGrupos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 532);
            this.panel5.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Windows_vista.Properties.Resources.flecha;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cerrar sesión";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Frm_menu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_menu_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu administrador";
            this.Load += new System.EventHandler(this.Frm_menu_admin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_reportes;
        private System.Windows.Forms.Button Btn_materias;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_rol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labe_nombre_usuario;
        private System.Windows.Forms.Button BtnGrupos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
    }
}