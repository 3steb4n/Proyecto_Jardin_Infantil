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
    public partial class frm_modificar_docente : Form
    {
        public frm_modificar_docente(Usuario usuario, Usuario usuarioGestion)
        {
            InitializeComponent();
            cargarDatos(usuario);
            id_usuario = usuario.Id_usuario;
            this.usuariogestion = usuarioGestion;
        }

        int id_usuario;
        BLUsuario blUsuario = new BLUsuario();
        Usuario usuariogestion;

        private void frm_modificar_docente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_docentes frm_admin_docentes = new Frm_admin_docentes(usuariogestion);
            frm_admin_docentes.Show();
        }
        public void cargarDatos(Usuario usuario)
        {
            // se llenan valores fijos de los tipos de documentos
            Combo_tipo_documento.Items.Add("Seleccione...").ToString();
            Combo_tipo_documento.Items.Add("Cedula de ciudadania").ToString();
            Combo_tipo_documento.Items.Add("Tarjeta de identidad").ToString();
            Combo_tipo_documento.Items.Add("Pasaporte").ToString();
            Combo_tipo_documento.Items.Add("DNI").ToString();
            Combo_tipo_documento.Items.Add("Cedula de extranjeria").ToString();

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
            Combo_estado_clave.SelectedItem = usuario.EstadoClave;
            Combo_estado_usuario.SelectedItem = usuario.EstadoUsuario;
            Console.WriteLine(usuario.TipoUsuario);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            usuario.TipoUsuario = "D";
            usuario = Ordenar(usuario);


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
    }
}
