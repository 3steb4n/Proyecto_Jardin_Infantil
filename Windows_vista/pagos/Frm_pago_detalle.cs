using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_vista.pagos
{
    public partial class Frm_pago_detalle : Form
    {
        public Frm_pago_detalle(Pago pago, Usuario usuario)
        {
            InitializeComponent();
            this.pago = pago;
            this.usuario = usuario;
            CargarDatos();
            dgv_abono_pago.ClearSelection();
            dgv_abono_pago.CurrentCell = null;
        }

        Pago pago;
        Usuario usuario;
        List<AbonoPago> listaAbonoPagos = null;
        int cantidadPagada;
        BLAbonoPago bLAbonoPago = new BLAbonoPago();
        BLConceptoPago blConceptoPago = new BLConceptoPago();

        public void CargarDatos()
        {
            cantidadPagada = 0;
            listaAbonoPagos = bLAbonoPago.ListarAbonos(pago.IdPago);
            dgv_abono_pago.Rows.Clear();
            for (int i = 0; i < listaAbonoPagos.Count; i++)
            {
                dgv_abono_pago.Rows.Add(

                    listaAbonoPagos[i].IdAbonoPago,
                    listaAbonoPagos[i].TipoAbono,
                    listaAbonoPagos[i].ValorAbono,
                    listaAbonoPagos[i].DescripcionAbono,
                    listaAbonoPagos[i].FechaCreacion,
                    listaAbonoPagos[i].Pago.IdPago,
                    listaAbonoPagos[i].DescripcionAbono,
                    listaAbonoPagos[i].usuario.Nombres + " " + listaAbonoPagos[i].usuario.Apellidos
                );

                cantidadPagada = (cantidadPagada + listaAbonoPagos[i].ValorAbono);
            }
            label_Id_matricula.Text = pago.Matricula.Numeromatricula.ToString();
            label_nombre_estudiante.Text = pago.Matricula.estudiante.NombreEstudiante;
            label_nombre_acudiente.Text = pago.Matricula.estudiante.NombreAcudiente;
            label_concepto_pago.Text = pago.ConceptoPago.NombreConcepto;
            label_fecha.Text = pago.FechaCreacion.ToString();
            label_estado_valor.Text = "Pagado";
            label_id_pago.Text = "# " + pago.IdPago.ToString();
            label_valor_pago.Text = pago.ValorMonto.ToString();
            label_abonado_valor.Text = cantidadPagada.ToString();
            label_documento_estudiante.Text = pago.Matricula.estudiante.DocumentoEstudiante.ToString();

            if (cantidadPagada == pago.ValorMonto)
            {
                label_estado_valor.Text = "Pagado";
                label_estado_info.Text = "Estado : ";
                label_estado_valor.ForeColor = Color.Green;
                label_estado_info.ForeColor = Color.Green;
                Btn_abonar.Enabled = false;

            }
            else
            {
                label_estado_valor.Text = "No Pagado";
                label_estado_info.Text = "Estado : ";
                label_estado_valor.ForeColor = Color.Red;
                label_estado_info.ForeColor = Color.Red;
                Btn_abonar.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_abonar_pago frm_abono_pago = new Frm_abonar_pago(usuario, pago);
            frm_abono_pago.Show();
        }

        private void Frm_pago_detalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_pagos frm_admin_pagos = new Frm_admin_pagos(usuario);
            frm_admin_pagos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
