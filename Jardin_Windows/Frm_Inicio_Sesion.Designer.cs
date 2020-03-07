namespace Jardin
{
    partial class Frm_Inicio_Sesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inicio_Sesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelError = new System.Windows.Forms.Label();
            this.viewPass = new System.Windows.Forms.PictureBox();
            this.Panel_bienvenida = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Txt_clave = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPass)).BeginInit();
            this.Panel_bienvenida.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PanelError);
            this.panel1.Controls.Add(this.viewPass);
            this.panel1.Controls.Add(this.Panel_bienvenida);
            this.panel1.Controls.Add(this.Btn_Ingresar);
            this.panel1.Controls.Add(this.Txt_clave);
            this.panel1.Controls.Add(this.Txt_usuario);
            this.panel1.Controls.Add(this.textUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(408, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 404);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PanelError
            // 
            this.PanelError.AutoSize = true;
            this.PanelError.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelError.ForeColor = System.Drawing.Color.Red;
            this.PanelError.Location = new System.Drawing.Point(102, 313);
            this.PanelError.Name = "PanelError";
            this.PanelError.Size = new System.Drawing.Size(0, 15);
            this.PanelError.TabIndex = 7;
            // 
            // viewPass
            // 
            this.viewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPass.Location = new System.Drawing.Point(310, 187);
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(29, 31);
            this.viewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewPass.TabIndex = 6;
            this.viewPass.TabStop = false;
            this.viewPass.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Panel_bienvenida
            // 
            this.Panel_bienvenida.BackColor = System.Drawing.Color.Teal;
            this.Panel_bienvenida.Controls.Add(this.label1);
            this.Panel_bienvenida.Location = new System.Drawing.Point(23, 14);
            this.Panel_bienvenida.Name = "Panel_bienvenida";
            this.Panel_bienvenida.Size = new System.Drawing.Size(349, 47);
            this.Panel_bienvenida.TabIndex = 5;
            this.Panel_bienvenida.Visible = false;
            this.Panel_bienvenida.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "¡ Bienvenido al sistema !";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.Teal;
            this.Btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ingresar.FlatAppearance.BorderSize = 0;
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ingresar.Location = new System.Drawing.Point(122, 235);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(153, 39);
            this.Btn_Ingresar.TabIndex = 4;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Txt_clave
            // 
            this.Txt_clave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_clave.Location = new System.Drawing.Point(55, 187);
            this.Txt_clave.Name = "Txt_clave";
            this.Txt_clave.PasswordChar = '*';
            this.Txt_clave.Size = new System.Drawing.Size(284, 31);
            this.Txt_clave.TabIndex = 3;
            this.Txt_clave.TextChanged += new System.EventHandler(this.textClave_TextChanged);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.Location = new System.Drawing.Point(55, 109);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(284, 31);
            this.Txt_usuario.TabIndex = 2;
            // 
            // textUser
            // 
            this.textUser.AutoSize = true;
            this.textUser.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(147, 76);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(83, 30);
            this.textUser.TabIndex = 1;
            this.textUser.Text = "Usuario";
            this.textUser.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 404);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frm_Inicio_Sesion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPass)).EndInit();
            this.Panel_bienvenida.ResumeLayout(false);
            this.Panel_bienvenida.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Label textUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.TextBox Txt_clave;
        private System.Windows.Forms.PictureBox viewPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_bienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PanelError;
    }
}

