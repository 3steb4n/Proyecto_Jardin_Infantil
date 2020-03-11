using Entidades;
using Negocio;
using System;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_inicio_sesion : Form
    {
        public Frm_inicio_sesion()
        {
            InitializeComponent();
        }

        bool mostrarICono;

        BLUsuario blUsuario = new BLUsuario();
        Usuario usuario;

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {

            if (Txt_usuario.Text == "" || Txt_clave.Text == "")
            {
                Label_Error.Text = "Ingrese usuario y contraseña";
            }
            else
            {
                usuario = blUsuario.IniciarSesion(Txt_usuario.Text, Txt_clave.Text);
                if (usuario.Id_usuario != 0)
                {
                    if (usuario.EstadoUsuario == "A")
                    {
                        if (usuario.TipoUsuario == "D")
                        {
                            Frm_menu_docente frm_docente = new Frm_menu_docente(usuario);
                            frm_docente.Show();
                            this.Hide();
                        }
                        else if (usuario.TipoUsuario == "A")
                        {
                            Frm_menu_admin frm_admin = new Frm_menu_admin(usuario);
                            frm_admin.Show();
                            this.Hide();
                        }
                        else if (usuario.TipoUsuario == "S")
                        {
                            Frm_menu_secretaria frm_secretaria = new Frm_menu_secretaria(usuario);
                            frm_secretaria.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        Label_Error.Text = "Su usuario se encuentra inactivo";
                    }
                }
                else
                {
                    Label_Error.Text = "Usuario inexistente en el sistema";
                }
            }



        }

        private void viewPass_Click(object sender, EventArgs e)
        {

            if (mostrarICono == true)
            {
                viewPass.Image = Properties.Resources.view;
                Txt_clave.PasswordChar = '*';
                mostrarICono = false;
            }
            else
            {
                viewPass.Image = Properties.Resources.noView;
                Txt_clave.PasswordChar = '\0';
                mostrarICono = true;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
