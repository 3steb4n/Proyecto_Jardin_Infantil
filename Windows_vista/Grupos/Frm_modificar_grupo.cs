using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Windows_vista
{
    public partial class Frm_modificar_grupo : Form
    {
        public Frm_modificar_grupo(Grupo grupo)
        {
            InitializeComponent();
            CargarDatos(grupo);
            id_grupo = grupo.IdGrupo;
        }

        int id_grupo;
        List<Grado> lista = null;
        BLGrupo blGrupo = new BLGrupo();
        BLGrado blGrado = new BLGrado();

        public void CargarDatos(Grupo grupo)
        {
             lista = blGrado.ListarGados();

            for (int i = 0; i < lista.Count; i++)
            {
                Combo_grado.Items.Add(lista[i].NombreGrado).ToString();
            }

            // se llenan valores fijos del estado
            Combo_estado_grupo.Items.Add("Activo").ToString();
            Combo_estado_grupo.Items.Add("Inactivo").ToString();
            Combo_estado_grupo.SelectedItem = grupo.EstadoGrupo;
                
            Txt_nombre_grupo.Text = grupo.NombreGrupo;
            Txt_descripcion.Text = grupo.DescripcionGrupo;
            Combo_grado.SelectedItem = grupo.Grado.NombreGrado;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
 
            Grupo grupo = new Grupo();
            DateTime fechaActual = DateTime.Today;
            grupo.IdGrupo = id_grupo;
            grupo.NombreGrupo = Txt_nombre_grupo.Text;
            grupo.DescripcionGrupo = Txt_descripcion.Text;
            grupo.EstadoGrupo = ordenarEstado(Combo_estado_grupo.Text);
            grupo.UsuarioModificacion = "1";
            grupo.FechaModificacion = fechaActual;
            grupo.Grado.IdGrado = IDPorNombre(Combo_grado.Text);

            bool flag = blGrupo.ModificarGrupo(grupo);
            if (flag)
            {
                MessageBox.Show("Usuario modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_modificar_grupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_grupos frm_admin_grupos = new Frm_administracion_grupos();
            frm_admin_grupos.Show();
        }

        public int IDPorNombre(String nombre)
        {
            int value = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].NombreGrado == nombre)
                {
                    value = lista[i].IdGrado;
                }
            }

            return value;
        }

        public String ordenarEstado(String estado)
        {
            String value;
            if (estado == "Activo")
            {
                value = "A";
            }
            else
            {
                value = "I";
            }
            return value;
        }
    }
}
