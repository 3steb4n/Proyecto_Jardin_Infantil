using System;
using Entidades;
using Negocio;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows_vista.docentes;
using Windows_vista.pagos;
using Windows_vista.estudiantes;

namespace Windows_vista.estudiantes
{
    public partial class Frm_administracion__matriculas : Form
    {
        public Frm_administracion__matriculas()
        {
            InitializeComponent();
            CargarDatos();
            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null; 
        }

        List<Matricula> lista = null;
        List<Grupo> lista_grupo = null;

        BLMatricula blmatricula = new BLMatricula();
        BLGrupo blgrupo = new BLGrupo();

        public void CargarDatos()
        {
            lista = blmatricula.ListarMatricula();
            dgv_estudiantes.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[0].Id_matricula != 0)
                {
                    dgv_estudiantes.Rows.Add(

                        lista[i].Id_matricula,
                        lista[i].Numeromatricula,
                        lista[i].Anoreguistro,
                        lista[i].Estadomatricula,
                        lista[i].estudiante.Id_estudiante,
                        lista[i].estudiante.NombreEstudiante,
                        lista[i].estudiante.DocumentoEstudiante,
                        lista[i].grupo.IdGrupo,
                        lista[i].grupo.NombreGrupo
                    );
                }
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;

            lista_grupo = blgrupo.ListarGruposNombreyID();
            combo_grupo.DataSource = lista_grupo;
            combo_grupo.DisplayMember = "NombreGrupo";
            combo_grupo.ValueMember = "IdGrupo";

            combo_grupo.SelectedItem = "Seleccione...";


        }

        public void CargarDatoFiltroDocumento(String documento)
        {
            List<Matricula> matriculas = new List<Matricula>();
            matriculas = blmatricula.ListarMatriculaporDocumento(documento);
            dgv_estudiantes.Rows.Clear();

            for (int i = 0; i < matriculas.Count; i++)
            {
                if (matriculas[0].Id_matricula != 0)
                {
                    dgv_estudiantes.Rows.Add(

                        matriculas[i].Id_matricula,
                        matriculas[i].Numeromatricula,
                        matriculas[i].Anoreguistro,
                        matriculas[i].Estadomatricula,
                        matriculas[i].estudiante.Id_estudiante,
                        matriculas[i].estudiante.NombreEstudiante,
                        matriculas[i].estudiante.DocumentoEstudiante,
                        matriculas[i].grupo.IdGrupo,
                        matriculas[i].grupo.NombreGrupo
                    );
                }
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }

        public void CargarDatoFiltroDocumentoGrupo(String documento, int idgrupo)
        {
            List<Matricula> matriculas = new List<Matricula>();
            matriculas = blmatricula.ListarMatriculasPorDocumentoyGrupo(documento, idgrupo);
            dgv_estudiantes.Rows.Clear();

            for (int i = 0; i < matriculas.Count; i++)
            {
                if (matriculas[0].Id_matricula != 0)
                {
                    dgv_estudiantes.Rows.Add(

                        matriculas[i].Id_matricula,
                        matriculas[i].Numeromatricula,
                        matriculas[i].Anoreguistro,
                        matriculas[i].Estadomatricula,
                        matriculas[i].estudiante.Id_estudiante,
                        matriculas[i].estudiante.NombreEstudiante,
                        matriculas[i].estudiante.DocumentoEstudiante,
                        matriculas[i].grupo.IdGrupo,
                        matriculas[i].grupo.NombreGrupo
                    );
                }
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }
        public void CargarDatoFiltroGrupo(int idgrupo)
        {
            List<Matricula> matriculas = new List<Matricula>();
            matriculas = blmatricula.ListarMatriculasPorGrupo(idgrupo);
            dgv_estudiantes.Rows.Clear();

            for (int i = 0; i < matriculas.Count; i++)
            {
                if (matriculas[0].Id_matricula != 0)
                {
                    dgv_estudiantes.Rows.Add(

                        matriculas[i].Id_matricula,
                        matriculas[i].Numeromatricula,
                        matriculas[i].Anoreguistro,
                        matriculas[i].Estadomatricula,
                        matriculas[i].estudiante.Id_estudiante,
                        matriculas[i].estudiante.NombreEstudiante,
                        matriculas[i].estudiante.DocumentoEstudiante,
                        matriculas[i].grupo.IdGrupo,
                        matriculas[i].grupo.NombreGrupo
                    );
                }
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }

        public int Nombreporid(String nombre)
        {
            int value = 0;
            //lista = blmatricula.ListaridyNombre();
            for (int i = 0; i < lista_grupo.Count; i++)
            {
                if (lista_grupo[i].NombreGrupo == nombre)
                {
                    value = lista_grupo[i].IdGrupo;
                }
            }
            if (value == 1)
            {
                value = 1;
            }
            else
            {
                value = 2;
            }
            return value;
        }

        private void Frm_administracion__matriculas_Load(object sender, EventArgs e)
        {

        }

        private void combo_grupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Txt_busquedaCedula.Text == "" && combo_grupo.Text == "Seleccione...")
            {
                CargarDatos();
            }
            else if (Txt_busquedaCedula.Text != "" && combo_grupo.Text == "Seleccione...")
            {
                CargarDatoFiltroDocumento(Txt_busquedaCedula.Text);
            }
            else if(Txt_busquedaCedula.Text == "" && combo_grupo.Text != "Seleccione...")
            {
                CargarDatoFiltroGrupo(Nombreporid((combo_grupo.Text)));
            }
            else
            {
                CargarDatoFiltroDocumentoGrupo(Txt_busquedaCedula.Text, Nombreporid(combo_grupo.Text));
            }
        }

        private void Txt_busquedaCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
