using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Windows_vista.docentes;
using Windows_vista.reportes;

namespace Windows_vista.pagos
{
    public partial class Frm_admin_pagos : Form
    {
        public Frm_admin_pagos(Usuario usuario)
        {
            InitializeComponent();
            CargarDatos();
            dgv_pagos.ClearSelection();
            dgv_pagos.CurrentCell = null;
            this.usuario = usuario;
        }

        Usuario usuario;
        List<Pago> lista = null;
        List<ConceptoPago> lista_concepto = null;
        BLPago blPago = new BLPago();
        BLAbonoPago blAbonoPago = new BLAbonoPago();
        BLConceptoPago blConceptoPago = new BLConceptoPago();
        int valorAbonado = 0;

        public void CargarDatos()
        {
            lista = blPago.ListarPagos();
            dgv_pagos.Rows.Clear();


            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[0].IdPago != 0)
                {
                    valorAbonado = 0;

                    valorAbonado = blAbonoPago.ValorAbonado(lista[i].IdPago);
                    String estado = "";
                    if (lista[i].ValorMonto == valorAbonado)
                    {
                        estado = "PAGADO";
                    }
                    else
                    {
                        estado = "NO PAGADO";
                    }
                    dgv_pagos.Rows.Add(

                        lista[i].IdPago,
                        estado,
                        lista[i].ValorMonto,
                        valorAbonado,
                        lista[i].DescripcionPago,
                        lista[i].Usuario.Id_usuario,
                        lista[i].Usuario.Nombres + " " + lista[i].Usuario.Apellidos,
                        lista[i].FechaCreacion,
                        lista[i].ConceptoPago.IdConcepto,
                        lista[i].ConceptoPago.NombreConcepto,
                        lista[i].Matricula.Id_matricula,
                        lista[i].Matricula.Numeromatricula,
                        lista[i].Matricula.estudiante.Id_estudiante,
                        lista[i].Matricula.estudiante.DocumentoEstudiante,
                        lista[i].Matricula.estudiante.NombreEstudiante + " " + lista[i].Matricula.estudiante.ApellidoEstudiante,
                        lista[i].Matricula.estudiante.NombreAcudiente,
                        lista[i].Matricula.estudiante.CorreoElectronicoAcudiente,
                        lista[i].Matricula.estudiante.TelefonoAcudiente,
                        lista[i].Matricula.estudiante.CelularAcudiente,
                        lista[i].Matricula.estudiante.Direccion
                    );
                    ;
                }
            }

            dgv_pagos.ClearSelection();
            dgv_pagos.CurrentCell = null;

            lista_concepto = blConceptoPago.ListarConceptos();
            combo_concepto_pago.DataSource = lista_concepto;
            combo_concepto_pago.DisplayMember = "NombreConcepto";
            combo_concepto_pago.ValueMember = "IdConcepto";

