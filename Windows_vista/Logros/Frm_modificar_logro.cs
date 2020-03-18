using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista.Logros
{
    public partial class Frm_modificar_logro : Form
    {
        public Frm_modificar_logro(Logro logro, Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            cargarDatos(logro);
            id_logro = logro.IdLogro;
            this.usuario = usuario;
        }

        int id_logro;
        List<Materiaa> lista_materia = null;
        BLMateria blMateria = new BLMateria();
        BLLogro blLogro = new BLLogro();
        Usuario usuario;

        public void cargarDatos(Logro logro)
        {
            // se llena el selector de area
            lista_materia = blMateria.ListarIdNombre();

            for (int i = 0; i < lista_materia.Count; i++)
            {
                combo_materia.Items.Add(lista_materia[i].NombreMateria).ToString();
            }

            combo_materia.SelectedItem = logro.Materia.NombreMateria;
            Txt_nombre.Text = logro.NombreLogro;
            Txt_descripcion.Text = logro.DescripcionLogro;

        }
        private void Frm_modificar_logro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_logros frm_admin_logros = new Frm_admin_logros(usuario);
            frm_admin_logros.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Logro logro = new Logro();
                DateTime fechaActual = DateTime.Today;

                logro.IdLogro = id_logro;
                logro.NombreLogro = Txt_nombre.Text;
                logro.DescripcionLogro = Txt_descripcion.Text;
                logro.UsuarioModificacion = "1";
                logro.FechaModificacion = fechaActual;
                logro.Materia.IdMateria = IDPorNombre(combo_materia.Text);

                bool flag = blLogro.ModificarLogro(logro);
                if (flag)
                {
                    MessageBox.Show("Logro modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int IDPorNombre(String nombre)
        {
            int value = 0;

            for (int i = 0; i < lista_materia.Count; i++)
            {
                if (lista_materia[i].NombreMateria == nombre)
                {
                    value = lista_materia[i].IdMateria;
                }
            }

            return value;
        }

        private void Txt_nombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_nombre.Text == "")
            {
                e.Cancel = true;
                errorNombre.SetError(Txt_nombre, "Ingrese el nombre del logro");
                Txt_nombre.Focus();
            }
            else
            {
                errorNombre.Clear();
            }
        }

        private void Txt_descripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_descripcion.Text == "")
            {
                e.Cancel = true;
                errorDescripcion.SetError(Txt_descripcion, "Ingrese la descripción del logro");
                Txt_descripcion.Focus();
            }
            else
            {
                errorDescripcion.Clear();
            }
        }

        private void combo_materia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_materia.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorMateria.SetError(combo_materia, "Ingrese el nombre del logro");
                combo_materia.Focus();
            }
            else
            {
                errorMateria.Clear();
            }
        }
    }
}
