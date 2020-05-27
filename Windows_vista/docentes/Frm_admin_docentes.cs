using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows_vista.pagos;
using Windows_vista.reportes;

namespace Windows_vista.docentes
{
    public partial class Frm_admin_docentes : Form
    {
        public Frm_admin_docentes(Usuario usuario)
        {
            InitializeComponent();
            CargarDatos();
            dgv_usuarios.ClearSelection();
            dgv_usuarios.CurrentCell = null;
            this.usuarioGestion = usuario;
        }

        List<Usuario> lista = null;
        BLUsuario blUsuario = new BLUsuario();
        Usuario usuarioGestion;

        public void CargarDatos()
        {
            lista = blUsuario.ListarDocentes();
            dgv_usuarios.Rows.Clear();

            if (lista[0].Id_usuario != 0)
            {
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
                        lista[i].EstadoClave

                    );
                    ;
                }
            }

            dgv_usuarios.ClearSelection();
            dgv_usuarios.CurrentCell = null;

        }

        public void CargarDatoFiltro(String documento)
        {
            Usuario usuario = new Usuario();
            usuario = blUsuario.ListarPorDocumentoProfesor(documento);
            dgv_usuarios.Rows.Clear();
            if (usuario.Id_usuario != 0)
            {
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
                    usuario.EstadoClave
                );
            }
            dgv_usuarios.ClearSelection();
            dgv_usuarios.CurrentCell = null;
        }

        private void Btn_estudiantes_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuarioGestion);
            frm_admin_estudiantes.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_crear_docente frm_crear_docente = new frm_crear_docente(usuarioGestion);
            frm_crear_docente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (null != dgv_usuarios.CurrentRow)
            {
                if (dgv_usuarios.RowCount > 0)
                {
                    Usuario usuario = new Usuario();

                    usuario.Id_usuario = (int)dgv_usuarios[0, dgv_usuarios.CurrentRow.Index].Value;
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

                    frm_modificar_docente frm_modificar_docente = new frm_modificar_docente(usuario, usuarioGestion);
                    frm_modificar_docente.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_admin_docentes frm_admin_docentes = new Frm_admin_docentes(usuarioGestion);
            frm_admin_docentes.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Txt_busquedaCedula.Text == "")
            {
                CargarDatos();
            }
            else
            {
                CargarDatoFiltro(Txt_busquedaCedula.Text);
            }
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
                        bool flag = blUsuario.EliminarUsuario(id);
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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_inicio_sesion frm_inicio = new Frm_inicio_sesion();
            frm_inicio.Show();
        }

        private void Btn_pagos_Click(object sender, EventArgs e)
        {
            Frm_admin_pagos frm_admin_pagos = new Frm_admin_pagos(usuarioGestion);
            frm_admin_pagos.Show();
            this.Close();
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            frm_reporte_secretaria frm = new frm_reporte_secretaria(usuarioGestion);
            frm.Show();
            this.Close();
        }
    }
}
