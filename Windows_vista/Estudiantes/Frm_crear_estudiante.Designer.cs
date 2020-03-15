namespace Windows_vista
{
    partial class Frm_crear_estudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_crear_estudiante));
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_grupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_observaciones = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.combo_genero = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_foto = new System.Windows.Forms.TextBox();
            this.Txt_nombre_acudiente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Combo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.Txt_nombres = new System.Windows.Forms.TextBox();
            this.Txt_apellidos = new System.Windows.Forms.TextBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_celular = new System.Windows.Forms.TextBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_correo_electronico = new System.Windows.Forms.TextBox();
            this.Txt_numero_documento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.combo_grupo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txt_observaciones);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.combo_genero);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Txt_foto);
            this.panel1.Controls.Add(this.Txt_nombre_acudiente);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.date_fecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.Combo_tipo_documento);
            this.panel1.Controls.Add(this.Txt_nombres);
            this.panel1.Controls.Add(this.Txt_apellidos);
            this.panel1.Controls.Add(this.Txt_direccion);
            this.panel1.Controls.Add(this.Txt_celular);
            this.panel1.Controls.Add(this.Txt_telefono);
            this.panel1.Controls.Add(this.Txt_correo_electronico);
            this.panel1.Controls.Add(this.Txt_numero_documento);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 598);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // combo_grupo
            // 
            this.combo_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_grupo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_grupo.FormattingEnabled = true;
            this.combo_grupo.Location = new System.Drawing.Point(41, 520);
            this.combo_grupo.Name = "combo_grupo";
            this.combo_grupo.Size = new System.Drawing.Size(271, 28);
            this.combo_grupo.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Grupo (*)";
            // 
            // Txt_observaciones
            // 
            this.Txt_observaciones.Location = new System.Drawing.Point(41, 377);
            this.Txt_observaciones.Multiline = true;
            this.Txt_observaciones.Name = "Txt_observaciones";
            this.Txt_observaciones.Size = new System.Drawing.Size(860, 117);
            this.Txt_observaciones.TabIndex = 40;
            this.Txt_observaciones.Text = "300";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 39;
            this.label16.Text = "Observaciones (*)";
            // 
            // combo_genero
            // 
            this.combo_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_genero.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_genero.FormattingEnabled = true;
            this.combo_genero.Location = new System.Drawing.Point(687, 183);
            this.combo_genero.Name = "combo_genero";
            this.combo_genero.Size = new System.Drawing.Size(214, 28);
            this.combo_genero.TabIndex = 38;
            this.combo_genero.SelectedIndexChanged += new System.EventHandler(this.combo_genero_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(683, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "Genero estudiante (*)";
            // 
            // Txt_foto
            // 
            this.Txt_foto.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_foto.Location = new System.Drawing.Point(687, 315);
            this.Txt_foto.Name = "Txt_foto";
            this.Txt_foto.Size = new System.Drawing.Size(178, 27);
            this.Txt_foto.TabIndex = 36;
            this.Txt_foto.TextChanged += new System.EventHandler(this.Txt_foto_TextChanged);
            // 
            // Txt_nombre_acudiente
            // 
            this.Txt_nombre_acudiente.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre_acudiente.Location = new System.Drawing.Point(385, 315);
            this.Txt_nombre_acudiente.MaxLength = 30;
            this.Txt_nombre_acudiente.Name = "Txt_nombre_acudiente";
            this.Txt_nombre_acudiente.Size = new System.Drawing.Size(271, 27);
            this.Txt_nombre_acudiente.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(382, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Nombre acudiente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(683, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Foto (*)";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // date_fecha
            // 
            this.date_fecha.CalendarFont = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fecha.Location = new System.Drawing.Point(687, 118);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(214, 20);
            this.date_fecha.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha nacimiento (*)";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(422, 557);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 27;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Combo_tipo_documento
            // 
            this.Combo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_tipo_documento.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_tipo_documento.FormattingEnabled = true;
            this.Combo_tipo_documento.Location = new System.Drawing.Point(385, 118);
            this.Combo_tipo_documento.Name = "Combo_tipo_documento";
            this.Combo_tipo_documento.Size = new System.Drawing.Size(271, 28);
            this.Combo_tipo_documento.TabIndex = 21;
            this.Combo_tipo_documento.SelectedIndexChanged += new System.EventHandler(this.Combo_tipo_documento_SelectedIndexChanged);
            // 
            // Txt_nombres
            // 
            this.Txt_nombres.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombres.Location = new System.Drawing.Point(41, 183);
            this.Txt_nombres.MaxLength = 30;
            this.Txt_nombres.Name = "Txt_nombres";
            this.Txt_nombres.Size = new System.Drawing.Size(301, 27);
            this.Txt_nombres.TabIndex = 20;
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidos.Location = new System.Drawing.Point(385, 183);
            this.Txt_apellidos.MaxLength = 30;
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(271, 27);
            this.Txt_apellidos.TabIndex = 19;
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(41, 248);
            this.Txt_direccion.MaxLength = 30;
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(301, 27);
            this.Txt_direccion.TabIndex = 18;
            // 
            // Txt_celular
            // 
            this.Txt_celular.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_celular.Location = new System.Drawing.Point(42, 315);
            this.Txt_celular.MaxLength = 15;
            this.Txt_celular.Name = "Txt_celular";
            this.Txt_celular.Size = new System.Drawing.Size(301, 27);
            this.Txt_celular.TabIndex = 17;
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.Location = new System.Drawing.Point(687, 248);
            this.Txt_telefono.MaxLength = 15;
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(214, 27);
            this.Txt_telefono.TabIndex = 16;
            // 
            // Txt_correo_electronico
            // 
            this.Txt_correo_electronico.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correo_electronico.Location = new System.Drawing.Point(385, 248);
            this.Txt_correo_electronico.MaxLength = 100;
            this.Txt_correo_electronico.Name = "Txt_correo_electronico";
            this.Txt_correo_electronico.Size = new System.Drawing.Size(271, 27);
            this.Txt_correo_electronico.TabIndex = 15;
            // 
            // Txt_numero_documento
            // 
            this.Txt_numero_documento.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numero_documento.Location = new System.Drawing.Point(41, 118);
            this.Txt_numero_documento.MaxLength = 20;
            this.Txt_numero_documento.Name = "Txt_numero_documento";
            this.Txt_numero_documento.Size = new System.Drawing.Size(301, 27);
            this.Txt_numero_documento.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Nombres (*)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Apellidos (*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dirección (*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(382, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tipo de documento (*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Celular acudiente(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefono acudiente (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Correo electrónico acudiente (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de documento (*)";
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
            this.panel2.Size = new System.Drawing.Size(967, 48);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar estudiante";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Frm_crear_estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(981, 603);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_crear_estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear estudiante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_crear_estudiante_FormClosing);
            this.Load += new System.EventHandler(this.Frm_crear_estudiante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_observaciones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox combo_genero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Txt_foto;
        private System.Windows.Forms.TextBox Txt_nombre_acudiente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox Combo_tipo_documento;
        private System.Windows.Forms.TextBox Txt_nombres;
        private System.Windows.Forms.TextBox Txt_apellidos;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.TextBox Txt_celular;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_correo_electronico;
        private System.Windows.Forms.TextBox Txt_numero_documento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox combo_grupo;
        private System.Windows.Forms.Label label4;
    }
}