using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista.Logros
{
    public partial class Frm_admin_logros : Form
    {
        public Frm_admin_logros(Usuario usuario)
        {
            InitializeComponent();
            CargarDatos();
            dgv_logros.ClearSelection();
            dgv_logros.CurrentCell = null;
            this.usuario = usuario;
        }

        List<Logro> lista = null;
        BLLogro blLogro = new BLLogro();
        Usuario usuario;

        public void CargarDatos()
        {
            lista = blLogro.ListarLogros();
            dgv_logros.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgv_logros.Rows.Add(

                    lista[i].IdLogro,
                    lista[i].NombreLogro,
                    lista[i].DescripcionLogro,
                    lista[i].EstadoLogro,
                    lista[i].Materia.IdMateria,
                    lista[i].Materia.NombreMateria

                );
                ;
            }

            dgv_logros.ClearSelection();
            dgv_logros.CurrentCell = null;

        }

        private void Frm_admin_logros_Load(object sender, System.EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Txt_busqueda.Text == "")
            {
                CargarDatos();
            }
            else
            {
                CargarDatoFiltro(Txt_busqueda.Text);
            }
        }

        public void CargarDatoFiltro(String nombre)
        {
            Logro logro = new Logro();
            logro = blLogro.ListarLogroPorNombre(nombre);
            dgv_logros.Rows.Clear();

            dgv_logros.Rows.Add(

                    logro.IdLogro,
                    logro.NombreLogro,
                    logro.DescripcionLogro,
                    logro.EstadoLogro,
                    logro.Materia.IdMateria,
                    logro.Materia.NombreMateria

            );
            dgv_logros.ClearSelection();
            dgv_logros.CurrentCell = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_logros.RowCount > 0)
            {
                if (null != dgv_logros.CurrentRow)
                {
                    int id = (int)dgv_logros[0, dgv_logros.CurrentRow.Index].Value;

                    DialogResult response = MessageBox.Show("¿Esta seguro de eliminar el logro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == System.Windows.Forms.DialogResult.Yes)
                    {
                        bool flag = blLogro.EliminarLogro(id);
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
            Frm_crear_logro frm_crear_logro = new Frm_crear_logro(usuario);
            frm_crear_logro.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (null != dgv_logros.CurrentRow)
            {
                if (dgv_logros.RowCount > 0)
                {
                    Logro logro = new Logro();

                    logro.IdLogro = (int)dgv_logros[0, dgv_logros.CurrentRow.Index].Value;
                    logro.NombreLogro = (String)dgv_logros[1, dgv_logros.CurrentRow.Index].Value.ToString();
                    logro.DescripcionLogro = (String)dgv_logros[2, dgv_logros.CurrentRow.Index].Value.ToString();
                    logro.EstadoLogro = (String)dgv_logros[3, dgv_logros.CurrentRow.Index].Value.ToString();
                    logro.Materia.IdMateria = (int)dgv_logros[4, dgv_logros.CurrentRow.Index].Value;
                    logro.Materia.NombreMateria = (String)dgv_logros[5, dgv_logros.CurrentRow.Index].Value;

                    Frm_modificar_logro frm_modificar_logro = new Frm_modificar_logro(logro,usuario);
                    frm_modificar_logro.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_logros_Click(object sender, EventArgs e)
        {
            Frm_admin_logros frm_admin_logros = new Frm_admin_logros(usuario);
            frm_admin_logros.Show();
            this.Close();
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Frm_inicio_sesion frm_inicio_sesion = new Frm_inicio_sesion();
            frm_inicio_sesion.Show();
            this.Close();
        }
    }
}
