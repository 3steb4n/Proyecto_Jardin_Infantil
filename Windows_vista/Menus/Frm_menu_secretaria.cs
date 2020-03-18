using Entidades;
using System;
using System.Windows.Forms;
using Windows_vista.docentes;
using Windows_vista.pagos;
using Windows_vista.usuarios;

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
            ValidarContrasena(usuario.EstadoClave);
        }

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

        Usuario usuario;


        private void button2_Click(object sender, EventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuario);
            frm_admin_estudiantes.Show();
            this.Close();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_admin_docentes frm_admin_docentes = new Frm_admin_docentes(usuario);
            frm_admin_docentes.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_inicio_sesion frm_inicio_sesion = new Frm_inicio_sesion();
            frm_inicio_sesion.Show();
            this.Close();
        }

        private void Btn_pagos_Click(object sender, EventArgs e)
        {
            Frm_admin_pagos frm_admin_pagos = new Frm_admin_pagos(usuario);
            frm_admin_pagos.Show();
            this.Close();
        }
    }
}
