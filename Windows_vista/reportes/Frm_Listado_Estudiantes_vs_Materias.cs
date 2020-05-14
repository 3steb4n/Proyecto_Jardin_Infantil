using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entidades;
using Negocio;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace Windows_vista.reportes
{
    public partial class Frm_Listado_Estudiantes_vs_Materias : Form
    {
        public Frm_Listado_Estudiantes_vs_Materias()
        {
            InitializeComponent();
            CargarDatos();
            dgv_ListarEstudiantePorGrupo.ClearSelection();
            dgv_ListarEstudiantePorGrupo.CurrentCell = null;
            this.usuario = usuario;
        }
        List<Matricula> lista = null;
        List<Grupo> lista_grupo = null;
        BLMatricula blmatricula = new BLMatricula();
        BLGrupo blgrupo = new BLGrupo();

        Usuario usuario;
        public void CargarDatos()
        {
            lista = blmatricula.ListarReporteEstudiante();
            dgv_ListarEstudiantePorGrupo.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[0].estudiante.Id_estudiante != 0)
                {
                    dgv_ListarEstudiantePorGrupo.Rows.Add(

                        lista[i].estudiante.Id_estudiante,
                        lista[i].estudiante.DocumentoEstudiante,
                        lista[i].estudiante.TipoDocumento,
                        lista[i].estudiante.NombreEstudiante,
                        lista[i].estudiante.ApellidoEstudiante,
                        lista[i].estudiante.FechaNacimiento,
                        lista[i].estudiante.NombreAcudiente,
                        lista[i].estudiante.Direccion,
                        lista[i].estudiante.Genero,
                        lista[i].estudiante.TelefonoAcudiente,
                        lista[i].estudiante.CelularAcudiente,
                        lista[i].estudiante.CorreoElectronicoAcudiente,
                        lista[i].estudiante.ObservacionesEstudiante,
                        lista[i].estudiante.EstadoEstudiante,
                        lista[i].grupo.NombreGrupo,
                        lista[i].grupo.IdGrupo,
                        lista[i].estudiante.Ruta_foto
                    );
                }
            }
        }
            private void Frm_Listado_Estudiantes_vs_Materias_Load(object sender, EventArgs e)
        {

        }
    }
}
