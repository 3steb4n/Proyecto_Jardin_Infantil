using Entidades;
using Negocio;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista.usuarios
{
    public partial class Frm_actualizar_mi_perfil : Form
    {
        public Frm_actualizar_mi_perfil(Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.usuario = blUsuario.ListaPorDocumento(usuario.Documento);
            cargarDatos(this.usuario);
        }

        BLUsuario blUsuario = new BLUsuario();
        Usuario usuario;
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

            // se llenan los valores en los campos

            Txt_numero_documento.Text = usuario.Documento;
            Combo_tipo_documento.SelectedItem = usuario.TipoDocumento;
            Txt_nombres.Text = usuario.Nombres;
            Txt_apellidos.Text = usuario.Apellidos;
            Txt_direccion.Text = usuario.Direccion;
            Txt_correo_electronico.Text = usuario.CorreoElectronico;
            Txt_celular.Text = usuario.Celular;
            Txt_telefono.Text = usuario.Telefono;
            Combo_tipo_usuario.SelectedItem = usuario.TipoUsuario;

            Console.WriteLine(usuario.TipoUsuario);

            if (check_contrasena.Checked)
            {
                panel_contrasena.Enabled = true;
            }
            else
            {
                panel_contrasena.Enabled = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Usuario usuario = new Usuario();
                DateTime fechaActual = DateTime.Today;

                usuario.Id_usuario = this.usuario.Id_usuario;
                usuario.Nombres = Txt_nombres.Text;
                usuario.Apellidos = Txt_apellidos.Text;
                usuario.Direccion = Txt_direccion.Text;
                usuario.CorreoElectronico = Txt_correo_electronico.Text;
                usuario.Celular = Txt_celular.Text;
                usuario.Telefono = Txt_telefono.Text;
                usuario.UsuarioModificacion = this.usuario.Id_usuario.ToString();
                usuario.FechaModificacion = fechaActual;


                if (txt_pass_nueva.Text == txt_repitir_pass.Text)
                {
                    usuario.Clave = txt_pass_nueva.Text;
                    if (!check_contrasena.Checked)
                    {
                        bool flag = blUsuario.ModificarUsuarioPropio(usuario);
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
                    else
                    {
                        bool flag = blUsuario.ModificarUsuarioContrasena(usuario);
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
                else
                {
                    MessageBox.Show("La contraseña y su confirmación no son iguales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_numero_documento_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_numero_documento.Text == "" || Txt_numero_documento.Text == "0")
            {
                e.Cancel = true;
                errorNumero.SetError(Txt_numero_documento, "Introdusca numero de documento");
                Txt_nombres.Focus();
            }
            else if (!Regex.IsMatch(Txt_numero_documento.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorNumero.SetError(Txt_numero_documento, "Solo numeros");
                Txt_numero_documento.Focus();
            }
            else
            {
                errorNumero.Clear();
            }
        }

        private void Combo_tipo_documento_Validating(object sender, CancelEventArgs e)
        {
            if (Combo_tipo_documento.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorTipoDocumento.SetError(Combo_tipo_documento, "Seleccione el tipo de documento");
                Combo_tipo_documento.Focus();
            }
            else
            {
                errorTipoDocumento.Clear();
            }
        }

        private void Txt_nombres_Validating(object sender, CancelEventArgs e)
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

        private void Txt_apellidos_Validating(object sender, CancelEventArgs e)
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

        private void Txt_direccion_Validating(object sender, CancelEventArgs e)
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

        private void Txt_correo_electronico_Validating(object sender, CancelEventArgs e)
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

        private void Txt_celular_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_celular.Text == "" || Txt_celular.Text == "0")
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

        private void Txt_telefono_Validating(object sender, CancelEventArgs e)
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

        private void Combo_tipo_usuario_Validating(object sender, CancelEventArgs e)
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

        private void check_contrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (check_contrasena.Checked)
            {
                panel_contrasena.Enabled = true;
            }
            else
            {
                panel_contrasena.Enabled = false;
                errorPasswd.Clear();
                errorConfirmarPasswd.Clear();


            }
        }

        private void txt_pass_nueva_Validating(object sender, CancelEventArgs e)
        {
            if (txt_pass_nueva.Text == "")
            {
                e.Cancel = true;
                errorPasswd.SetError(txt_pass_nueva, "Ingrese la nueva contraseña");
                txt_pass_nueva.Focus();
            }
            else
            {
                errorPasswd.Clear();
            }
        }

        private void txt_repitir_pass_Validating(object sender, CancelEventArgs e)
        {
            if (txt_repitir_pass.Text == "")
            {
                e.Cancel = true;
                errorConfirmarPasswd.SetError(txt_repitir_pass, "Ingrese la confirmación de la contraseña");
                txt_repitir_pass.Focus();
            }
            else
            {
                errorConfirmarPasswd.Clear();
            }
        }
    }
}
