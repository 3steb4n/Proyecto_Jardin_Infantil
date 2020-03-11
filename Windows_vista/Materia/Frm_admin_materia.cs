﻿using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista.Materia
{
    public partial class Frm_admin_materia : Form
    {
        public Frm_admin_materia()
        {
            InitializeComponent();
            CargarDatos();
            dgv_materias.ClearSelection();
            dgv_materias.CurrentCell = null;
        }

        public void CargarDatos()
        {
            lista = blMateria.ListarMateria();
            dgv_materias.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgv_materias.Rows.Add(

                    lista[i].IdMateria,
                    lista[i].NombreMateria,
                    lista[i].DescripcionMateria,
                    lista[i].EstadoMateria,
                    lista[i].NumeroHorasMaterias,
                    lista[i].Area.IdArea,
                    lista[i].Area.NombreArea,
                    lista[i].Grado.IdGrado,
                    lista[i].Grado.NombreGrado

                );
                ;
            }

            dgv_materias.ClearSelection();
            dgv_materias.CurrentCell = null;
        }

        List<Materias> lista = null;
        BLMateria blMateria = new BLMateria();

        public void Frm_admin_materia_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        public void CargarDatoFiltro(String nombre)
        {
            Materias materias = new Materias();
            materias = blMateria.ListarMateriaPorNombre(nombre);
            dgv_materias.Rows.Clear();

            dgv_materias.Rows.Add(

                    materias.IdMateria,
                    materias.NombreMateria,
                    materias.DescripcionMateria,
                    materias.EstadoMateria,
                    materias.NumeroHorasMaterias,
                    materias.Area.IdArea,
                    materias.Area.NombreArea,
                    materias.Grado.IdGrado,
                    materias.Grado.NombreGrado

            );
            dgv_materias.ClearSelection();
            dgv_materias.CurrentCell = null;
        }

        private void dgv_materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_materias.RowCount > 0)
            {
                if (null != dgv_materias.CurrentRow)
                {
                    int id = (int)dgv_materias[0, dgv_materias.CurrentRow.Index].Value;

                    DialogResult response = MessageBox.Show("¿Esta seguro de eliminar el registro de la materia?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == System.Windows.Forms.DialogResult.Yes)
                    {
                        bool flag = blMateria.EliminarMateria(id);
                        if (flag == true)
                        {
                            MessageBox.Show("Registro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error del sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione registro a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No existen registros para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Frm_crear_materia frm_crear_materia = new Frm_crear_materia();
            frm_crear_materia.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (null != dgv_materias.CurrentRow)
            {
                if (dgv_materias.RowCount > 0)
                {
                    Materias materia = new Materias();

                    materia.IdMateria = (int)dgv_materias[0, dgv_materias.CurrentRow.Index].Value;
                    materia.NombreMateria = (String)dgv_materias[1, dgv_materias.CurrentRow.Index].Value.ToString();
                    materia.DescripcionMateria = (String)dgv_materias[2, dgv_materias.CurrentRow.Index].Value.ToString();
                    materia.EstadoMateria = (String)dgv_materias[3, dgv_materias.CurrentRow.Index].Value.ToString();
                    materia.NumeroHorasMaterias = (int)dgv_materias[4, dgv_materias.CurrentRow.Index].Value;
                    materia.Area.IdArea = (int)dgv_materias[5, dgv_materias.CurrentRow.Index].Value;
                    materia.Area.NombreArea = (String)dgv_materias[6, dgv_materias.CurrentRow.Index].Value.ToString();
                    materia.Grado.IdGrado = (int)dgv_materias[7, dgv_materias.CurrentRow.Index].Value;
                    materia.Grado.NombreGrado = (String)dgv_materias[8, dgv_materias.CurrentRow.Index].Value.ToString();

                    Frm_modificar_materia frm_modificar_materia = new Frm_modificar_materia(materia);
                    frm_modificar_materia.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (Txt_busquedaNombre.Text == "")
            {
                CargarDatos();
            }
            else
            {
                CargarDatoFiltro(Txt_busquedaNombre.Text);
            }
        }
    }
}
