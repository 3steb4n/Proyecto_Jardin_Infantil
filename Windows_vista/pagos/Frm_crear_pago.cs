using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista.pagos
{
    public partial class Frm_crear_pago : Form
    {
        public Frm_crear_pago(Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.usuario = usuario;
            CargarDatos();
        }

        Usuario usuario;
        List<Matricula> lista_matricula = null;
        List<ConceptoPago> lista_concepto_pago = null;

        BLPago blPago = new BLPago();
        BLMatricula bLMatricula = new BLMatricula();
        BLConceptoPago blConceptoPago = new BLConceptoPago();

        private void CargarDatos()
        {
            // se llena el combo de estudiante
            lista_matricula = bLMatricula.ListarMatricula();
            ComboboxItem item_estudiante1 = new ComboboxItem(); item_estudiante1.Text = "Seleccione..."; item_estudiante1.Value = "";
            ComboboxItem item_estudiante;
            Object[] items_estudiantes = new Object[lista_matricula.Count];
            for (int i = 0; i < lista_matricula.Count; i++)
            {
                items_estudiantes[i] = item_estudiante = new ComboboxItem(); item_estudiante.Text = lista_matricula[i].estudiante.NombreEstudiante + " " + lista_matricula[i].estudiante.ApellidoEstudiante; item_estudiante.Value = lista_matricula[i].Id_matricula;
            }
            combo_estudiantes.Items.Add(item_estudiante1);
            combo_estudiantes.Items.AddRange(items_estudiantes);
            combo_estudiantes.SelectedIndex = 0;

            // se llena el selector de grado
            lista_concepto_pago = blConceptoPago.ListarConceptos();
            ComboboxItem item_concepto;
            Object[] items_concepto = new Object[lista_concepto_pago.Count];
            for (int i = 0; i < lista_concepto_pago.Count; i++)
            {
                items_concepto[i] = item_concepto = new ComboboxItem(); item_concepto.Text = lista_concepto_pago[i].NombreConcepto; item_concepto.Value = lista_concepto_pago[i].IdConcepto;
            }
            combo_concepto.Items.AddRange(items_concepto);
            combo_concepto.SelectedIndex = 0;
        }

        private void combo_concepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = combo_concepto.SelectedIndex;
            Txt_valor_concepto.Text = lista_concepto_pago[id].ValorConcepto.ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Pago pago = new Pago();

                guardar(pago);

            }
        }

        private void guardar(Pago pago)
        {
            DateTime fechaActual = DateTime.Today;

            pago.ValorMonto = Convert.ToInt32(Txt_valor_concepto.Text);
            pago.DescripcionPago = Txt_descripcion.Text;
            pago.UsuarioCreacion = usuario.Id_usuario.ToString();
            pago.FechaCreacion = fechaActual;
            pago.ConceptoPago.IdConcepto = int.Parse((combo_concepto.SelectedItem as ComboboxItem).Value.ToString());
            pago.Matricula.Id_matricula = int.Parse((combo_estudiantes.SelectedItem as ComboboxItem).Value.ToString());



            DialogResult response = MessageBox.Show("¿Esta seguro de registrar el pago?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == System.Windows.Forms.DialogResult.Yes)
            {
                bool bandera = blPago.InsertarPago(pago);

                if (bandera)
                {
                    MessageBox.Show("Pago creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void combo_estudiantes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_estudiantes.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorEstudiante.SetError(combo_estudiantes, "Seleccione el estudiante");
                combo_estudiantes.Focus();
            }
            else
            {
                errorEstudiante.Clear();
            }
        }

        private void combo_concepto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_concepto.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorConcepto.SetError(combo_concepto, "Seleccione el estudiante");
                combo_concepto.Focus();
            }
            else
            {
                errorConcepto.Clear();
            }
        }

        private void Txt_valor_concepto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_valor_concepto.Text == "" || Txt_valor_concepto.Text == "0")
            {
                e.Cancel = true;
                errorValor.SetError(Txt_valor_concepto, "Introdusca la cantidad de dinero a abonar");
                Txt_valor_concepto.Focus();
            }
            else if (!Regex.IsMatch(Txt_valor_concepto.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorValor.SetError(Txt_valor_concepto, "Solo numeros");
                Txt_valor_concepto.Focus();
            }
            else
            {
                errorValor.Clear();
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

        private void Frm_crear_pago_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_pagos frm_admin_pagos = new Frm_admin_pagos(usuario);
            frm_admin_pagos.Show();
        }

        private void Frm_crear_pago_Load(object sender, EventArgs e)
        {

        }
    }

}
