namespace Windows_vista
{
    partial class Frm_modificar_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_modificar_usuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Combo_estado_clave = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Combo_estado_usuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Combo_tipo_usuario = new System.Windows.Forms.ComboBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorreoElectronico = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTipoUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstadoUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstadoClave = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreoElectronico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoClave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Combo_estado_clave);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Combo_estado_usuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Combo_tipo_usuario);
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 541);
            this.panel1.TabIndex = 1;
            // 
            // Combo_estado_clave
            // 
            this.Combo_estado_clave.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_estado_clave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_estado_clave.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_estado_clave.FormattingEnabled = true;
            this.Combo_estado_clave.Location = new System.Drawing.Point(41, 440);
            this.Combo_estado_clave.Name = "Combo_estado_clave";
            this.Combo_estado_clave.Size = new System.Drawing.Size(301, 28);
            this.Combo_estado_clave.TabIndex = 11;
            this.Combo_estado_clave.Validating += new System.ComponentModel.CancelEventHandler(this.Combo_estado_clave_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Estado Clave (*)";
            // 
            // Combo_estado_usuario
            // 
            this.Combo_estado_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_estado_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_estado_usuario.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_estado_usuario.FormattingEnabled = true;
            this.Combo_estado_usuario.Location = new System.Drawing.Point(385, 374);
            this.Combo_estado_usuario.Name = "Combo_estado_usuario";
            this.Combo_estado_usuario.Size = new System.Drawing.Size(271, 28);
            this.Combo_estado_usuario.TabIndex = 10;
            this.Combo_estado_usuario.Validating += new System.ComponentModel.CancelEventHandler(this.Combo_estado_usuario_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Estado Usuario (*)";
            // 
            // Combo_tipo_usuario
            // 
            this.Combo_tipo_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_tipo_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_tipo_usuario.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_tipo_usuario.FormattingEnabled = true;
            this.Combo_tipo_usuario.Location = new System.Drawing.Point(42, 374);
            this.Combo_tipo_usuario.Name = "Combo_tipo_usuario";
            this.Combo_tipo_usuario.Size = new System.Drawing.Size(300, 28);
            this.Combo_tipo_usuario.TabIndex = 9;
            this.Combo_tipo_usuario.Validating += new System.ComponentModel.CancelEventHandler(this.Combo_tipo_usuario_Validating);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(330, 494);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 32);
            this.btn_guardar.TabIndex = 12;
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
            this.Combo_tipo_documento.TabIndex = 2;
            this.Combo_tipo_documento.Validating += new System.ComponentModel.CancelEventHandler(this.Combo_tipo_documento_Validating);
            // 
            // Txt_nombres
            // 
            this.Txt_nombres.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombres.Location = new System.Drawing.Point(41, 178);
            this.Txt_nombres.MaxLength = 30;
            this.Txt_nombres.Name = "Txt_nombres";
            this.Txt_nombres.Size = new System.Drawing.Size(301, 27);
            this.Txt_nombres.TabIndex = 3;
            this.Txt_nombres.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_nombres_Validating);
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellidos.Location = new System.Drawing.Point(385, 178);
            this.Txt_apellidos.MaxLength = 30;
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(271, 27);
            this.Txt_apellidos.TabIndex = 4;
            this.Txt_apellidos.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_apellidos_Validating);
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_direccion.Location = new System.Drawing.Point(41, 240);
            this.Txt_direccion.MaxLength = 30;
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(301, 27);
            this.Txt_direccion.TabIndex = 5;
            this.Txt_direccion.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_direccion_Validating);
            // 
            // Txt_celular
            // 
            this.Txt_celular.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_celular.Location = new System.Drawing.Point(41, 303);
            this.Txt_celular.MaxLength = 15;
            this.Txt_celular.Name = "Txt_celular";
            this.Txt_celular.Size = new System.Drawing.Size(301, 27);
            this.Txt_celular.TabIndex = 7;
            this.Txt_celular.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_celular_Validating);
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_telefono.Location = new System.Drawing.Point(385, 305);
            this.Txt_telefono.MaxLength = 15;
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(271, 27);
            this.Txt_telefono.TabIndex = 8;
            this.Txt_telefono.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_telefono_Validating);
            // 
            // Txt_correo_electronico
            // 
            this.Txt_correo_electronico.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_correo_electronico.Location = new System.Drawing.Point(385, 240);
            this.Txt_correo_electronico.MaxLength = 100;
            this.Txt_correo_electronico.Name = "Txt_correo_electronico";
            this.Txt_correo_electronico.Size = new System.Drawing.Size(271, 27);
            this.Txt_correo_electronico.TabIndex = 6;
            this.Txt_correo_electronico.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_correo_electronico_Validating);
            // 
            // Txt_numero_documento
            // 
            this.Txt_numero_documento.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numero_documento.Location = new System.Drawing.Point(41, 118);
            this.Txt_numero_documento.MaxLength = 20;
            this.Txt_numero_documento.Name = "Txt_numero_documento";
            this.Txt_numero_documento.Size = new System.Drawing.Size(301, 27);
            this.Txt_numero_documento.TabIndex = 1;
            this.Txt_numero_documento.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_numero_documento_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Nombres (*)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Apellidos (*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dirección";
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
            this.label8.Location = new System.Drawing.Point(38, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Celular (*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Correo electrónico (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo usuario (*)";
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
            this.panel2.Size = new System.Drawing.Size(755, 48);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modificar usuario";
            // 
            // errorNum
            // 
            this.errorNum.BlinkRate = 0;
            this.errorNum.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorNum.ContainerControl = this;
            // 
            // errorTipo
            // 
            this.errorTipo.BlinkRate = 0;
            this.errorTipo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTipo.ContainerControl = this;
            // 
            // errorNombres
            // 
            this.errorNombres.BlinkRate = 0;
            this.errorNombres.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorNombres.ContainerControl = this;
            // 
            // errorApellidos
            // 
            this.errorApellidos.BlinkRate = 0;
            this.errorApellidos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorApellidos.ContainerControl = this;
            // 
            // errorDireccion
            // 
            this.errorDireccion.BlinkRate = 0;
            this.errorDireccion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDireccion.ContainerControl = this;
            // 
            // errorCorreoElectronico
            // 
            this.errorCorreoElectronico.BlinkRate = 0;
            this.errorCorreoElectronico.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCorreoElectronico.ContainerControl = this;
            // 
            // errorCelular
            // 
            this.errorCelular.BlinkRate = 0;
            this.errorCelular.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCelular.ContainerControl = this;
            // 
            // errorTelefono
            // 
            this.errorTelefono.BlinkRate = 0;
            this.errorTelefono.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTelefono.ContainerControl = this;
            // 
            // errorTipoUsuario
            // 
            this.errorTipoUsuario.BlinkRate = 0;
            this.errorTipoUsuario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTipoUsuario.ContainerControl = this;
            // 
            // errorEstadoUsuario
            // 
            this.errorEstadoUsuario.BlinkRate = 0;
            this.errorEstadoUsuario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorEstadoUsuario.ContainerControl = this;
            // 
            // errorEstadoClave
            // 
            this.errorEstadoClave.BlinkRate = 0;
            this.errorEstadoClave.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorEstadoClave.ContainerControl = this;
            // 
            // Frm_modificar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(774, 559);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_modificar_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_modificar_usuario_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreoElectronico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTipoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoClave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Combo_tipo_usuario;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_estado_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Combo_estado_clave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorNum;
        private System.Windows.Forms.ErrorProvider errorTipo;
        private System.Windows.Forms.ErrorProvider errorNombres;
        private System.Windows.Forms.ErrorProvider errorApellidos;
        private System.Windows.Forms.ErrorProvider errorDireccion;
        private System.Windows.Forms.ErrorProvider errorCorreoElectronico;
        private System.Windows.Forms.ErrorProvider errorCelular;
        private System.Windows.Forms.ErrorProvider errorTelefono;
        private System.Windows.Forms.ErrorProvider errorTipoUsuario;
        private System.Windows.Forms.ErrorProvider errorEstadoUsuario;
        private System.Windows.Forms.ErrorProvider errorEstadoClave;
    }
}