using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_crear_grupo : Form
    {
        public Frm_crear_grupo(Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            CargarDatos();
            this.usuario = usuario;
        }

        List<Grado> lista = null;
        List<Usuario> lista_usuario = null;
        BLUsuario blUsuario = new BLUsuario();
        BLGrupo blGrupo = new BLGrupo();
        BLGrado blGrado = new BLGrado();
        Usuario usuario;

        private void CargarDatos()
        {

            // se llenan valores fijos del estado
            ComboboxItem item_td1 = new ComboboxItem(); item_td1.Text = "Seleccione..."; item_td1.Value = "";
            ComboboxItem item_td2 = new ComboboxItem(); item_td2.Text = "Activo..."; item_td2.Value = "A";
            ComboboxItem item_td3 = new ComboboxItem(); item_td3.Text = "Inactivo..."; item_td3.Value = "I";
            Object[] items_td = new Object[3];
            items_td[0] = item_td1;
            items_td[1] = item_td2;
            items_td[2] = item_td3;
            Combo_estado_grupo.Items.AddRange(items_td);
            Combo_estado_grupo.SelectedIndex = 0;


            // se llenan valores del selector de grado

            lista = blGrado.ListarGados();
            ComboboxItem item_gr1 = new ComboboxItem(); item_gr1.Text = "Seleccione..."; item_gr1.Value = "";
            ComboboxItem item;
            Object[] item_gr = new Object[lista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                item_gr[i] = item = new ComboboxItem(); item.Text = lista[i].NombreGrado; item.Value = lista[i].IdGrado;
            }
            Combo_grado.Items.Add(item_gr1);
            Combo_grado.Items.AddRange(item_gr);
            Combo_grado.SelectedIndex = 0;

            // se llenan valores del selector docente
            lista_usuario = blUsuario.ListarIDyNombres();
            ComboboxItem item_dc1 = new ComboboxItem(); item_dc1.Text = "Seleccione..."; item_dc1.Value = "";
            ComboboxItem itemdc;
            Object[] items_dc = new Object[lista_usuario.Count];
            for (int i = 0; i < lista_usuario.Count; i++)
            {
                items_dc[i] = itemdc = new ComboboxItem(); itemdc.Text = lista_usuario[i].Nombres + " " + lista_usuario[i].Apellidos; itemdc.Value = lista_usuario[i].Id_usuario;
            }
            combo_docente.Items.Add(item_dc1);
            combo_docente.Items.AddRange(items_dc);
            combo_docente.SelectedIndex = 0;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Grupo grupo = new Grupo();

                guardar(grupo);

            }
        }

        private void guardar(Grupo grupo)
        {
            DateTime fechaActual = DateTime.Today;

            grupo.NombreGrupo = Txt_nombre_grupo.Text;
            grupo.DescripcionGrupo = Txt_descripciongrupo.Text;
            grupo.UsuarioCreacion = "1";
            grupo.FechaCreacion = fechaActual;
            grupo.EstadoGrupo = (Combo_estado_grupo.SelectedItem as ComboboxItem).Value.ToString(); ;
            grupo.Grado.IdGrado = int.Parse((Combo_grado.SelectedItem as ComboboxItem).Value.ToString());
            grupo.usuario.Id_usuario = int.Parse((combo_docente.SelectedItem as ComboboxItem).Value.ToString());

            bool bandera = blGrupo.InsertarGrupo(grupo);

            if (bandera)
            {
                MessageBox.Show("Grupo creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_crear_grupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_grupos admin_grupos = new Frm_administracion_grupos(usuario);
            admin_grupos.Show();
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

        private void Txt_descripciongrupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_descripciongrupo.Text == "")
            {
                e.Cancel = true;
                errorDescripcion.SetError(Txt_descripciongrupo, "Ingrese la descripción del grupo");
                Txt_descripciongrupo.Focus();
            }
            else
            {
                errorDescripcion.Clear();
            }
        }

        private void combo_docente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_docente.Text == "Seleccione...")
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

        private void Combo_estado_grupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_estado_grupo.Text == "Seleccione...")
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
            if (Combo_grado.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorGrado.SetError(Combo_grado, "Seleccione el grado");
                Combo_grado.Focus();
            }
            else
            {
                errorGrado.Clear();
            }
        }

    }
}
