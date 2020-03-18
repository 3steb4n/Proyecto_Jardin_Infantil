using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista.Materia
{
    public partial class Frm_modificar_materia : Form
    {
        public Frm_modificar_materia(Materiaa materia, Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            cargarDatos(materia);
            id_materia = materia.IdMateria;
            this.usuario = usuario;
        }

        int id_materia;
        BLMateria blMateria = new BLMateria();
        BLArea blArea = new BLArea();
        BLGrado blGrado = new BLGrado();
        List<Area> listaArea = null;
        List<Grado> listaGrado = null;
        Usuario usuario;

        public void cargarDatos(Materiaa materia)
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

        private void Frm_modificar_materia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_materia frm_materia = new Frm_admin_materia(usuario);
            frm_materia.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {

                Materiaa materia = new Materiaa();
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

        private void TxtMateria_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TxtMateria.Text == "")
            {
                e.Cancel = true;
                errorMateria.SetError(TxtMateria, "Ingrese nombre de materia");
                TxtMateria.Focus();
            }
            else
            {
                errorMateria.Clear();
            }
        }

        private void Txt_horas_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_horas.Text == "" || Txt_horas.Text == "0")
            {
                e.Cancel = true;
                errorNumHoras.SetError(Txt_horas, "Ingrese el numero de telefono");
                Txt_horas.Focus();
            }
            else if (!Regex.IsMatch(Txt_horas.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorNumHoras.SetError(Txt_horas, "Solo numeros");
                Txt_horas.Focus();
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
                errorDescripcion.SetError(Combo_area, "Seleccione el area");
                Combo_area.Focus();
            }
            else
            {
                errorDescripcion.Clear();
            }
        }

        private void combo_grado_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_grado.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorGrado.SetError(combo_grado, "Seleccione el grado");
                combo_grado.Focus();
            }
            else
            {
                errorGrado.Clear();
            }
        }
    }
}
