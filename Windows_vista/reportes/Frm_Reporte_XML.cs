using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace Windows_vista.reportes
{
    public partial class Frm_Reporte_XML : Form
    {
        public Frm_Reporte_XML()
        {
            InitializeComponent();
            CargarDatos();
            dgv_Grado.ClearSelection();
            dgv_Grado.CurrentCell = null;

            dgv_Area.ClearSelection();
            dgv_Area.CurrentCell = null;


            this.usuario = usuario;
        }

        List<Grado> lista_grado = null;
        List<Area> lista_area = null;
        BLGrado blgrado = new BLGrado();
        BLArea blarea = new BLArea();

        Usuario usuario;
        public void CargarDatos()
        {
            lista_grado = blgrado.ListarReporteGrados();
            dgv_Grado.Rows.Clear();
            for (int i = 0; i < lista_grado.Count; i++)
            {
                if (lista_grado[0].IdGrado != 0)
                {
                    dgv_Grado.Rows.Add(

                        lista_grado[i].IdGrado,
                        lista_grado[i].NombreGrado,
                        lista_grado[i].Descripcion,
                        lista_grado[i].Estado
                    );
                }
            }

            dgv_Grado.ClearSelection();
            dgv_Grado.CurrentCell = null;

            lista_area = blarea.ListarAreas();
            dgv_Area.Rows.Clear();
            for (int i = 0; i < lista_area.Count; i++)
            {
                if (lista_area[0].IdArea != 0)
                {
                    dgv_Area.Rows.Add(

                        lista_area[i].IdArea,
                        lista_area[i].NombreArea
                    );
                }
            }

            dgv_Area.ClearSelection();
            dgv_Area.CurrentCell = null;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Reporte_XML_Load(object sender, EventArgs e)
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
            ExportarXML();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportarXML();
        }
       

        private void ExportarXML()
        {
            var ds = new DataSet();
            var dt = new DataTable();
          
                foreach (var column in dgv_Grado.Columns.Cast<DataGridViewColumn>())
                {
                    dt.Columns.Add();
                }

                var cellValues = new object[dgv_Grado.Columns.Count];

                foreach (var row in dgv_Grado.Rows.Cast<DataGridViewRow>())
                {
                    for (int i = 0; i < row.Cells.Count;i++) 
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }
                }

                ds.Tables.Add(dt);

             string FileName = "Archivo.xml";
             FileStream stream = new FileStream(FileName, FileMode.Create);
             XmlTextWriter xmlWrite = new XmlTextWriter(stream, System.Text.Encoding.Unicode);
             ds.WriteXml(xmlWrite);
             xmlWrite.Close();
             
            
        }
    }
}
