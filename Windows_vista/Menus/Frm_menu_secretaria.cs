using Entidades;
using System;
using System.Windows.Forms;
using Windows_vista.docentes;

namespace Windows_vista
{
    public partial class Frm_menu_secretaria : Form
    {
        public Frm_menu_secretaria(Usuario usuario)
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
        }

        Usuario usuario;

        private void Frm_menu_secretaria_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuario);
            frm_admin_estudiantes.Show();
            this.Close();
        }

        private void Frm_menu_secretaria_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_admin_docentes frm_admin_docentes = new Frm_admin_docentes(usuario);
            frm_admin_docentes.Show();
            this.Close();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Frm_inicio_sesion frm_inicio_sesion = new Frm_inicio_sesion();
            frm_inicio_sesion.Show();
            this.Close();
        }
    }
}
