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

namespace Windows_vista.usuarios
{
    public partial class Frm_actualizar_mi_perfil : Form
    {
        public Frm_actualizar_mi_perfil(Usuario usuario)
        {
            InitializeComponent();
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
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
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
    }
}
