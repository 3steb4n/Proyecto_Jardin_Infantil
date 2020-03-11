using Entidades;
using Negocio;
using System;
using System.Windows.Forms;

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
                errorProvider.SetError(Txt_celular, "Ingrese el celular");
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
