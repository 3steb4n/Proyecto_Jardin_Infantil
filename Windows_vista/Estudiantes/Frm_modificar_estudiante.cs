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
    public partial class Frm_modificar_estudiante : Form
    {
        public Frm_modificar_estudiante()
        {
            InitializeComponent();
        }

        private void Frm_modificar_estudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes();
            frm_admin_estudiantes.Show();
        }
    }
}
