namespace Windows_vista.pagos
{
    partial class Frm_pago_detalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pago_detalle));
            this.dgv_abono_pago = new System.Windows.Forms.DataGridView();
            this.id_abono_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_concepto_pago = new System.Windows.Forms.Label();
            this.label_nombre_acudiente = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_nombre_estudiante = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_estado_valor = new System.Windows.Forms.Label();
            this.label_estado_info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_documento_estudiante = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_abonado_valor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_valor_pago = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_id_pago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_abonar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abono_pago)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_abono_pago
            // 
            this.dgv_abono_pago.AllowUserToAddRows = false;
            this.dgv_abono_pago.AllowUserToDeleteRows = false;
            this.dgv_abono_pago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_abono_pago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_abono_pago.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_abono_pago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_abono_pago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_abono_pago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_abono_pago.ColumnHeadersHeight = 30;
            this.dgv_abono_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_abono_pago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_abono_pago,
            this.tipo_abono,
            this.valor_abono,
            this.descripcion_abono,
            this.fecha_creacion,
            this.id_pago,
            this.descripcion_pago,
            this.usuario_nombres});
            this.dgv_abono_pago.EnableHeadersVisualStyles = false;
            this.dgv_abono_pago.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_abono_pago.Location = new System.Drawing.Point(31, 176);
            this.dgv_abono_pago.Name = "dgv_abono_pago";
            this.dgv_abono_pago.ReadOnly = true;
            this.dgv_abono_pago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_abono_pago.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_abono_pago.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_abono_pago.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_abono_pago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_abono_pago.Size = new System.Drawing.Size(980, 362);
            this.dgv_abono_pago.TabIndex = 57;
            // 
            // id_abono_pago
            // 
            this.id_abono_pago.HeaderText = "# abono";
            this.id_abono_pago.Name = "id_abono_pago";
            this.id_abono_pago.ReadOnly = true;
            // 
            // tipo_abono
            // 
            this.tipo_abono.HeaderText = "Tipo abono";
            this.tipo_abono.Name = "tipo_abono";
            this.tipo_abono.ReadOnly = true;
            // 
            // valor_abono
            // 
            this.valor_abono.HeaderText = "Valor abonado";
            this.valor_abono.Name = "valor_abono";
            this.valor_abono.ReadOnly = true;
            // 
            // descripcion_abono
            // 
            this.descripcion_abono.HeaderText = "Descripción abono";
            this.descripcion_abono.Name = "descripcion_abono";
            this.descripcion_abono.ReadOnly = true;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.HeaderText = "Fecha abono";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            // 
            // id_pago
            // 
            this.id_pago.HeaderText = "# Pago";
            this.id_pago.Name = "id_pago";
            this.id_pago.ReadOnly = true;
            // 
            // descripcion_pago
            // 
            this.descripcion_pago.HeaderText = "Descripción abono";
            this.descripcion_pago.Name = "descripcion_pago";
            this.descripcion_pago.ReadOnly = true;
            // 
            // usuario_nombres
            // 
            this.usuario_nombres.HeaderText = "Secretaria";
            this.usuario_nombres.Name = "usuario_nombres";
            this.usuario_nombres.ReadOnly = true;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Fecha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Concepto de pago :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nombre acudiente :";
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
            // label_nombre_acudiente
            // 
            this.label_nombre_acudiente.AutoSize = true;
            this.label_nombre_acudiente.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_acudiente.ForeColor = System.Drawing.Color.White;
            this.label_nombre_acudiente.Location = new System.Drawing.Point(173, 103);
            this.label_nombre_acudiente.Name = "label_nombre_acudiente";
            this.label_nombre_acudiente.Size = new System.Drawing.Size(114, 17);
            this.label_nombre_acudiente.TabIndex = 75;
            this.label_nombre_acudiente.Text = "nombre acudiente";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.White;
            this.label_fecha.Location = new System.Drawing.Point(87, 136);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(39, 17);
            this.label_fecha.TabIndex = 76;
            this.label_fecha.Text = "fecha";
            // 
            // label_nombre_estudiante
            // 
            this.label_nombre_estudiante.AutoSize = true;
            this.label_nombre_estudiante.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre_estudiante.ForeColor = System.Drawing.Color.White;
            this.label_nombre_estudiante.Location = new System.Drawing.Point(463, 70);
            this.label_nombre_estudiante.Name = "label_nombre_estudiante";
            this.label_nombre_estudiante.Size = new System.Drawing.Size(114, 17);
            this.label_nombre_estudiante.TabIndex = 81;
            this.label_nombre_estudiante.Text = "nombre acudiente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(313, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Nombre estudiante :";
            // 
            // label_estado_valor
            // 
            this.label_estado_valor.AutoSize = true;
            this.label_estado_valor.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado_valor.ForeColor = System.Drawing.Color.Black;
            this.label_estado_valor.Location = new System.Drawing.Point(89, 11);
            this.label_estado_valor.Name = "label_estado_valor";
            this.label_estado_valor.Size = new System.Drawing.Size(60, 20);
            this.label_estado_valor.TabIndex = 83;
            this.label_estado_valor.Text = "estado";
            // 
            // label_estado_info
            // 
            this.label_estado_info.AutoSize = true;
            this.label_estado_info.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado_info.ForeColor = System.Drawing.Color.Black;
            this.label_estado_info.Location = new System.Drawing.Point(14, 11);
            this.label_estado_info.Name = "label_estado_info";
            this.label_estado_info.Size = new System.Drawing.Size(69, 20);
            this.label_estado_info.TabIndex = 82;
            this.label_estado_info.Text = "Estado :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label_documento_estudiante);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_abonado_valor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_valor_pago);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_id_pago);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label_nombre_estudiante);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label_concepto_pago);
            this.panel1.Controls.Add(this.label_fecha);
            this.panel1.Controls.Add(this.label_nombre_acudiente);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 170);
            this.panel1.TabIndex = 84;
            // 
            // label_documento_estudiante
            // 
            this.label_documento_estudiante.AutoSize = true;
            this.label_documento_estudiante.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_documento_estudiante.ForeColor = System.Drawing.Color.White;
            this.label_documento_estudiante.Location = new System.Drawing.Point(463, 101);
            this.label_documento_estudiante.Name = "label_documento_estudiante";
            this.label_documento_estudiante.Size = new System.Drawing.Size(114, 17);
            this.label_documento_estudiante.TabIndex = 90;
            this.label_documento_estudiante.Text = "nombre acudiente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(290, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Documento estudiante :";
            // 
            // label_abonado_valor
            // 
            this.label_abonado_valor.AutoSize = true;
            this.label_abonado_valor.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_abonado_valor.ForeColor = System.Drawing.Color.White;
            this.label_abonado_valor.Location = new System.Drawing.Point(738, 102);
            this.label_abonado_valor.Name = "label_abonado_valor";
            this.label_abonado_valor.Size = new System.Drawing.Size(48, 17);
            this.label_abonado_valor.TabIndex = 88;
            this.label_abonado_valor.Text = "estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(611, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Valor abonado:";
            // 
            // label_valor_pago
            // 
            this.label_valor_pago.AutoSize = true;
            this.label_valor_pago.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor_pago.ForeColor = System.Drawing.Color.White;
            this.label_valor_pago.Location = new System.Drawing.Point(738, 72);
            this.label_valor_pago.Name = "label_valor_pago";
            this.label_valor_pago.Size = new System.Drawing.Size(48, 17);
            this.label_valor_pago.TabIndex = 86;
            this.label_valor_pago.Text = "estado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_estado_valor);
            this.panel2.Controls.Add(this.label_estado_info);
            this.panel2.ForeColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(815, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 37);
            this.panel2.TabIndex = 85;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(671, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Valor :";
            // 
            // Btn_abonar
            // 
            this.Btn_abonar.BackColor = System.Drawing.Color.Teal;
            this.Btn_abonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_abonar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_abonar.ForeColor = System.Drawing.Color.White;
            this.Btn_abonar.Location = new System.Drawing.Point(891, 576);
            this.Btn_abonar.Name = "Btn_abonar";
            this.Btn_abonar.Size = new System.Drawing.Size(120, 32);
            this.Btn_abonar.TabIndex = 86;
            this.Btn_abonar.Text = "Abonar";
            this.Btn_abonar.UseVisualStyleBackColor = false;
            this.Btn_abonar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::Windows_vista.Properties.Resources.actualizar__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(834, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 30);
            this.button2.TabIndex = 87;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_pago_detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1035, 625);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_abonar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_abono_pago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_pago_detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_pago_detalle_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abono_pago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_abono_pago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_concepto_pago;
        private System.Windows.Forms.Label label_nombre_acudiente;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_nombre_estudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_estado_valor;
        private System.Windows.Forms.Label label_estado_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_id_pago;
        private System.Windows.Forms.Label label_valor_pago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_abonar;
        private System.Windows.Forms.Label label_abonado_valor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_documento_estudiante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_abono_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_nombres;
        private System.Windows.Forms.Button button2;
    }
}