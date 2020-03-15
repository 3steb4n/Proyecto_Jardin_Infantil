using Entidades;
using System;
using System.Windows.Forms;
using Windows_vista.Logros;
using Windows_vista.Materia;
using Windows_vista.usuarios;

namespace Windows_vista
{
    public partial class Frm_menu_admin : Form
    {
        public Frm_menu_admin(Usuario usuario)
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
        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_administracion_usuarios frm_admin_usuarios = new Frm_administracion_usuarios(usuario);
            frm_admin_usuarios.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuario);
            frm_admin_estudiantes.Show();
            this.Close();
        }

        private void Btn_materias_Click(object sender, EventArgs e)
        {
            Frm_admin_materia frm = new Frm_admin_materia(usuario);
            frm.Show();
            this.Close();
        }

        private void Btn_logros_Click(object sender, EventArgs e)
        {
            Frm_admin_logros frm = new Frm_admin_logros(usuario);
            frm.Show();
            this.Close();
        }

        private void BtnGrupos_Click(object sender, EventArgs e)
        {
            Frm_administracion_grupos frm_admin_grupos = new Frm_administracion_grupos(usuario);
            frm_admin_grupos.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Frm_inicio_sesion frm = new Frm_inicio_sesion();
            frm.Show();
            this.Close();
        }

    }
}
