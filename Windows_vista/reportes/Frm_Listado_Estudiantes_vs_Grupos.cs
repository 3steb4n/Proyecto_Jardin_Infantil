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

        List<Estudiante> lista = null;
        List<Grupo> lista_grupo = null;

        BLEstudiante blestudiante = new BLEstudiante();
        BLGrupo blgrupo = new BLGrupo();
        Usuario usuario;

        public void CargarDatos()
        {
            lista = blestudiante.ListarEstudiante();
            dgv_ListarEstudiantePorGrupo.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[0].Id_estudiante != 0)
                {
                    dgv_ListarEstudiantePorGrupo.Rows.Add(

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
                        lista[i].grupo.IdGrupo,
                        lista[i].Ruta_foto
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

        public void CargarDatoFiltroDocumentoGrupo(String documento, int idGrupo)
        {
            List<Estudiante> estudiante = new List<Estudiante>();
            estudiante = blestudiante.ListarEstudiantePorDocumentoyGrupo(documento, idGrupo);
            dgv_ListarEstudiantePorGrupo.Rows.Clear();

            for (int i = 0; i < estudiante.Count; i++)
            {
                if (estudiante[0].Id_estudiante != 0)
                {
                    dgv_ListarEstudiantePorGrupo.Rows.Add(

                        estudiante[i].Id_estudiante,
                        estudiante[i].DocumentoEstudiante,
                        estudiante[i].TipoDocumento,
                        estudiante[i].NombreEstudiante,
                        estudiante[i].ApellidoEstudiante,
                        estudiante[i].FechaNacimiento,
                        estudiante[i].NombreAcudiente,
                        estudiante[i].Direccion,
                        estudiante[i].Genero,
                        estudiante[i].TelefonoAcudiente,
                        estudiante[i].CelularAcudiente,
                        estudiante[i].CorreoElectronicoAcudiente,
                        estudiante[i].ObservacionesEstudiante,
                        estudiante[i].EstadoEstudiante,
                        estudiante[i].grupo.NombreGrupo,
                        estudiante[i].grupo.IdGrupo,
                        estudiante[i].Ruta_foto
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

                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                style.Font.FontSize = 12;
                style.Font.Bold = true;

                List<Estudiante> estudiante = new List<Estudiante>();
                estudiante = blestudiante.ListarEstudiantePorDocumentoyGrupo("", IDPorNombre(combo_grupo.Text));

                int iC = 1;
                foreach (DataGridViewColumn column in dgv_ListarEstudiantePorGrupo.Columns)
                {
                    sl.SetCellValue(1, iC, column.HeaderText.ToString());
                    sl.SetCellStyle(1, iC, style);
                    iC++;
                }

                int iR = 2;
                foreach (var row in estudiante)
                {
                    sl.SetCellValue(iR, 2, row.DocumentoEstudiante.ToString());
                    sl.SetCellValue(iR, 3, row.TipoDocumento.ToString());
                    sl.SetCellValue(iR, 4, row.NombreEstudiante.ToString());
                    sl.SetCellValue(iR, 5, row.ApellidoEstudiante.ToString());
                    sl.SetCellValue(iR, 6, row.FechaNacimiento.ToString());
                    sl.SetCellValue(iR, 7, row.NombreAcudiente.ToString());
                    sl.SetCellValue(iR, 8, row.Direccion.ToString());
                    sl.SetCellValue(iR, 9, row.Genero.ToString());
                    sl.SetCellValue(iR, 10, row.TelefonoAcudiente.ToString());
                    sl.SetCellValue(iR, 11, row.CelularAcudiente.ToString());
                    sl.SetCellValue(iR, 12, row.CorreoElectronicoAcudiente.ToString());
                    sl.SetCellValue(iR, 13, row.ObservacionesEstudiante.ToString());
                    sl.SetCellValue(iR, 14, row.EstadoEstudiante.ToString());
                    sl.SetCellValue(iR, 15, row.grupo.NombreGrupo.ToString());
                    //sl.SetCellValue(iR, 16, row.grupo.IdGrupo.ToString());
                    sl.SetCellValue(iR, 17, row.Ruta_foto.ToString());
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
                CargarDatoFiltroDocumentoGrupo("" , IDPorNombre(combo_grupo.Text));
            }
        }

        private void Frm_Listado_Estudiantes_vs_Grupos_Load(object sender, EventArgs e)
        {

        }
    }
}
