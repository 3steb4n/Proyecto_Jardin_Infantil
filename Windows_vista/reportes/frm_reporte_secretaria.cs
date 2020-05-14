using Entidades;
using Negocio;
using System;
using System.Windows.Forms;
using Windows_vista.reportes;
using Windows_vista.usuarios;
namespace Windows_vista.reportes
{
    public partial class frm_reporte_secretaria : Form
    {
        public frm_reporte_secretaria(Usuario usuario)
        {
            InitializeComponent();
            labe_nombre_usuario.Text = usuario.Nombres + " " + usuario.Apellidos;
            if (usuario.TipoUsuario == "A")
            {
                label_rol.Text = "Secretaria";
            }
            this.usuario = usuario;
        }
        Usuario usuario;

        private void Volver_Click(object sender, System.EventArgs e)
        {
            Frm_menu_secretaria frm = new Frm_menu_secretaria(usuario);
            frm.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Listar_EstudiantevsGrupo_Click(object sender, EventArgs e)
        {
            Frm_Listado_Estudiantes_vs_Grupos frm = new Frm_Listado_Estudiantes_vs_Grupos(usuario);
            frm.Show();
            this.Close();
        }

        private void frm_reporte_secretaria_Load(object sender, EventArgs e)
        {

        }
    }
}
