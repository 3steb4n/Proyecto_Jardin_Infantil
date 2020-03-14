using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista.Materia
{
    public partial class Frm_crear_materia : Form
    {
        public Frm_crear_materia(Usuario usuario)
        {
            InitializeComponent();
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
            if (ValidarCampos())
            {
                Materias materia = new Materias();

                guardar(materia);
            }
        }

        private void guardar(Materias materia)
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

        private bool ValidarCampos()
        {

            bool flag = true;
            if (Txt_materia.Text == "")
            {
                errorProvider.SetError(Txt_materia, "Introdusca el nombre de la materia");
                Txt_materia.Focus();
                flag = false;
            }
            if (Txt_numeroHoras.Text == "")
            {
                errorProvider.SetError(Txt_numeroHoras, "Introduca el numero de horas");
                Txt_numeroHoras.Focus();
                flag = false;
            }
            if (Txt_descripcion.Text == "")
            {
                errorProvider.SetError(Txt_descripcion, "Ingrese la descripción");
                Txt_descripcion.Focus();
                flag = false;
            }
            if (Txt_numeroHoras.Text == "")
            {
                errorProvider.SetError(Txt_numeroHoras, "Ingrese apellido");
                Txt_numeroHoras.Focus();
                flag = false;
            }
            if (Combo_area.Text == "")
            {
                errorProvider.SetError(Combo_area, "Seleccione la area");
                Combo_area.Focus();
                flag = false;
            }
            if (combo_grado.Text == "")
            {
                errorProvider.SetError(combo_grado, "Seleccione el grado");
                combo_grado.Focus();
                flag = false;
            }
            return flag;
        }

        private void Frm_crear_materia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_materia frm_admin_materia = new Frm_admin_materia(usuario);
            frm_admin_materia.Show();
        }
    }
}
