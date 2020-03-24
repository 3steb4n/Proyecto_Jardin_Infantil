using Entidades;
using Negocio;
using System;
using System.Windows.Forms;
using Windows_vista.reportes;
using Windows_vista.usuarios;

namespace Windows_vista.reportes
{
    public partial class Frm_reporte_admin : Form
    {
        public Frm_reporte_admin(Usuario usuario)
        {
            InitializeComponent();
            labe_nombre_usuario.Text = usuario.Nombres + " " + usuario.Apellidos;
            if (usuario.TipoUsuario == "A")
            {
                label_rol.Text = "Administrador";
            }
            this.usuario = usuario;
        }

        Usuario usuario;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstudiantesGrupos_Click(object sender, System.EventArgs e)
        {
            Frm_Listado_Estudiantes_vs_Grupos frm = new Frm_Listado_Estudiantes_vs_Grupos(usuario);
            frm.Show();
            this.Close();
        }

        private void labe_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_menu_admin frm = new Frm_menu_admin(usuario);
            frm.Show();
            this.Close();
        }

        private void Frm_reporte_admin_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
