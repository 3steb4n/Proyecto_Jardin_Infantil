using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista.Materia
{
    public partial class Frm_modificar_materia : Form
    {
        public Frm_modificar_materia(Materias materia)
        {
            InitializeComponent();
            cargarDatos(materia);
            id_materia = materia.IdMateria;
        }

        int id_materia;
        BLMateria blMateria = new BLMateria();
        BLArea blArea = new BLArea();
        BLGrado blGrado = new BLGrado();
        List<Area> listaArea = null;
        List<Grado> listaGrado = null;
        Materias materia;

        public void cargarDatos(Materias materia)
        {
            // se llena el selector de area
            listaArea = blArea.ListarAreas();

            for (int i = 0; i < listaArea.Count; i++)
            {
                Combo_area.Items.Add(listaArea[i].NombreArea).ToString();
            }
            Combo_area.SelectedItem = materia.Area.NombreArea;

            // se llena el selector de grado

            listaGrado = blGrado.ListarGados();

            for (int i = 0; i < listaGrado.Count; i++)
            {
                combo_grado.Items.Add(listaGrado[i].NombreGrado).ToString();
            }
            combo_grado.SelectedItem = materia.Grado.NombreGrado;

            TxtMateria.Text = materia.NombreMateria;
            Txt_horas.Text = materia.NumeroHorasMaterias.ToString();
            Txt_descripcion.Text = materia.DescripcionMateria;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_modificar_materia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_materia frm_materia = new Frm_admin_materia();
            frm_materia.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Materias materia = new Materias();
            DateTime fechaActual = DateTime.Today;

            materia.IdMateria = id_materia;
            materia.NombreMateria = TxtMateria.Text;
            materia.NumeroHorasMaterias = int.Parse(Txt_horas.Text);
            materia.DescripcionMateria = Txt_descripcion.Text;
            materia.UsuarioModificacion = "1";
            materia.FechaModificacion = fechaActual;
            materia.Area.IdArea = IDPorArea(Combo_area.Text);
            materia.Grado.IdGrado = IDPorGrado(combo_grado.Text);

            bool flag = blMateria.ModificarMateria(materia);
            if (flag)
            {
                MessageBox.Show("Materia modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int IDPorArea(String nombre)
        {
            int value = 0;

            for (int i = 0; i < listaArea.Count; i++)
            {
                if (listaArea[i].NombreArea == nombre)
                {
                    value = listaArea[i].IdArea;
                }
            }

            return value;
        }

        public int IDPorGrado(String nombre)
        {
            int value = 0;

            for (int i = 0; i < listaGrado.Count; i++)
            {
                if (listaGrado[i].NombreGrado == nombre)
                {
                    value = listaGrado[i].IdGrado;
                }
            }

            return value;
        }
    }
}
