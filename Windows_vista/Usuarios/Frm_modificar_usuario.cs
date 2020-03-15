using Entidades;
using Negocio;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_modificar_usuario : Form
    {
        public Frm_modificar_usuario(Usuario usuario, Usuario usuario_gestion)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            cargarDatos(usuario);
            id_usuario = usuario.Id_usuario;
            this.usuariogestion = usuario_gestion;

        }

        int id_usuario;
        BLUsuario blUsuario = new BLUsuario();
        Usuario usuariogestion;

        public void cargarDatos(Usuario usuario)
        {
            // se llenan valores fijos de los tipos de documentos
            Combo_tipo_documento.Items.Add("Seleccione...").ToString();
            Combo_tipo_documento.Items.Add("Cedula de ciudadania").ToString();
            Combo_tipo_documento.Items.Add("Tarjeta de identidad").ToString();
            Combo_tipo_documento.Items.Add("Pasaporte").ToString();
            Combo_tipo_documento.Items.Add("DNI").ToString();
            Combo_tipo_documento.Items.Add("Cedula de extranjeria").ToString();


            // se llenan valores fijos de tipos de usuarios
            Combo_tipo_usuario.Items.Add("Seleccione...").ToString();
            Combo_tipo_usuario.Items.Add("Administrador").ToString();
            Combo_tipo_usuario.Items.Add("Secretaria").ToString();
            Combo_tipo_usuario.Items.Add("Docente").ToString();

            // se llenan los valores fijos del estado del usuario

            Combo_estado_usuario.Items.Add("Seleccione...").ToString();
            Combo_estado_usuario.Items.Add("Activo").ToString();
            Combo_estado_usuario.Items.Add("Inactivo").ToString();

            // se llenan los valores fijops del estado de la contraseña

            Combo_estado_clave.Items.Add("Seleccione...").ToString();
            Combo_estado_clave.Items.Add("Cambiada").ToString();
            Combo_estado_clave.Items.Add("Sin cambiar").ToString();

            Txt_numero_documento.Text = usuario.Documento;
            Combo_tipo_documento.SelectedItem = usuario.TipoDocumento;
            Txt_nombres.Text = usuario.Nombres;
            Txt_apellidos.Text = usuario.Apellidos;
            Txt_direccion.Text = usuario.Direccion;
            Txt_correo_electronico.Text = usuario.CorreoElectronico;
            Txt_celular.Text = usuario.Celular;
            Txt_telefono.Text = usuario.Telefono;
            Combo_tipo_usuario.SelectedItem = usuario.TipoUsuario;
            Combo_estado_clave.SelectedItem = usuario.EstadoClave;
            Combo_estado_usuario.SelectedItem = usuario.EstadoUsuario;
            Console.WriteLine(usuario.TipoUsuario);
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            DateTime fechaActual = DateTime.Today;

            usuario.Id_usuario = id_usuario;
            usuario.Documento = Txt_numero_documento.Text;
            usuario.TipoDocumento = Combo_tipo_documento.Text;
            usuario.Nombres = Txt_nombres.Text;
            usuario.Apellidos = Txt_apellidos.Text;
            usuario.Direccion = Txt_direccion.Text;
            usuario.CorreoElectronico = Txt_correo_electronico.Text;
            usuario.Celular = Txt_celular.Text;
            usuario.Telefono = Txt_telefono.Text;
            usuario.UsuarioModificacion = "1";
            usuario.FechaModificacion = fechaActual;
            usuario.EstadoUsuario = Combo_estado_usuario.Text;
            usuario.EstadoClave = Combo_estado_clave.Text;
            usuario.TipoUsuario = Combo_tipo_usuario.Text;
            usuario = Ordenar(usuario);

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                bool flag = blUsuario.ModificarUsuario(usuario);
                if (flag)
                {
                    MessageBox.Show("Usuario modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Usuario Ordenar(Usuario usuario)
        {
            // formato a combobox tipo documento

            if (usuario.TipoDocumento == "Cedula de ciudadania")
            {
                usuario.TipoDocumento = "CC";

            }
            else if (usuario.TipoDocumento == "Tarjeta de identidad")
            {
                usuario.TipoDocumento = "TI";
            }
            else if (usuario.TipoDocumento == "Pasaporte")
            {
                usuario.TipoDocumento = "P";
            }
            else if (usuario.TipoDocumento == "DNI")
            {
                usuario.TipoDocumento = "DNI";
            }
            else if (usuario.TipoDocumento == "Cedula de extranjeria")
            {
                usuario.TipoDocumento = "CE";
            }

            // formato a combobox tipo usuario

            if (usuario.TipoUsuario == "Administrador")
            {
                usuario.TipoUsuario = "A";
            }
            else if (usuario.TipoUsuario == "Docente")
            {
                usuario.TipoUsuario = "D";
            }
            else if (usuario.TipoUsuario == "Secretaria")
            {
                usuario.TipoUsuario = "S";
            }

            // ordenar estado usuario
            if (usuario.EstadoUsuario == "Activo")
            {
                usuario.EstadoUsuario = "A";
            }
            else
            {
                usuario.EstadoUsuario = "I";
            }

            // ordenar estado clave

            if (usuario.EstadoClave == "Cambiada")
            {
                usuario.EstadoClave = "C";
            }
            else
            {
                usuario.EstadoClave = "S";
            }
            return usuario;

        }

        private void Frm_modificar_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_usuarios admin_usuarios = new Frm_administracion_usuarios(usuariogestion);
            admin_usuarios.Show();
        }

        private void Txt_numero_documento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_numero_documento.Text == "" || Txt_numero_documento.Text == "0")
            {
                e.Cancel = true;
                errorNum.SetError(Txt_numero_documento, "Introdusca numero de documento");
                Txt_nombres.Focus();
            }
            else if (!Regex.IsMatch(Txt_numero_documento.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorNum.SetError(Txt_numero_documento, "Solo numeros");
                Txt_numero_documento.Focus();
            }
            else
            {
                errorNum.Clear();
            }
        }

        private void Combo_tipo_documento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_tipo_documento.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorTipo.SetError(Combo_tipo_documento, "Seleccione el tipo de documento");
                Combo_tipo_documento.Focus();
            }
            else
            {
                errorTipo.Clear();
            }
        }

        private void Txt_nombres_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_nombres.Text == "")
            {
                e.Cancel = true;
                errorNombres.SetError(Txt_nombres, "Ingrese nombre");
                Txt_nombres.Focus();
            }
            else if (!Regex.IsMatch(Txt_nombres.Text, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                errorNombres.SetError(Txt_nombres, "Solo letras");
                Txt_nombres.Focus();
            }
            else
            {
                errorNombres.Clear();
            }
        }

        private void Txt_apellidos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_apellidos.Text == "")
            {
                e.Cancel = true;
                errorApellidos.SetError(Txt_apellidos, "Ingrese apellido");
                Txt_apellidos.Focus();
            }
            else if (!Regex.IsMatch(Txt_apellidos.Text, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                errorApellidos.SetError(Txt_apellidos, "Solo letras");
                Txt_apellidos.Focus();
            }
            else
            {
                errorApellidos.Clear();
            }
        }

        private void Txt_direccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_direccion.Text == "")
            {
                e.Cancel = true;
                errorDireccion.SetError(Txt_direccion, "Ingrese la dirección");
                Txt_direccion.Focus();
            }
            else
            {
                errorDireccion.Clear();
            }
        }

        private void Txt_correo_electronico_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_correo_electronico.Text == "")
            {
                e.Cancel = true;
                errorCorreoElectronico.SetError(Txt_correo_electronico, "Ingrese el correo electrónico");
                Txt_correo_electronico.Focus();
            }
            else if (!Regex.IsMatch(Txt_correo_electronico.Text, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))
            {
                e.Cancel = true;
                errorCorreoElectronico.SetError(Txt_correo_electronico, "Dirección de correo electrónico no valida");
                Txt_correo_electronico.Focus();
            }
            else
            {
                errorCorreoElectronico.Clear();
            }
        }

        private void Txt_celular_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_celular.Text == "" || Txt_celular.Text == "0" ) 
            {
                e.Cancel = true;
                errorCelular.SetError(Txt_celular, "Ingrese el numero de celular");
                Txt_celular.Focus();
            }
            else if (!Regex.IsMatch(Txt_celular.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorCelular.SetError(Txt_celular, "Solo numeros");
                Txt_celular.Focus();
            }
            else
            {
                errorCelular.Clear();
            }
        }

        private void Txt_telefono_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_telefono.Text == "" || Txt_telefono.Text == "0")
            {
                e.Cancel = true;
                errorTelefono.SetError(Txt_telefono, "Ingrese el numero de telefono");
                Txt_telefono.Focus();
            }
            else if (!Regex.IsMatch(Txt_telefono.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorTelefono.SetError(Txt_telefono, "Solo numeros");
                Txt_telefono.Focus();
            }
            else
            {
                errorTelefono.Clear();
            }
        }

        private void Combo_tipo_usuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_tipo_usuario.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorTipoUsuario.SetError(Combo_tipo_usuario, "Seleccione el tipo de usuario");
                Combo_tipo_usuario.Focus();
            }
            else
            {
                errorTipoUsuario.Clear();
            }
        }

        private void Combo_estado_usuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_estado_usuario.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorEstadoUsuario.SetError(Combo_estado_usuario, "Seleccione el tipo de usuario");
                Combo_estado_usuario.Focus();
            }
            else
            {
                errorEstadoUsuario.Clear();
            }
        }

        private void Combo_estado_clave_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_estado_clave.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorEstadoClave.SetError(Combo_estado_clave, "Seleccione el tipo de usuario");
                Combo_estado_clave.Focus();
            }
            else
            {
                errorEstadoClave.Clear();
            }
        }
    }
}

