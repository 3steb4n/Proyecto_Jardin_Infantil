using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista.Logros
{
    public partial class Frm_crear_logro : Form
    {
        public Frm_crear_logro(Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            CargarDatos();
            this.usuario = usuario;
        }

        List<Materiaa> lista_materia = null;
        BLLogro blLogro = new BLLogro();
        BLMateria blMateria = new BLMateria();
        Usuario usuario;

        private void CargarDatos()
        {
            // se llena el selector de area
            lista_materia = blMateria.ListarIdNombre();
            ComboboxItem item_materia1 = new ComboboxItem(); item_materia1.Text = "Seleccione..."; item_materia1.Value = "";
            ComboboxItem item_materia;
            Object[] items_materias = new Object[lista_materia.Count];
            for (int i = 0; i < lista_materia.Count; i++)
            {
                items_materias[i] = item_materia = new ComboboxItem(); item_materia.Text = lista_materia[i].NombreMateria; item_materia.Value = lista_materia[i].IdMateria;
            }
            combo_materia.Items.Add(item_materia1);
            combo_materia.Items.AddRange(items_materias);
            combo_materia.SelectedIndex = 0;

        }

        private void btn_guardar_Click(object sender, System.EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Logro logro = new Logro();

                guardar(logro);

            }
        }

        private void guardar(Logro logro)
        {
            DateTime fechaActual = DateTime.Today;

            logro.NombreLogro = Txt_nombre.Text;
            logro.DescripcionLogro = Txt_descripcion.Text;
            logro.UsuarioCreacion = "1";
            logro.FechaCreacion = fechaActual;
            logro.Materia.IdMateria = int.Parse((combo_materia.SelectedItem as ComboboxItem).Value.ToString());


            bool bandera = blLogro.InsertarLogro(logro);

            if (bandera)
            {
                MessageBox.Show("Logro creada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_crear_logro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_logros frm_admin_logros = new Frm_admin_logros(usuario);
            frm_admin_logros.Show();
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
                errorMateria.SetError(combo_materia, "Seleccione la materia");
                combo_materia.Focus();
            }
            else
            {
                errorMateria.Clear();
            }
        }
    }
}
