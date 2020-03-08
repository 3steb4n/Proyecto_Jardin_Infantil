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
    public partial class Frm_menu_admin : Form
    {
        public Frm_menu_admin(Usuario usuario)
        {
            InitializeComponent();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_administracion_usuarios frm_admin_usuarios = new Frm_administracion_usuarios();
            frm_admin_usuarios.Show();
            this.Close();
        }
    }
}
