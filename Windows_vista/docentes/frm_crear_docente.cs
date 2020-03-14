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

namespace Windows_vista.docentes
{
    public partial class frm_crear_docente : Form
    {
        public frm_crear_docente(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            CargarDatos();
            this.usuarioGestion = usuario;
        }

        BLUsuario blUsuario = new BLUsuario();
        Usuario usuarioGestion;
        Usuario usuario;

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

        }

        private void frm_crear_docente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_docentes frm_admin_docentes = new Frm_admin_docentes(usuario);
            frm_admin_docentes.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
                errorProvider.SetError(Txt_celular, "Ingrese el celular");
                Txt_celular.Focus();
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
            usuario.TipoDocumento = (Combo_tipo_documento.SelectedItem as ComboboxItem).Value.ToString();
            usuario.Nombres = Txt_nombres.Text;
            usuario.Apellidos = Txt_apellidos.Text;
            usuario.Direccion = Txt_direccion.Text;
            usuario.CorreoElectronico = Txt_correo_electronico.Text;
            usuario.Celular = Txt_celular.Text;
            usuario.Telefono = Txt_telefono.Text;
            usuario.UsuarioCreacion = "1";
            usuario.FechaCreacion = fechaActual;
            usuario.TipoUsuario = "D";

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
    }
}
