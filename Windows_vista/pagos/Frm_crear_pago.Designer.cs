namespace Windows_vista.pagos
{
    partial class Frm_crear_pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_crear_pago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_concepto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_estudiantes = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_valor_concepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorEstudiante = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConcepto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorValor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 63);
            this.panel1.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 67;
            this.label1.Text = "Registro de pago";
            // 
            // combo_concepto
            // 
            this.combo_concepto.BackColor = System.Drawing.SystemColors.Window;
            this.combo_concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_concepto.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_concepto.FormattingEnabled = true;
            this.combo_concepto.Location = new System.Drawing.Point(42, 196);
            this.combo_concepto.Name = "combo_concepto";
            this.combo_concepto.Size = new System.Drawing.Size(601, 28);
            this.combo_concepto.TabIndex = 92;
            this.combo_concepto.SelectedIndexChanged += new System.EventHandler(this.combo_concepto_SelectedIndexChanged);
            this.combo_concepto.Validating += new System.ComponentModel.CancelEventHandler(this.combo_concepto_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Estudiante";
            // 
            // combo_estudiantes
            // 
            this.combo_estudiantes.BackColor = System.Drawing.SystemColors.Window;
            this.combo_estudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_estudiantes.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_estudiantes.FormattingEnabled = true;
            this.combo_estudiantes.Location = new System.Drawing.Point(42, 126);
            this.combo_estudiantes.Name = "combo_estudiantes";
            this.combo_estudiantes.Size = new System.Drawing.Size(601, 28);
            this.combo_estudiantes.TabIndex = 90;
            this.combo_estudiantes.Validating += new System.ComponentModel.CancelEventHandler(this.combo_estudiantes_Validating);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(268, 449);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 94;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(42, 324);
            this.Txt_descripcion.MaxLength = 300;
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(601, 111);
            this.Txt_descripcion.TabIndex = 88;
            this.Txt_descripcion.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_descripcion_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 96;
            this.label12.Text = "Descripción (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Concepto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Los campos marcados con (*) son requeridos";
            // 
            // Txt_valor_concepto
            // 
            this.Txt_valor_concepto.Enabled = false;
            this.Txt_valor_concepto.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_valor_concepto.Location = new System.Drawing.Point(42, 261);
            this.Txt_valor_concepto.MaxLength = 300;
            this.Txt_valor_concepto.Name = "Txt_valor_concepto";
            this.Txt_valor_concepto.Size = new System.Drawing.Size(601, 27);
            this.Txt_valor_concepto.TabIndex = 98;
            this.Txt_valor_concepto.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_valor_concepto_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Valor concepto";
            // 
            // errorEstudiante
            // 
            this.errorEstudiante.BlinkRate = 0;
            this.errorEstudiante.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorEstudiante.ContainerControl = this;
            // 
            // errorConcepto
            // 
            this.errorConcepto.BlinkRate = 0;
            this.errorConcepto.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorConcepto.ContainerControl = this;
            // 
            // errorValor
            // 
            this.errorValor.BlinkRate = 0;
            this.errorValor.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorValor.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.BlinkRate = 0;
            this.errorDescripcion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDescripcion.ContainerControl = this;
            // 
            // Frm_crear_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_valor_concepto);
            this.Controls.Add(this.combo_concepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_estudiantes);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.Txt_descripcion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_crear_pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_crear_pago_FormClosing);
            this.Load += new System.EventHandler(this.Frm_crear_pago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_concepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_estudiantes;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_valor_concepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorEstudiante;
        private System.Windows.Forms.ErrorProvider errorConcepto;
        private System.Windows.Forms.ErrorProvider errorValor;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
    }
}