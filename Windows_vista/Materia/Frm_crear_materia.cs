using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista.Materia
{
    public partial class Frm_crear_materia : Form
    {
        public Frm_crear_materia(Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            CargarDatos();
            this.usuario = usuario;
        }

        List<Area> lista_area = null;
        List<Grado> lista_grado = null;
        BLArea blArea = new BLArea();
        BLGrado blGrado = new BLGrado();
        BLMateria blMateria = new BLMateria();
        Usuario usuario;

        private void CargarDatos()
        {
            // se llena el selector de area
            lista_area = blArea.ListarAreas();
            ComboboxItem item_area1 = new ComboboxItem(); item_area1.Text = "Seleccione..."; item_area1.Value = "";
            ComboboxItem item_area;
            Object[] items_area = new Object[lista_area.Count];
            for (int i = 0; i < lista_area.Count; i++)
            {
                items_area[i] = item_area = new ComboboxItem(); item_area.Text = lista_area[i].NombreArea; item_area.Value = lista_area[i].IdArea;
            }
            Combo_area.Items.Add(item_area1);
            Combo_area.Items.AddRange(items_area);
            Combo_area.SelectedIndex = 0;


            // se llena el selector de grado
            lista_grado = blGrado.ListarGados();
            ComboboxItem item_grado1 = new ComboboxItem(); item_grado1.Text = "Seleccione..."; item_grado1.Value = "";
            ComboboxItem item_grado;
            Object[] items_grado = new Object[lista_area.Count];
            for (int i = 0; i < lista_area.Count; i++)
            {
                items_grado[i] = item_grado = new ComboboxItem(); item_grado.Text = lista_grado[i].NombreGrado; item_grado.Value = lista_grado[i].IdGrado;
            }
            combo_grado.Items.Add(item_grado1);
            combo_grado.Items.AddRange(items_grado);
            combo_grado.SelectedIndex = 0;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Materiaa materia = new Materiaa();

                guardar(materia);
            }
        }

        private void guardar(Materiaa materia)
        {
            DateTime fechaActual = DateTime.Today;

            materia.NombreMateria = Txt_materia.Text;
            materia.DescripcionMateria = Txt_descripcion.Text;
            materia.UsuarioCreacion = "1";
            materia.FechaCreacion = fechaActual;
            materia.EstadoMateria = "A";
            materia.NumeroHorasMaterias = int.Parse(Txt_numeroHoras.Text);
            materia.Area.IdArea = int.Parse((Combo_area.SelectedItem as ComboboxItem).Value.ToString());
            materia.Grado.IdGrado = int.Parse((combo_grado.SelectedItem as ComboboxItem).Value.ToString());

            bool bandera = blMateria.InsertarMateria(materia);

            if (bandera)
            {
                MessageBox.Show("Materia creada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_crear_materia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_materia frm_admin_materia = new Frm_admin_materia(usuario);
            frm_admin_materia.Show();
        }

        private void Txt_materia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_materia.Text == "")
            {
                e.Cancel = true;
                errorMateria.SetError(Txt_materia, "Ingrese nombre de materia");
                Txt_materia.Focus();
            }
            else
            {
                errorMateria.Clear();
            }
        }

        private void Txt_numeroHoras_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_numeroHoras.Text == "" || Txt_numeroHoras.Text == "0")
            {
                e.Cancel = true;
                errorNumHoras.SetError(Txt_numeroHoras, "Ingrese el numero de horas");
                Txt_numeroHoras.Focus();
            }
            else if (!Regex.IsMatch(Txt_numeroHoras.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorNumHoras.SetError(Txt_numeroHoras, "Solo numeros");
                Txt_numeroHoras.Focus();
            }
            else
            {
                errorNumHoras.Clear();
            }
        }

        private void Txt_descripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_descripcion.Text == "")
            {
                e.Cancel = true;
                errorDescripcion.SetError(Txt_descripcion, "Ingrese la descripción");
                Txt_descripcion.Focus();
            }
            else
            {
                errorDescripcion.Clear();
            }
        }

        private void Combo_area_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_area.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorArea.SetError(Combo_area, "Seleccione el area de la materia");
                Combo_area.Focus();
            }
            else
            {
                errorArea.Clear();
            }
        }

        private void combo_grado_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_grado.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorGrado.SetError(combo_grado, "Seleccione el grado de la materia");
                combo_grado.Focus();
            }
            else
            {
                errorGrado.Clear();
            }
        }
    }
}
