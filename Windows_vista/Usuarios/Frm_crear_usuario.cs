using Entidades;
using Negocio;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_crear_usuario : Form
    {
        public Frm_crear_usuario(Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            CargarDatos();
            this.usuarioGestion = usuario;
        }

        BLUsuario blUsuario = new BLUsuario();
        Usuario usuarioGestion;

        private void CargarDatos()
        {
            ComboboxItem item_td1 = new ComboboxItem(); item_td1.Text = "Seleccione..."; item_td1.Value = "";
            ComboboxItem item_td2 = new ComboboxItem(); item_td2.Text = "Cedula de ciudadania"; item_td2.Value = "CC";
            ComboboxItem item_td3 = new ComboboxItem(); item_td3.Text = "Tarjeta de identidad"; item_td3.Value = "TI";
            ComboboxItem item_td4 = new ComboboxItem(); item_td4.Text = "Pasaporte"; item_td4.Value = "P";
            ComboboxItem item_td5 = new ComboboxItem(); item_td5.Text = "DNI"; item_td5.Value = "DNI";
            ComboboxItem item_td6 = new ComboboxItem(); item_td6.Text = "Cedula de exntrajeria"; item_td6.Value = "CE";
            Object[] items_td = new Object[6];
            items_td[0] = item_td1;
            items_td[1] = item_td2;
            items_td[2] = item_td3;
            items_td[3] = item_td4;
            items_td[4] = item_td5;
            items_td[5] = item_td6;
            Combo_tipo_documento.Items.AddRange(items_td);
            Combo_tipo_documento.SelectedIndex = 0;


            ComboboxItem item_rol1 = new ComboboxItem(); item_rol1.Text = "Seleccione..."; item_rol1.Value = "";
            ComboboxItem item_rol2 = new ComboboxItem(); item_rol2.Text = "Administrador"; item_rol2.Value = "A";
            ComboboxItem item_rol3 = new ComboboxItem(); item_rol3.Text = "Secretaria"; item_rol3.Value = "S";
            ComboboxItem item_rol4 = new ComboboxItem(); item_rol4.Text = "Docente"; item_rol4.Value = "D";
            Object[] items_rol = new Object[4];
            items_rol[0] = item_rol1;
            items_rol[1] = item_rol2;
            items_rol[2] = item_rol3;
            items_rol[3] = item_rol4;

            Combo_tipo_usuario.Items.AddRange(items_rol);
            Combo_tipo_usuario.SelectedIndex = 0;


        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Usuario usuario = new Usuario();

                guardar(usuario);
            }
        }

        private void guardar(Usuario usuario)
        {
            DateTime fechaActual = DateTime.Today;

            usuario.Documento = Txt_numero_documento.Text;
            usuario.TipoDocumento = (Combo_tipo_documento.SelectedItem as ComboboxItem).Value.ToString();
            usuario.Nombres = Txt_nombres.Text;
            usuario.Apellidos = Txt_apellidos.Text;
            usuario.Direccion = Txt_direccion.Text;
            usuario.CorreoElectronico = Txt_correo_electronico.Text;
            usuario.Celular = Txt_celular.Text;
            usuario.Telefono = Txt_telefono.Text;
            usuario.UsuarioCreacion = "1";
            usuario.FechaCreacion = fechaActual;
            usuario.TipoUsuario = (Combo_tipo_usuario.SelectedItem as ComboboxItem).Value.ToString();


            bool bandera = blUsuario.InsertarUsuario(usuario);

            if (bandera)
            {
                MessageBox.Show("Usuario creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Frm_Crear_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_usuarios admin_usuarios = new Frm_administracion_usuarios(usuarioGestion);
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
    }
}
