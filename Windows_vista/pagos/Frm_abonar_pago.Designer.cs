namespace Windows_vista.pagos
{
    partial class Frm_abonar_pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_abonar_pago));
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_valor_abonar = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_documento_estudiante = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_valor_pago = new System.Windows.Forms.Label();
            this.label_id_pago = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_nombre_estudiante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_concepto_pago = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_nombre_acudiente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_valor_faltante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_valor_total = new System.Windows.Forms.TextBox();
            this.combo_tipo_abono = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.errorTipoAbono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorValorAbonar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipoAbono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValorAbonar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 110;
            this.label3.Text = "Valor abonar";
            // 
            // Txt_valor_abonar
            // 
            this.Txt_valor_abonar.Enabled = false;
            this.Txt_valor_abonar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_valor_abonar.Location = new System.Drawing.Point(239, 324);
            this.Txt_valor_abonar.MaxLength = 9;
            this.Txt_valor_abonar.Name = "Txt_valor_abonar";
            this.Txt_valor_abonar.Size = new System.Drawing.Size(415, 27);
            this.Txt_valor_abonar.TabIndex = 109;
            this.Txt_valor_abonar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_valor_abonar_KeyUp);
            this.Txt_valor_abonar.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_valor_abonar_Validating);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(395, 566);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 106;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label_documento_estudiante);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_valor_pago);
            this.panel1.Controls.Add(this.label_id_pago);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label_nombre_estudiante);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label_concepto_pago);
            this.panel1.Controls.Add(this.label_fecha);
            this.panel1.Controls.Add(this.label_nombre_acudiente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 160);
            this.panel1.TabIndex = 111;
            // 
            // label_documento_estudiante
            // 
            this.label_documento_estudiante.AutoSize = true;
            this.label_documento_estudiante.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_documento_estudiante.ForeColor = System.Drawing.Color.White;
            this.label_documento_estudiante.Location = new System.Drawing.Point(494, 106);
            this.label_documento_estudiante.Name = "label_documento_estudiante";
            this.label_documento_estudiante.Size = new System.Drawing.Size(114, 17);
            this.label_documento_estudiante.TabIndex = 121;
            this.label_documento_estudiante.Text = "nombre acudiente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(317, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 120;
            this.label6.Text = "Documento  estudiante :";
            // 
            // label_valor_pago
            // 
            this.label_valor_pago.AutoSize = true;
            this.label_valor_pago.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor_pago.ForeColor = System.Drawing.Color.White;
            this.label_valor_pago.Location = new System.Drawing.Point(729, 110);
            this.label_valor_pago.Name = "label_valor_pago";
            this.label_valor_pago.Size = new System.Drawing.Size(48, 17);
            this.label_valor_pago.TabIndex = 119;
            this.label_valor_pago.Text = "estado";
            // 
            // label_id_pago
            // 
            this.label_id_pago.AutoSize = true;
            this.label_id_pago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_pago.ForeColor = System.Drawing.Color.White;
            this.label_id_pago.Location = new System.Drawing.Point(212, 20);
            this.label_id_pago.Name = "label_id_pago";
            this.label_id_pago.Size = new System.Drawing.Size(65, 21);
            this.label_id_pago.TabIndex = 84;
            this.label_id_pago.Text = "id_pago";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(662, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 118;
            this.label12.Text = "Valor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 67;
            this.label1.Text = "Detalle de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Concepto de pago :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(662, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Fecha :";
            // 
            // label_nombre_estudiante
            // 
            this.label_nombre_estudiante.AutoSize = true;
            this.label_nombre_estudiante.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_estudiante.ForeColor = System.Drawing.Color.White;
            this.label_nombre_estudiante.Location = new System.Drawing.Point(494, 72);
            this.label_nombre_estudiante.Name = "label_nombre_estudiante";
            this.label_nombre_estudiante.Size = new System.Drawing.Size(114, 17);
            this.label_nombre_estudiante.TabIndex = 81;
            this.label_nombre_estudiante.Text = "nombre acudiente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Nombre acudiente :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(344, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Nombre estudiante :";
            // 
            // label_concepto_pago
            // 
            this.label_concepto_pago.AutoSize = true;
            this.label_concepto_pago.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_concepto_pago.ForeColor = System.Drawing.Color.White;
            this.label_concepto_pago.Location = new System.Drawing.Point(173, 70);
            this.label_concepto_pago.Name = "label_concepto_pago";
            this.label_concepto_pago.Size = new System.Drawing.Size(122, 17);
            this.label_concepto_pago.TabIndex = 74;
            this.label_concepto_pago.Text = "Concepto de pago ";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.White;
            this.label_fecha.Location = new System.Drawing.Point(722, 72);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(39, 17);
            this.label_fecha.TabIndex = 76;
            this.label_fecha.Text = "fecha";
            // 
            // label_nombre_acudiente
            // 
            this.label_nombre_acudiente.AutoSize = true;
            this.label_nombre_acudiente.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_acudiente.ForeColor = System.Drawing.Color.White;
            this.label_nombre_acudiente.Location = new System.Drawing.Point(173, 108);
            this.label_nombre_acudiente.Name = "label_nombre_acudiente";
            this.label_nombre_acudiente.Size = new System.Drawing.Size(114, 17);
            this.label_nombre_acudiente.TabIndex = 75;
            this.label_nombre_acudiente.Text = "nombre acudiente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Valor faltante";
            // 
            // Txt_valor_faltante
            // 
            this.Txt_valor_faltante.Enabled = false;
            this.Txt_valor_faltante.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_valor_faltante.Location = new System.Drawing.Point(239, 406);
            this.Txt_valor_faltante.MaxLength = 300;
            this.Txt_valor_faltante.Name = "Txt_valor_faltante";
            this.Txt_valor_faltante.Size = new System.Drawing.Size(415, 27);
            this.Txt_valor_faltante.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 115;
            this.label7.Text = "Valor Total";
            // 
            // Txt_valor_total
            // 
            this.Txt_valor_total.Enabled = false;
            this.Txt_valor_total.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_valor_total.Location = new System.Drawing.Point(239, 200);
            this.Txt_valor_total.MaxLength = 300;
            this.Txt_valor_total.Name = "Txt_valor_total";
            this.Txt_valor_total.Size = new System.Drawing.Size(415, 27);
            this.Txt_valor_total.TabIndex = 114;
            // 
            // combo_tipo_abono
            // 
            this.combo_tipo_abono.BackColor = System.Drawing.SystemColors.Window;
            this.combo_tipo_abono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_abono.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tipo_abono.FormattingEnabled = true;
            this.combo_tipo_abono.Location = new System.Drawing.Point(239, 258);
            this.combo_tipo_abono.Name = "combo_tipo_abono";
            this.combo_tipo_abono.Size = new System.Drawing.Size(415, 28);
            this.combo_tipo_abono.TabIndex = 116;
            this.combo_tipo_abono.SelectedIndexChanged += new System.EventHandler(this.combo_tipo_abono_SelectedIndexChanged);
            this.combo_tipo_abono.Validating += new System.ComponentModel.CancelEventHandler(this.combo_tipo_abono_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 117;
            this.label8.Text = "Tipo de abono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(236, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Valor minimo de abono 10.000 pesos";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(239, 472);
            this.Txt_descripcion.MaxLength = 300;
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(415, 79);
            this.Txt_descripcion.TabIndex = 118;
            this.Txt_descripcion.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_descripcion_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(235, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 119;
            this.label13.Text = "Descripción";
            // 
            // errorTipoAbono
            // 
            this.errorTipoAbono.BlinkRate = 0;
            this.errorTipoAbono.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTipoAbono.ContainerControl = this;
            // 
            // errorValorAbonar
            // 
            this.errorValorAbonar.BlinkRate = 0;
            this.errorValorAbonar.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorValorAbonar.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.BlinkRate = 0;
            this.errorDescripcion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDescripcion.ContainerControl = this;
            // 
            // Frm_abonar_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 612);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_descripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo_tipo_abono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_valor_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_valor_faltante);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_valor_abonar);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_abonar_pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonar pago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipoAbono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValorAbonar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_valor_abonar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_id_pago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_nombre_estudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_concepto_pago;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_nombre_acudiente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_valor_faltante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_valor_total;
        private System.Windows.Forms.ComboBox combo_tipo_abono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_valor_pago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorTipoAbono;
        private System.Windows.Forms.ErrorProvider errorValorAbonar;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.Label label_documento_estudiante;
        private System.Windows.Forms.Label label6;
    }
}