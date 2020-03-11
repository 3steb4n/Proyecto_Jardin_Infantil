﻿using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista.Logros
{
    public partial class Frm_modificar_logro : Form
    {
        public Frm_modificar_logro(Logro logro)
        {
            InitializeComponent();
            cargarDatos(logro);
            id_logro = logro.IdLogro;
        }

        int id_logro;
        List<Materias> lista_materia = null;
        BLMateria blMateria = new BLMateria();
        BLLogro blLogro = new BLLogro();

        public void cargarDatos(Logro logro)
        {
            // se llena el selector de area
            lista_materia = blMateria.ListarIdNombre();

            for (int i = 0; i < lista_materia.Count; i++)
            {
                combo_materia.Items.Add(lista_materia[i].NombreMateria).ToString();
            }

            combo_materia.SelectedItem = logro.Materia.NombreMateria;
            Txt_nombre.Text = logro.NombreLogro;
            Txt_descripcion.Text = logro.DescripcionLogro;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_modificar_logro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_admin_logros frm_admin_logros = new Frm_admin_logros();
            frm_admin_logros.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Logro logro = new Logro();
            DateTime fechaActual = DateTime.Today;

            logro.IdLogro = id_logro;
            logro.NombreLogro = Txt_nombre.Text;
            logro.DescripcionLogro = Txt_descripcion.Text;
            logro.UsuarioModificacion = "1";
            logro.FechaModificacion = fechaActual;
            logro.Materia.IdMateria = IDPorNombre(combo_materia.Text);


            bool flag = blLogro.ModificarLogro(logro);
            if (flag)
            {
                MessageBox.Show("Logro modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int IDPorNombre(String nombre)
        {
            int value = 0;

            for (int i = 0; i < lista_materia.Count; i++)
            {
                if (lista_materia[i].NombreMateria == nombre)
                {
                    value = lista_materia[i].IdMateria;
                }
            }

            return value;
        }
    }
}
