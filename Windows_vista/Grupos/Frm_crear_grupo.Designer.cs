namespace Windows_vista
{
    partial class Frm_crear_grupo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_crear_grupo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_docente = new System.Windows.Forms.ComboBox();
            this.Combo_grado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Combo_estado_grupo = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Txt_nombre_grupo = new System.Windows.Forms.TextBox();
            this.Txt_descripciongrupo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDocente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstadoGrupo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGrado = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.combo_docente);
            this.panel1.Controls.Add(this.Combo_grado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Combo_estado_grupo);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.Txt_nombre_grupo);
            this.panel1.Controls.Add(this.Txt_descripciongrupo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 448);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Docente (*)";
            // 
            // combo_docente
            // 
            this.combo_docente.BackColor = System.Drawing.SystemColors.Window;
            this.combo_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_docente.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_docente.FormattingEnabled = true;
            this.combo_docente.Location = new System.Drawing.Point(353, 128);
            this.combo_docente.Name = "combo_docente";
            this.combo_docente.Size = new System.Drawing.Size(298, 28);
            this.combo_docente.TabIndex = 2;
            this.combo_docente.Validating += new System.ComponentModel.CancelEventHandler(this.combo_docente_Validating);
            // 
            // Combo_grado
            // 
            this.Combo_grado.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_grado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_grado.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_grado.FormattingEnabled = true;
            this.Combo_grado.Location = new System.Drawing.Point(353, 330);
            this.Combo_grado.Name = "Combo_grado";
            this.Combo_grado.Size = new System.Drawing.Size(298, 28);
            this.Combo_grado.TabIndex = 5;
            this.Combo_grado.Validating += new System.ComponentModel.CancelEventHandler(this.Combo_grado_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Grado (*)";
            // 
            // Combo_estado_grupo
            // 
            this.Combo_estado_grupo.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_estado_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_estado_grupo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_estado_grupo.FormattingEnabled = true;
            this.Combo_estado_grupo.Location = new System.Drawing.Point(40, 330);
            this.Combo_estado_grupo.Name = "Combo_estado_grupo";
            this.Combo_estado_grupo.Size = new System.Drawing.Size(276, 28);
            this.Combo_estado_grupo.TabIndex = 4;
            this.Combo_estado_grupo.Validating += new System.ComponentModel.CancelEventHandler(this.Combo_estado_grupo_Validating);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(266, 394);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Txt_nombre_grupo
            // 
            this.Txt_nombre_grupo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre_grupo.Location = new System.Drawing.Point(41, 128);
            this.Txt_nombre_grupo.MaxLength = 30;
            this.Txt_nombre_grupo.Name = "Txt_nombre_grupo";
            this.Txt_nombre_grupo.Size = new System.Drawing.Size(275, 27);
            this.Txt_nombre_grupo.TabIndex = 1;
            this.Txt_nombre_grupo.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_nombre_grupo_Validating);
            // 
            // Txt_descripciongrupo
            // 
            this.Txt_descripciongrupo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripciongrupo.Location = new System.Drawing.Point(41, 205);
            this.Txt_descripciongrupo.MaxLength = 300;
            this.Txt_descripciongrupo.Multiline = true;
            this.Txt_descripciongrupo.Name = "Txt_descripciongrupo";
            this.Txt_descripciongrupo.Size = new System.Drawing.Size(610, 89);
            this.Txt_descripciongrupo.TabIndex = 3;
            this.Txt_descripciongrupo.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_descripciongrupo_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Nombre de grupo (*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Descripción de grupo (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado de grupo (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Los campos marcados con (*) son requeridos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 48);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar grupo";
            // 
            // errorNombre
            // 
            this.errorNombre.BlinkRate = 0;
            this.errorNombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorNombre.ContainerControl = this;
            // 
            // errorDocente
            // 
            this.errorDocente.BlinkRate = 0;
            this.errorDocente.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDocente.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.BlinkRate = 0;
            this.errorDescripcion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDescripcion.ContainerControl = this;
            // 
            // errorEstadoGrupo
            // 
            this.errorEstadoGrupo.BlinkRate = 0;
            this.errorEstadoGrupo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorEstadoGrupo.ContainerControl = this;
            // 
            // errorGrado
            // 
            this.errorGrado.BlinkRate = 0;
            this.errorGrado.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorGrado.ContainerControl = this;
            // 
            // Frm_crear_grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(699, 467);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_crear_grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar grupo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_crear_grupo_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Combo_estado_grupo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox Txt_nombre_grupo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_descripciongrupo;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ComboBox Combo_grado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_docente;
        private System.Windows.Forms.ErrorProvider errorDocente;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.ErrorProvider errorEstadoGrupo;
        private System.Windows.Forms.ErrorProvider errorGrado;
    }
}