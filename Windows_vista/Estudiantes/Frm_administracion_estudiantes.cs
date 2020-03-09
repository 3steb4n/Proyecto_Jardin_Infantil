using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Windows_vista
{
    public partial class Frm_administracion_estudiantes : Form
    {
        public Frm_administracion_estudiantes()
        {
            InitializeComponent();
            CargarDatos();
            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }


        List<Estudiante> lista = null;

        BLEstudiante blestudiante = new BLEstudiante();
        Estudiante estudiante;

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Frm_crear_estudiante frm_crear_estudiante = new Frm_crear_estudiante();
            frm_crear_estudiante.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_modificar_estudiante frm_modificar_estudiante = new Frm_modificar_estudiante();
            frm_modificar_estudiante.Show();
            this.Close();
        }

        private void Frm_administracion_estudiantes_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatos()
        {
            lista = blestudiante.ListarEstudiante();
            dgv_estudiantes.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgv_estudiantes.Rows.Add(

                    lista[i].Id_estudiante,
                    lista[i].DocumentoEstudiante,
                    lista[i].TipoDocumento,
                    lista[i].NombreEstudiante,
                    lista[i].ApellidoEstudiante,
                    lista[i].FechaNacimiento,
                    lista[i].NombreAcudiente,
                    lista[i].Direccion,
                    lista[i].Genero,
                    lista[i].TelefonoAcudiente,
                    lista[i].CelularAcudiente,
                    lista[i].CorreoElectronicoAcudiente,
                    lista[i].ObservacionesEstudiante,
                    lista[i].EstadoEstudiante,
                    lista[i].grupo.NombreGrupo,
                    lista[i].grupo.IdGrupo
                );
                ;
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }

        private void dgv_estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Txt_busquedaCedula.Text == "")
            {
                CargarDatos();
            }
            else
            {
                CargarDatoFiltro(Txt_busquedaCedula.Text);
            }
        }

        public void CargarDatoFiltro(String documento)
        {
            Estudiante estudiante = new Estudiante();
            estudiante = blestudiante.ListarEstudiantePorDocumento(documento);
            dgv_estudiantes.Rows.Clear();

            dgv_estudiantes.Rows.Add(

                estudiante.Id_estudiante,
                estudiante.DocumentoEstudiante,
                estudiante.TipoDocumento,
                estudiante.NombreEstudiante,
                estudiante.ApellidoEstudiante,
                estudiante.FechaNacimiento,
                estudiante.NombreAcudiente,
                estudiante.Direccion,
                estudiante.Genero,
                estudiante.TelefonoAcudiente,
                estudiante.CelularAcudiente,
                estudiante.CorreoElectronicoAcudiente,
                estudiante.ObservacionesEstudiante,
                estudiante.EstadoEstudiante,
                estudiante.grupo.NombreGrupo,
                estudiante.grupo.IdGrupo
            );

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }

    }

}