            combo_concepto_pago.SelectedItem = "Seleccione...";

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Frm_crear_pago frm_crear_pago = new Frm_crear_pago(usuario);
            frm_crear_pago.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Txt_busquedaCedula.Text == "" && combo_concepto_pago.Text == "Seleccione...")
            {
                CargarDatos();
            }
            else if (Txt_busquedaCedula.Text != "" && combo_concepto_pago.Text == "Seleccione...")
            {
                CargarDatoFiltro(Txt_busquedaCedula.Text, "");
            }
            else
            {
                CargarDatoFiltro(Txt_busquedaCedula.Text, combo_concepto_pago.Text);
            }
        }

        public void CargarDatoFiltro(String documento, String conceptoPago)
        {
            lista = blPago.ListarFiltro(documento, conceptoPago);
            dgv_pagos.Rows.Clear();


            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[0].IdPago != 0)
                {
                    valorAbonado = 0;

                    valorAbonado = blAbonoPago.ValorAbonado(lista[i].IdPago);
                    String estado = "";
                    if (lista[i].ValorMonto == valorAbonado)
                    {
                        estado = "PAGADO";
                    }
                    else
                    {
                        estado = "NO PAGADO";
                    }
                    dgv_pagos.Rows.Add(

                        lista[i].IdPago,
                        estado,
                        lista[i].ValorMonto,
                        valorAbonado,
                        lista[i].DescripcionPago,
                        lista[i].Usuario.Id_usuario,
                        lista[i].Usuario.Nombres + " " + lista[i].Usuario.Apellidos,
                        lista[i].FechaCreacion,
                        lista[i].ConceptoPago.IdConcepto,
                        lista[i].ConceptoPago.NombreConcepto,
                        lista[i].Matricula.Id_matricula,
                        lista[i].Matricula.Numeromatricula,
                        lista[i].Matricula.estudiante.Id_estudiante,
                        lista[i].Matricula.estudiante.DocumentoEstudiante,
                        lista[i].Matricula.estudiante.NombreEstudiante + " " + lista[i].Matricula.estudiante.ApellidoEstudiante,
                        lista[i].Matricula.estudiante.NombreAcudiente,
                        lista[i].Matricula.estudiante.CorreoElectronicoAcudiente,
                        lista[i].Matricula.estudiante.TelefonoAcudiente,
                        lista[i].Matricula.estudiante.CelularAcudiente,
                        lista[i].Matricula.estudiante.Direccion
                    );
                    ;
                }
            }

            dgv_pagos.ClearSelection();
            dgv_pagos.CurrentCell = null;
        }

        private void dgv_pagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name == "Estado_pago")
            {
                if (e.Value.ToString() == "PAGADO")
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.SelectionBackColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.Red;
                }
            }
        }

        private void Btn_detalle_Click(object sender, EventArgs e)
        {
            if (null != dgv_pagos.CurrentRow)
            {
                if (dgv_pagos.RowCount > 0)
                {
                    Pago pago = new Pago();

                    pago.IdPago = (int)dgv_pagos[0, dgv_pagos.CurrentRow.Index].Value;
                    pago.ValorMonto = (int)dgv_pagos[2, dgv_pagos.CurrentRow.Index].Value;
                    pago.FechaCreacion = (DateTime)dgv_pagos[7, dgv_pagos.CurrentRow.Index].Value;
                    pago.ConceptoPago.NombreConcepto = (String)dgv_pagos[9, dgv_pagos.CurrentRow.Index].Value;
                    pago.Matricula.Numeromatricula = (int)dgv_pagos[11, dgv_pagos.CurrentRow.Index].Value;
                    pago.Matricula.estudiante.Id_estudiante = (int)dgv_pagos[12, dgv_pagos.CurrentRow.Index].Value;
                    pago.Matricula.estudiante.DocumentoEstudiante = (String)dgv_pagos[13, dgv_pagos.CurrentRow.Index].Value;
                    pago.Matricula.estudiante.NombreEstudiante = (String)dgv_pagos[14, dgv_pagos.CurrentRow.Index].Value;
                    pago.Matricula.estudiante.NombreAcudiente = (String)dgv_pagos[15, dgv_pagos.CurrentRow.Index].Value;

                    Frm_pago_detalle frm_admin_usuarios = new Frm_pago_detalle(pago, usuario);
                    frm_admin_usuarios.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro para ver detalle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_estudiantes_Click(object sender, EventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuario);
            frm_admin_estudiantes.Show();
            this.Close();
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            frm_reporte_secretaria frm = new frm_reporte_secretaria(usuario);
            frm.Show();
            this.Close();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_admin_docentes frm_admin_docentes = new Frm_admin_docentes(usuario);
            frm_admin_docentes.Show();
            this.Close();
        }

        private void Btn_pagos_Click(object sender, EventArgs e)
        {
            Frm_admin_pagos frm_admin_pagos = new Frm_admin_pagos(usuario);
            frm_admin_pagos.Show();
            this.Close();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Frm_inicio_sesion frm_inicio_sesion = new Frm_inicio_sesion();
            frm_inicio_sesion.Show();
            this.Close();
        }

        private void dgv_pagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_admin_pagos_Load(object sender, EventArgs e)
        {

        }

        public void exportgridopdf(DataGridView dgv_pagos,string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdf = new PdfPTable(dgv_pagos.Columns.Count);
            pdf.DefaultCell.Padding = 3;
            pdf.WidthPercentage = 100;
            pdf.HorizontalAlignment = Element.ALIGN_LEFT;
            pdf.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dgv_pagos.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdf.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv_pagos.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdf.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName,FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdf);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        
        
        private void PDF_Click(object sender, EventArgs e)
        {
            exportgridopdf(dgv_pagos, "text");
        }
    }
}
