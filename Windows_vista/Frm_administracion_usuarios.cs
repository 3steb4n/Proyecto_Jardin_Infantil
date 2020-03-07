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
    public partial class Frm_administracion_usuarios : Form
    {
        public Frm_administracion_usuarios()
        {
            InitializeComponent();
            CargarDatos();
            dgv_usuarios.ClearSelection();
            dgv_usuarios.CurrentCell = null;
        }

        List<Usuario> lista = null;
        BLUsuario blUsuario = new BLUsuario();
        Usuario usuario;

        private void Frm_administracion_usuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_docentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Crear_Usuario frm_crear_usuario = new Frm_Crear_Usuario();
            frm_crear_usuario.Show();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Frm_inicio_Sesion frm_login = new Frm_inicio_Sesion();
            frm_login.Show();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_administracion_usuarios frm_admin_usuarios = new Frm_administracion_usuarios();
            frm_admin_usuarios.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (null != dgv_usuarios.CurrentRow)
            {
                if (dgv_usuarios.RowCount > 0)
                {
                    Usuario usuario = new Usuario();

                    usuario.Id_usuario= (int)dgv_usuarios[0, dgv_usuarios.CurrentRow.Index].Value;
                    usuario.Documento = (String)dgv_usuarios[1, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.TipoDocumento = (String)dgv_usuarios[2, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.Nombres = (String)dgv_usuarios[3, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.Apellidos = (String)dgv_usuarios[4, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.Direccion = (String)dgv_usuarios[5, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.Celular = (String)dgv_usuarios[6, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.Telefono = (String)dgv_usuarios[7, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.CorreoElectronico = (String)dgv_usuarios[8, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.EstadoUsuario = (String)dgv_usuarios[9, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.EstadoClave = (String)dgv_usuarios[10, dgv_usuarios.CurrentRow.Index].Value.ToString();
                    usuario.TipoUsuario = (String)dgv_usuarios[11, dgv_usuarios.CurrentRow.Index].Value.ToString();

                    Frm_modificar_usuario frm_admin_usuarios = new Frm_modificar_usuario(usuario);
                    frm_admin_usuarios.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void CargarDatos()
        {
            lista = blUsuario.ListarUsuarios();
            dgv_usuarios.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgv_usuarios.Rows.Add(

                    lista[i].Id_usuario,
                    lista[i].Documento,
                    lista[i].TipoDocumento,
                    lista[i].Nombres,
                    lista[i].Apellidos,
                    lista[i].Direccion,
                    lista[i].Celular,
                    lista[i].Telefono,
                    lista[i].CorreoElectronico,
                    lista[i].EstadoUsuario,
                    lista[i].EstadoClave,
                    lista[i].TipoUsuario

                );
                ;
            }
            
            dgv_usuarios.ClearSelection();
            dgv_usuarios.CurrentCell = null;

        }

        public void CargarDatoFiltro(String documento)
        {
            Usuario usuario = new Usuario();
            usuario = blUsuario.ListarUsuariosID(documento);
            dgv_usuarios.Rows.Clear();

                dgv_usuarios.Rows.Add(

                    usuario.Id_usuario,
                    usuario.Documento,
                    usuario.TipoDocumento,
                    usuario.Nombres,
                    usuario.Apellidos,
                    usuario.Direccion,
                    usuario.Celular,
                    usuario.Telefono,
                    usuario.CorreoElectronico,
                    usuario.EstadoUsuario,
                    usuario.EstadoClave,
                    usuario.TipoUsuario
                );
                
            dgv_usuarios.ClearSelection();
            dgv_usuarios.CurrentCell = null;
        }
    

        private void button7_Click(object sender, EventArgs e)
        {
            CargarDatoFiltro(Txt_busquedaCedula.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.RowCount > 0)
            {
                if (null != dgv_usuarios.CurrentRow)
                {
                    int id = (int)dgv_usuarios[0, dgv_usuarios.CurrentRow.Index].Value;

                    DialogResult response = MessageBox.Show("¿Esta seguro de eliminar el registro del usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == System.Windows.Forms.DialogResult.Yes)
                    {
                        bool flag = blUsuario.EliminarUsuario (id);
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

        private void Txt_busquedaCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
