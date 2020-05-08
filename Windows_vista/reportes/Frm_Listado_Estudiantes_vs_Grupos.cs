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
    public partial class Frm_Listado_Estudiantes_vs_Grupos : Form
    {
        public Frm_Listado_Estudiantes_vs_Grupos(Usuario usuario)
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

            dgv_ListarEstudiantePorGrupo.ClearSelection();
            dgv_ListarEstudiantePorGrupo.CurrentCell = null;

            lista_grupo = blgrupo.ListarGruposNombreyID();
            combo_grupo.DataSource = lista_grupo;
            combo_grupo.DisplayMember = "NombreGrupo";
            combo_grupo.ValueMember = "IdGrupo";

            combo_grupo.SelectedItem = "Seleccione...";

        }

        public void CargarDatoFiltroDocumentoGrupo(int idGrupo)
        {
            List<Matricula> matricula = new List<Matricula>();
            matricula = blmatricula.ListarReporteEstudianteGrupo(idGrupo);
            dgv_ListarEstudiantePorGrupo.Rows.Clear();

            for (int i = 0; i < matricula.Count; i++)
            {
                if (matricula[0].estudiante.Id_estudiante != 0)
                {
                    dgv_ListarEstudiantePorGrupo.Rows.Add(

                        matricula[i].estudiante.Id_estudiante,
                        matricula[i].estudiante.DocumentoEstudiante,
                        matricula[i].estudiante.TipoDocumento,
                        matricula[i].estudiante.NombreEstudiante,
                        matricula[i].estudiante.ApellidoEstudiante,
                        matricula[i].estudiante.FechaNacimiento,
                        matricula[i].estudiante.NombreAcudiente,
                        matricula[i].estudiante.Direccion,
                        matricula[i].estudiante.Genero,
                        matricula[i].estudiante.TelefonoAcudiente,
                        matricula[i].estudiante.CelularAcudiente,
                        matricula[i].estudiante.CorreoElectronicoAcudiente,
                        matricula[i].estudiante.ObservacionesEstudiante,
                        matricula[i].estudiante.EstadoEstudiante,
                        matricula[i].grupo.NombreGrupo,
                        matricula[i].grupo.IdGrupo,
                        matricula[i].estudiante.Ruta_foto
                    );
                }
            }

            dgv_ListarEstudiantePorGrupo.ClearSelection();
            dgv_ListarEstudiantePorGrupo.CurrentCell = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Frm_reporte_admin frm = new Frm_reporte_admin(usuario);
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(combo_grupo.Text == "Seleccione...")
            {
                DialogResult response = MessageBox.Show("Por favor Seleccione el Grupo a Exportar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {

                SLDocument sl = new SLDocument() ;
                SLStyle style = new SLStyle();
                style.Font.FontSize = 12;
                style.Font.Bold = true;

                List<Matricula> matricula = new List<Matricula>();
                matricula = blmatricula.ListarReporteEstudianteGrupo(IDPorNombre(combo_grupo.Text));

                int iC = 1;
                foreach (DataGridViewColumn column in dgv_ListarEstudiantePorGrupo.Columns)
                {
                    sl.SetCellValue(1, iC, column.HeaderText.ToString());
                    sl.SetCellStyle(1, iC, style);
                    iC++;
                }

                int iR = 2;
                foreach (var row in matricula)
                {
                    sl.SetCellValue(iR, 2, row.estudiante.DocumentoEstudiante.ToString());
                    sl.SetCellValue(iR, 3, row.estudiante.TipoDocumento.ToString());
                    sl.SetCellValue(iR, 4, row.estudiante.NombreEstudiante.ToString());
                    sl.SetCellValue(iR, 5, row.estudiante.ApellidoEstudiante.ToString());
                    sl.SetCellValue(iR, 6, row.estudiante.FechaNacimiento.ToString());
                    sl.SetCellValue(iR, 7, row.estudiante.NombreAcudiente.ToString());
                    sl.SetCellValue(iR, 8, row.estudiante.Direccion.ToString());
                    sl.SetCellValue(iR, 9, row.estudiante.Genero.ToString());
                    sl.SetCellValue(iR, 10, row.estudiante.TelefonoAcudiente.ToString());
                    sl.SetCellValue(iR, 11, row.estudiante.CelularAcudiente.ToString());
                    sl.SetCellValue(iR, 12, row.estudiante.CorreoElectronicoAcudiente.ToString());
                    sl.SetCellValue(iR, 13, row.estudiante.ObservacionesEstudiante.ToString());
                    sl.SetCellValue(iR, 14, row.estudiante.EstadoEstudiante.ToString());
                    sl.SetCellValue(iR, 15, row.grupo.NombreGrupo.ToString());
                    //sl.SetCellValue(iR, 16, row.grupo.IdGrupo.ToString());
                    //sl.SetCellValue(iR, 17, row.estudiante.Ruta_foto.ToString());
                    iR++;
                }
                sl.SaveAs(@"C:\Users\User\Documents\JardidPrueba.xlsx");
            }
        }
        public int IDPorNombre(String nombre)
        {
            int value = 0;

            for (int i = 0; i < lista_grupo.Count; i++)
            {
                if (lista_grupo[i].NombreGrupo == nombre)
                {
                    value = lista_grupo[i].IdGrupo;
                }
            }

            return value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (combo_grupo.Text == "Seleccione...")
            {
                CargarDatos();
            }
            else
            {
                CargarDatoFiltroDocumentoGrupo(IDPorNombre(combo_grupo.Text));
            }
        }

        private void Frm_Listado_Estudiantes_vs_Grupos_Load(object sender, EventArgs e)
        {

        }

        private void btnEstudiantesGrupos_Click(object sender, EventArgs e)
        {
            Frm_Listado_Estudiantes_vs_Grupos frm = new Frm_Listado_Estudiantes_vs_Grupos(usuario);
            frm.Show();
            this.Close();
        }

        private void btnReporteXML_Click(object sender, EventArgs e)
        {

        }
    }
}
