using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_administracion_grupos : Form
    {
        public Frm_administracion_grupos()
        {
            InitializeComponent();
            CargarDatos();
            dgv_grupos.ClearSelection();
            dgv_grupos.CurrentCell = null;
        }

        List<Grupo> lista = null;
        BLGrupo blgrupo = new BLGrupo();

        public void CargarDatos()
        {
            lista = blgrupo.ListarGrupos();
            dgv_grupos.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgv_grupos.Rows.Add(

                    lista[i].IdGrupo,
                    lista[i].NombreGrupo,
                    lista[i].DescripcionGrupo,
                    lista[i].EstadoGrupo,
                    lista[i].Grado.NombreGrado,
                    lista[i].Grado.IdGrado,
                    lista[i].usuario.Id_usuario,
                    lista[i].usuario.Nombres,
                    lista[i].usuario.Apellidos

                );
                ;
            }

            dgv_grupos.ClearSelection();
            dgv_grupos.CurrentCell = null;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_grupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_administracion_grupos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Frm_crear_grupo frm_crear_grupo = new Frm_crear_grupo();
            frm_crear_grupo.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (null != dgv_grupos.CurrentRow)
            {
                if (dgv_grupos.RowCount > 0)
                {
                    Grupo grupo = new Grupo();

                    grupo.IdGrupo = (int)dgv_grupos[0, dgv_grupos.CurrentRow.Index].Value;
                    grupo.NombreGrupo = (String)dgv_grupos[1, dgv_grupos.CurrentRow.Index].Value.ToString();
                    grupo.DescripcionGrupo = (String)dgv_grupos[2, dgv_grupos.CurrentRow.Index].Value.ToString();
                    grupo.EstadoGrupo = (String)dgv_grupos[3, dgv_grupos.CurrentRow.Index].Value.ToString();
                    grupo.Grado.NombreGrado = (String)dgv_grupos[4, dgv_grupos.CurrentRow.Index].Value.ToString();
                    grupo.Grado.IdGrado = int.Parse(dgv_grupos[5, dgv_grupos.CurrentRow.Index].Value.ToString());
                    grupo.usuario.Id_usuario = int.Parse(dgv_grupos[6, dgv_grupos.CurrentRow.Index].Value.ToString());
                    grupo.usuario.Nombres = (String)(dgv_grupos[7, dgv_grupos.CurrentRow.Index].Value.ToString());
                    grupo.usuario.Apellidos = (String)(dgv_grupos[8, dgv_grupos.CurrentRow.Index].Value.ToString());

                    Frm_modificar_grupo frm_modificar_grupo = new Frm_modificar_grupo(grupo);
                    frm_modificar_grupo.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            Grupo grupo = new Grupo();
            grupo = blgrupo.ListarGrupoPorNombre(nombre);
            dgv_grupos.Rows.Clear();

            dgv_grupos.Rows.Add(

                grupo.IdGrupo,
                grupo.NombreGrupo,
                grupo.DescripcionGrupo,
                grupo.EstadoGrupo,
                grupo.Grado.NombreGrado,
                grupo.Grado.IdGrado
            );

            dgv_grupos.ClearSelection();
            dgv_grupos.CurrentCell = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_grupos.RowCount > 0)
            {
                if (null != dgv_grupos.CurrentRow)
                {
                    int id = (int)dgv_grupos[0, dgv_grupos.CurrentRow.Index].Value;

                    DialogResult response = MessageBox.Show("¿Esta seguro de eliminar el registro del grupo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == System.Windows.Forms.DialogResult.Yes)
                    {
                        bool flag = blgrupo.EliminarGrupo(id);
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
    }
}
