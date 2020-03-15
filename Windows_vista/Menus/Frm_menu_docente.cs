using Entidades;
using System;
using System.Windows.Forms;
using Windows_vista.Logros;
using Windows_vista.usuarios;

namespace Windows_vista
{
    public partial class Frm_menu_docente : Form
    {
        public Frm_menu_docente(Usuario usuario)
        {
            InitializeComponent();

            labe_nombre_usuario.Text = usuario.Nombres + " " + usuario.Apellidos;
            if (usuario.TipoUsuario == "A")
            {
                label_rol.Text = "Administrador";
            }
            else if (usuario.TipoUsuario == "D")
            {
                label_rol.Text = "Docente";
            }
            else
            {
                label_rol.Text = "Secretaria";
            }
            this.usuario = usuario;
            ValidarContrasena(usuario.EstadoClave);
        }

        Usuario usuario;

        public void ValidarContrasena(String estado)
        {
            if (estado == "S")
            {
                DialogResult response = MessageBox.Show("Usted no ha actualizado su contraseña, ¿ Desea cambiarla ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == System.Windows.Forms.DialogResult.Yes)
                {
                    Frm_actualizar_mi_perfil frm_mi_perfil = new Frm_actualizar_mi_perfil(usuario);
                    frm_mi_perfil.Show();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Frm_inicio_sesion frm_inicio_sesion = new Frm_inicio_sesion();
            frm_inicio_sesion.Show();
            this.Close();
        }

        private void Btn_logros_Click(object sender, EventArgs e)
        {
            Frm_admin_logros frm_admin_logros = new Frm_admin_logros(usuario);
            frm_admin_logros.Show();
            this.Close();
        }

    }
}
