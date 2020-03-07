using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_inicio_Sesion : Form
    {
        public Frm_inicio_Sesion()
        {
            InitializeComponent();
        }
        int viewpass2;

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_menu_admin frm_admin = new Frm_menu_admin();
            frm_admin.Show();
            this.Hide();
        }

        private void viewPass_Click(object sender, EventArgs e)
        {

            if (viewpass2 >= 1)
            {
                viewPass.Image = Properties.Resources.view;
                Txt_clave.PasswordChar = '*';
                viewpass2 = 0;
            }
            else
            {
                viewPass.Image = Properties.Resources.noView;
                Txt_clave.PasswordChar = '\0';
                viewpass2 += 1;

            }
        }
    }
}
