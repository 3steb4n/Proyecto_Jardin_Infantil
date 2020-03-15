using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_modificar_grupo : Form
    {
        public Frm_modificar_grupo(Grupo grupo, Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            CargarDatos(grupo);
            id_grupo = grupo.IdGrupo;
            this.usuario = usuario;
        }

        int id_grupo;
        List<Grado> lista = null;
        List<Usuario> lista_usuario = null;
        BLGrupo blGrupo = new BLGrupo();
        BLGrado blGrado = new BLGrado();
        BLUsuario blUsuario = new BLUsuario();
        Usuario usuario;

        public void CargarDatos(Grupo grupo)
        {
            lista = blGrado.ListarGados();

            for (int i = 0; i < lista.Count; i++)
            {
                Combo_grado.Items.Add(lista[i].NombreGrado).ToString();
            }

            // se llenan valores fijos del estado
            Combo_estado_grupo.Items.Add("Activo").ToString();
            Combo_estado_grupo.Items.Add("Inactivo").ToString();
            Combo_estado_grupo.SelectedItem = grupo.EstadoGrupo;

            lista_usuario = blUsuario.ListarIDyNombres();

            for (int i = 0; i < lista_usuario.Count; i++)
            {
                combo_docente.Items.Add(lista_usuario[i].Nombres + " " + lista_usuario[i].Apellidos).ToString();
            }

            // se llenan valores fijos del estado
            Combo_estado_grupo.Items.Add("Activo").ToString();
            Combo_estado_grupo.Items.Add("Inactivo").ToString();
            Combo_estado_grupo.SelectedItem = grupo.EstadoGrupo;



            Txt_nombre_grupo.Text = grupo.NombreGrupo;
            Txt_descripcion.Text = grupo.DescripcionGrupo;
            Combo_grado.SelectedItem = grupo.Grado.NombreGrado;
            combo_docente.SelectedItem = grupo.usuario.Nombres + " " + grupo.usuario.Apellidos;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Grupo grupo = new Grupo();
                DateTime fechaActual = DateTime.Today;
                grupo.IdGrupo = id_grupo;
                grupo.NombreGrupo = Txt_nombre_grupo.Text;
                grupo.DescripcionGrupo = Txt_descripcion.Text;
                grupo.EstadoGrupo = ordenarEstado(Combo_estado_grupo.Text);
                grupo.UsuarioModificacion = "1";
                grupo.FechaModificacion = fechaActual;
                grupo.Grado.IdGrado = IDPorNombre(Combo_grado.Text);
                grupo.usuario.Id_usuario = IDPorUsuario(combo_docente.Text);

                bool flag = blGrupo.ModificarGrupo(grupo);
                if (flag)
                {
                    MessageBox.Show("Usuario modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Frm_modificar_grupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_grupos frm_admin_grupos = new Frm_administracion_grupos(usuario);
            frm_admin_grupos.Show();
        }

        public int IDPorNombre(String nombre)
        {
            int value = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].NombreGrado == nombre)
                {
                    value = lista[i].IdGrado;
                }
            }

            return value;
        }

        public int IDPorUsuario(String nombre)
        {
            int value = 0;

            for (int i = 0; i < lista_usuario.Count; i++)
            {
                if (lista_usuario[i].Nombres + " " + lista_usuario[i].Apellidos == nombre)
                {
                    value = lista_usuario[i].Id_usuario;
                }
            }

            return value;
        }

        public String ordenarEstado(String estado)
        {
            String value;
            if (estado == "Activo")
            {
                value = "A";
            }
            else
            {
                value = "I";
            }
            return value;
        }

        private void Txt_nombre_grupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_nombre_grupo.Text == "")
            {
                e.Cancel = true;
                errorNombre.SetError(Txt_nombre_grupo, "Ingrese nombre del grupo");
                Txt_nombre_grupo.Focus();
            }
            else
            {
                errorNombre.Clear();
            }
        }

        private void combo_docente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_docente.Text == "")
            {
                e.Cancel = true;
                errorDocente.SetError(combo_docente, "Seleccione docente");
                combo_docente.Focus();
            }
            else
            {
                errorDocente.Clear();
            }
        }

        private void Txt_descripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_descripcion.Text == "")
            {
                e.Cancel = true;
                errorDescripcion.SetError(Txt_descripcion, "Seleccione docente");
                Txt_descripcion.Focus();
            }
            else
            {
                errorDescripcion.Clear();
            }
        }

        private void Combo_estado_grupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_estado_grupo.Text == "")
            {
                e.Cancel = true;
                errorEstadoGrupo.SetError(Combo_estado_grupo, "Seleccione estado del grupo");
                Combo_estado_grupo.Focus();
            }
            else
            {
                errorEstadoGrupo.Clear();
            }
        }

        private void Combo_grado_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_grado.Text == "")
            {
                e.Cancel = true;
                errorGrado.SetError(Combo_grado, "Seleccione estado del grupo");
                Combo_grado.Focus();
            }
            else
            {
                errorGrado.Clear();
            }
        }
    }
}
