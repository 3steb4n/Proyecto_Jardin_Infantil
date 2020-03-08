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
            } else if (usuario.TipoUsuario == "D")
            {
                label_rol.Text = "Docente";
            } else
            {
                label_rol.Text = "Secretaria";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_menu_docente_Load(object sender, EventArgs e)
        {

        }

        private void labe_nombre_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
