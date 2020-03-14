using Entidades;
using System;
using System.Windows.Forms;
using Windows_vista.Logros;

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
        }

        Usuario usuario;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_menu_docente_Load(object sender, EventArgs e)
        {

        }

        private void labe_nombre_usuario_Click(object sender, EventArgs e)
        {

        }

        private void Frm_menu_docente_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void btn_notas_Click(object sender, EventArgs e)
        {

        }
    }
}
