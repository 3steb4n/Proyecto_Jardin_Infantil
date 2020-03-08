using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Windows_vista
{
    public partial class Frm_crear_usuario : Form
    {
        public Frm_crear_usuario()
        {
            InitializeComponent();
            CargarDatos();
        }

        BLUsuario blUsuario = new BLUsuario();
        Usuario usuario;
        String tipo;

        private void CargarDatos()
        {
            // se llenan valores fijos de los tipos de documentos
            Combo_tipo_documento.Items.Add("Seleccione...").ToString();
            Combo_tipo_documento.Items.Add("Cedula de ciudadania").ToString();
            Combo_tipo_documento.Items.Add("Tarjeta de identidad").ToString();
            Combo_tipo_documento.Items.Add("Pasaporte").ToString();
            Combo_tipo_documento.Items.Add("DNI").ToString();
            Combo_tipo_documento.Items.Add("Cedula de extranjeria").ToString();
            Combo_tipo_documento.SelectedIndex = 0;


            // se llenan valores fijos de tipos de usuarios
            Combo_tipo_usuario.Items.Add("Seleccione...").ToString();
            Combo_tipo_usuario.Items.Add("Administrador").ToString();
            Combo_tipo_usuario.Items.Add("Secretaria").ToString();
            Combo_tipo_usuario.Items.Add("Docente").ToString();
            Combo_tipo_usuario.SelectedIndex = 0;

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            bool flag = true;
            if (Txt_numero_documento.Text == "")
            {
                errorProvider.SetError(Txt_numero_documento, "Introdusca numero de documento");
                Txt_numero_documento.Focus();
                flag = false;
            }
            if (Combo_tipo_documento.Text == "")
            {
                errorProvider.SetError(Combo_tipo_documento, "Seleccione...");
                Combo_tipo_documento.Focus();
                flag = false;
            }
            if (Txt_nombres.Text == "")
            {
                errorProvider.SetError(Txt_nombres, "Ingrese nombre");
                Txt_nombres.Focus();
                flag = false;
            }
            if (Txt_apellidos.Text == "")
            {
                errorProvider.SetError(Txt_apellidos, "Ingrese apellido");
                Txt_apellidos.Focus();
                flag = false;
            }
            if (Txt_correo_electronico.Text == "")
            {
                errorProvider.SetError(Txt_correo_electronico, "Ingrese el correo electrónico");
                Txt_correo_electronico.Focus();
                flag = false;
            }
            if (Txt_celular.Text == "")
            {
                errorProvider.SetError(Txt_celular, "Ingrese el correo electrónico");
                Txt_celular.Focus();
                flag = false;
            }
            if (Combo_tipo_usuario.Text == "")
            {
                errorProvider.SetError(Combo_tipo_usuario, "Seleccione...");
                Combo_tipo_usuario.Focus();
                flag = false;
            }

            return flag;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario();

                guardar(usuario);

            }
        }

        private void guardar(Usuario usuario)
        {
            DateTime fechaActual = DateTime.Today;

            usuario.Documento = Txt_numero_documento.Text;
            usuario.Nombres = Txt_nombres.Text;
            usuario.Apellidos = Txt_apellidos.Text;
            usuario.Direccion = Txt_direccion.Text;
            usuario.CorreoElectronico = Txt_correo_electronico.Text;
            usuario.Celular = Txt_celular.Text;
            usuario.Telefono = Txt_telefono.Text;
            usuario.UsuarioCreacion = "1";
            usuario.FechaCreacion = fechaActual;

            // formato a combobox tipo documento

            if (Combo_tipo_documento.Text == "Cedula de ciudadania")
            {
                usuario.TipoDocumento = "CC";

            }
            else if (Combo_tipo_documento.Text == "Tarjeta de identidad")
            {
                usuario.TipoDocumento = "TI";
            }
            else if (Combo_tipo_documento.Text == "Pasaporte")
            {
                usuario.TipoDocumento = "P";
            }
            else if (Combo_tipo_documento.Text == "DNI")
            {
                usuario.TipoDocumento = "DNI";
            }
            else if (Combo_tipo_documento.Text == "Cedula de extranjeria")
            {
                usuario.TipoDocumento = "CE";
            }

            // formato a combobox tipo usuario

            if (Combo_tipo_usuario.Text == "Administrador")
            {
                usuario.TipoUsuario = "A";

            }
            else if (Combo_tipo_usuario.Text == "Docente")
            {
                usuario.TipoUsuario = "D";
            }
            else if (Combo_tipo_usuario.Text == "Secretaria")
            {
                usuario.TipoUsuario = "S";
            }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Crear_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Crear_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_usuarios admin_usuarios = new Frm_administracion_usuarios();
            admin_usuarios.Show();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
