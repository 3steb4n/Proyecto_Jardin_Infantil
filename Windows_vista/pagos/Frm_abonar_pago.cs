using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista.pagos
{
    public partial class Frm_abonar_pago : Form
    {
        public Frm_abonar_pago(Usuario usuario, Pago pago)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.usuario = usuario;
            this.pago = pago;
            CargarDatos();
        }

        Pago pago;
        List<AbonoPago> listaAbonoPagos = null;
        BLAbonoPago bLAbonoPago = new BLAbonoPago();
        int valorAbonado = 0;
        int valor_temporal = 0;
        int valorFaltante = 0;

        private void CargarDatos()
        {

            listaAbonoPagos = bLAbonoPago.ListarAbonos(pago.IdPago);

            for (int i = 0; i < listaAbonoPagos.Count; i++)
            {
                valorAbonado = (valorAbonado + listaAbonoPagos[i].ValorAbono);
            }

            valorFaltante = (pago.ValorMonto - valorAbonado);
            ComboboxItem item_pago1 = new ComboboxItem(); item_pago1.Text = "Seleccione..."; item_pago1.Value = "";
            ComboboxItem item_pago2 = new ComboboxItem(); item_pago2.Text = "Parcial"; item_pago2.Value = "P";
            ComboboxItem item_pago3 = new ComboboxItem(); item_pago3.Text = "Completo"; item_pago3.Value = "C";
            Object[] items_pago = new Object[3];
            items_pago[0] = item_pago1;
            items_pago[1] = item_pago2;
            items_pago[2] = item_pago3;

            combo_tipo_abono.Items.AddRange(items_pago);
            combo_tipo_abono.SelectedIndex = 0;

            label_nombre_estudiante.Text = pago.Estudiante.NombreEstudiante;
            label_nombre_acudiente.Text = pago.Estudiante.NombreAcudiente;
            label_concepto_pago.Text = pago.ConceptoPago.NombreConcepto;
            label_fecha.Text = pago.FechaCreacion.ToString();
            label_id_pago.Text = "# " + pago.IdPago.ToString();
            label_valor_pago.Text = pago.ValorMonto.ToString();
            label_documento_estudiante.Text = pago.Estudiante.DocumentoEstudiante.ToString();
            Txt_valor_total.Text = pago.ValorMonto.ToString();
            Txt_valor_faltante.Text = valorFaltante.ToString();

        }

        public void refrescar()
        {
            valorAbonado = 0;
            for (int i = 0; i < listaAbonoPagos.Count; i++)
            {
                valorAbonado = (valorAbonado + listaAbonoPagos[i].ValorAbono);
            }

            valorFaltante = (pago.ValorMonto - valorAbonado);
        }

        Usuario usuario;

        private void combo_tipo_abono_SelectedIndexChanged(object sender, EventArgs e)
        {
            int contador = combo_tipo_abono.SelectedIndex;

            if (contador == 1)
            {
                if (Txt_valor_abonar.Text != "")
                {
                    valor_temporal = Convert.ToInt32(Txt_valor_abonar.Text.ToString());
                    Txt_valor_abonar.Enabled = true;
                    Txt_valor_faltante.Text = valor_temporal.ToString();
                    Txt_valor_abonar.Text = "";
                }
                else
                {
                    valor_temporal = 0;
                    Txt_valor_abonar.Enabled = true;
                    Txt_valor_abonar.Text = "";
                }
            }

            if (contador == 2)
            {
                refrescar();
                //valor_temporal = Convert.ToInt32(Txt_valor_faltante.Text.ToString());
                Txt_valor_abonar.Enabled = false;
                valor_temporal = (pago.ValorMonto - (valorFaltante + valorAbonado));
                Txt_valor_abonar.Text = valorFaltante.ToString();
                Txt_valor_faltante.Text = valor_temporal.ToString();
            }
        }

        private void Txt_valor_abonar_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_valor_abonar.Text != "")
            {
                int valor_temporal = Convert.ToInt32(Txt_valor_abonar.Text);
                int faltante = (pago.ValorMonto - valorAbonado);
                valorFaltante = (pago.ValorMonto - (valor_temporal + valorAbonado));

                if (valorFaltante < 0)
                {
                    errorValorAbonar.SetError(Txt_valor_abonar, "no puede abonar mas del valor faltante. valor faltante: " + faltante);
                    Txt_valor_abonar.Focus();
                    Txt_valor_faltante.Text = "0";
                }
                else
                {
                    Txt_valor_faltante.Text = valorFaltante.ToString();
                    errorValorAbonar.Clear();
                }
            }
            else
            {
                int valor_temporal = 0;
                valorFaltante = (pago.ValorMonto - (valor_temporal + valorAbonado));
                Txt_valor_faltante.Text = valorFaltante.ToString();
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                AbonoPago abonoPago = new AbonoPago();

                guardar(abonoPago);

            }
        }

        private void guardar(AbonoPago abonoPago)
        {
            DateTime fechaActual = DateTime.Today;

            abonoPago.TipoAbono = (combo_tipo_abono.SelectedItem as ComboboxItem).Value.ToString();
            abonoPago.ValorAbono = Convert.ToInt32(Txt_valor_abonar.Text.ToString());
            abonoPago.DescripcionAbono = Txt_descripcion.Text;
            abonoPago.UsuarioCreacion = usuario.Id_usuario.ToString();
            abonoPago.FechaCreacion = fechaActual;
            abonoPago.Pago.IdPago = pago.IdPago;

            DialogResult response = MessageBox.Show("¿Esta seguro de registrar el abono?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == System.Windows.Forms.DialogResult.Yes)
            {
                bool bandera = bLAbonoPago.InsertarAbono(abonoPago);

                if (bandera)
                {
                    MessageBox.Show("Abono registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void combo_tipo_abono_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_tipo_abono.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorTipoAbono.SetError(combo_tipo_abono, "Seleccione tipo de abono");
                combo_tipo_abono.Focus();
            }
            else
            {
                errorTipoAbono.Clear();
            }
        }

        private void Txt_valor_abonar_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int valor_temporal = Convert.ToInt32(Txt_valor_abonar.Text.ToString());
            if (Txt_valor_abonar.Text == "" || Txt_valor_abonar.Text == "0")
            {
                e.Cancel = true;
                errorValorAbonar.SetError(Txt_valor_abonar, "Introdusca la cantidad de dinero a abonar");
                Txt_valor_abonar.Focus();
            }
            else if (!Regex.IsMatch(Txt_valor_abonar.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorValorAbonar.SetError(Txt_valor_abonar, "Solo numeros");
                Txt_valor_abonar.Focus();
            }
            else if (valor_temporal < 10000)
            {
                e.Cancel = true;
                errorValorAbonar.SetError(Txt_valor_abonar, "Valor minimo de abono 10 mil pesos.");
                Txt_valor_abonar.Focus();
            }
            else
            {
                errorValorAbonar.Clear();
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
    }
}
