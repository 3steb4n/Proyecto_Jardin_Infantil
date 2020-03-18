using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows_vista.docentes;
using Windows_vista.pagos;

namespace Windows_vista
{
    public partial class Frm_administracion_estudiantes : Form
    {
        public Frm_administracion_estudiantes(Usuario usuario)
        {
            InitializeComponent();
            CargarDatos();
            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
            this.usuario = usuario;
        }


        List<Estudiante> lista = null;
        List<Grupo> lista_grupo = null;

        BLEstudiante blestudiante = new BLEstudiante();
        BLGrupo blgrupo = new BLGrupo();
        Usuario usuario;

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Frm_crear_estudiante frm_crear_estudiante = new Frm_crear_estudiante(usuario);
            frm_crear_estudiante.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (null != dgv_estudiantes.CurrentRow)
            {
                if (dgv_estudiantes.RowCount > 0)
                {
                    Estudiante estudiante = new Estudiante();

                    estudiante.Id_estudiante = (int)dgv_estudiantes[0, dgv_estudiantes.CurrentRow.Index].Value;
                    estudiante.DocumentoEstudiante = (String)dgv_estudiantes[1, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.TipoDocumento = (String)dgv_estudiantes[2, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.NombreEstudiante = (String)dgv_estudiantes[3, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.ApellidoEstudiante = (String)dgv_estudiantes[4, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.FechaNacimiento = (DateTime)dgv_estudiantes[5, dgv_estudiantes.CurrentRow.Index].Value;
                    estudiante.NombreAcudiente = (String)dgv_estudiantes[6, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.Direccion = (String)dgv_estudiantes[7, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.Genero = (String)dgv_estudiantes[8, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.TelefonoAcudiente = (String)dgv_estudiantes[9, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.CelularAcudiente = (String)dgv_estudiantes[10, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.CorreoElectronicoAcudiente = (String)dgv_estudiantes[11, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.ObservacionesEstudiante = (String)dgv_estudiantes[12, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.EstadoEstudiante = (String)dgv_estudiantes[13, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.grupo.NombreGrupo = (String)dgv_estudiantes[14, dgv_estudiantes.CurrentRow.Index].Value.ToString();
                    estudiante.grupo.IdGrupo = (int)dgv_estudiantes[15, dgv_estudiantes.CurrentRow.Index].Value;
                    estudiante.Ruta_foto = (String)dgv_estudiantes[16, dgv_estudiantes.CurrentRow.Index].Value.ToString();

                    Frm_modificar_estudiante frm_admin_usuarios = new Frm_modificar_estudiante(estudiante, usuario);
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
            lista = blestudiante.ListarEstudiante();
            dgv_estudiantes.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[0].Id_estudiante != 0)
                {
                    dgv_estudiantes.Rows.Add(

                        lista[i].Id_estudiante,
                        lista[i].DocumentoEstudiante,
                        lista[i].TipoDocumento,
                        lista[i].NombreEstudiante,
                        lista[i].ApellidoEstudiante,
                        lista[i].FechaNacimiento,
                        lista[i].NombreAcudiente,
                        lista[i].Direccion,
                        lista[i].Genero,
                        lista[i].TelefonoAcudiente,
                        lista[i].CelularAcudiente,
                        lista[i].CorreoElectronicoAcudiente,
                        lista[i].ObservacionesEstudiante,
                        lista[i].EstadoEstudiante,
                        lista[i].grupo.NombreGrupo,
                        lista[i].grupo.IdGrupo,
                        lista[i].Ruta_foto
                    );
                }
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;

            lista_grupo = blgrupo.ListarGruposNombreyID();
            combo_grupo.DataSource = lista_grupo;
            combo_grupo.DisplayMember = "NombreGrupo";
            combo_grupo.ValueMember = "IdGrupo";

            combo_grupo.SelectedItem = "Seleccione...";

        }

        public void CargarDatoFiltroDocumentoGrupo(String documento, int idGrupo)
        {
            List<Estudiante> estudiante = new List<Estudiante>();
            estudiante = blestudiante.ListarEstudiantePorDocumentoyGrupo(documento, idGrupo);
            dgv_estudiantes.Rows.Clear();

            for (int i = 0; i < estudiante.Count; i++)
            {
                if (estudiante[0].Id_estudiante != 0)
                {
                    dgv_estudiantes.Rows.Add(

                        estudiante[i].Id_estudiante,
                        estudiante[i].DocumentoEstudiante,
                        estudiante[i].TipoDocumento,
                        estudiante[i].NombreEstudiante,
                        estudiante[i].ApellidoEstudiante,
                        estudiante[i].FechaNacimiento,
                        estudiante[i].NombreAcudiente,
                        estudiante[i].Direccion,
                        estudiante[i].Genero,
                        estudiante[i].TelefonoAcudiente,
                        estudiante[i].CelularAcudiente,
                        estudiante[i].CorreoElectronicoAcudiente,
                        estudiante[i].ObservacionesEstudiante,
                        estudiante[i].EstadoEstudiante,
                        estudiante[i].grupo.NombreGrupo,
                        estudiante[i].grupo.IdGrupo,
                        estudiante[i].Ruta_foto
                    );
                }
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }

        public void CargarDatoFiltroDocumento(String documento)
        {
            List<Estudiante> estudiante = new List<Estudiante>();
            estudiante = blestudiante.ListarEstudiantePorDocumento(documento);
            dgv_estudiantes.Rows.Clear();

            for (int i = 0; i < estudiante.Count; i++)
            {
                if (estudiante[0].Id_estudiante != 0)
                {
                    dgv_estudiantes.Rows.Add(

                        estudiante[i].Id_estudiante,
                        estudiante[i].DocumentoEstudiante,
                        estudiante[i].TipoDocumento,
                        estudiante[i].NombreEstudiante,
                        estudiante[i].ApellidoEstudiante,
                        estudiante[i].FechaNacimiento,
                        estudiante[i].NombreAcudiente,
                        estudiante[i].Direccion,
                        estudiante[i].Genero,
                        estudiante[i].TelefonoAcudiente,
                        estudiante[i].CelularAcudiente,
                        estudiante[i].CorreoElectronicoAcudiente,
                        estudiante[i].ObservacionesEstudiante,
                        estudiante[i].EstadoEstudiante,
                        estudiante[i].grupo.NombreGrupo,
                        estudiante[i].grupo.IdGrupo,
                        estudiante[i].Ruta_foto
                    );
                }
            }

            dgv_estudiantes.ClearSelection();
            dgv_estudiantes.CurrentCell = null;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_estudiantes.RowCount > 0)
            {
                if (null != dgv_estudiantes.CurrentRow)
                {
                    int id = (int)dgv_estudiantes[0, dgv_estudiantes.CurrentRow.Index].Value;

                    DialogResult response = MessageBox.Show("¿Esta seguro de eliminar el registro del estudiante?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (response == System.Windows.Forms.DialogResult.Yes)
                    {
                        bool flag = blestudiante.EliminarEstudiante(id);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Txt_busquedaCedula.Text == "" && combo_grupo.Text == "Seleccione...")
            {
                CargarDatos();
            }
            else if (Txt_busquedaCedula.Text != "" && combo_grupo.Text == "Seleccione...")
            {
                CargarDatoFiltroDocumento(Txt_busquedaCedula.Text);
            }
            else
            {
                CargarDatoFiltroDocumentoGrupo(Txt_busquedaCedula.Text, IDPorNombre(combo_grupo.Text));
            }


        }

        public int IDPorNombre(String nombre)
        {
            int value = 0;

            for (int i = 0; i < lista_grupo.Count; i++)
            {
                if (lista_grupo[i].NombreGrupo == nombre)
                {
                    value = lista_grupo[i].IdGrupo;
                }
            }

            return value;
        }

        private void Btn_estudiantes_Click(object sender, EventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuario);
            frm_admin_estudiantes.Show();
            this.Close();
        }

        private void Btn_usuarios_Click(object sender, EventArgs e)
        {
            Frm_admin_docentes frm_admin_docentes = new Frm_admin_docentes(usuario);
            frm_admin_docentes.Show();
            this.Close();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Frm_inicio_sesion frm_inicio_sesion = new Frm_inicio_sesion();
            frm_inicio_sesion.Show();
            this.Close();
        }

        private void Btn_pagos_Click(object sender, EventArgs e)
        {
            Frm_admin_pagos frm_admin_pagos = new Frm_admin_pagos(usuario);
            frm_admin_pagos.Show();
            this.Close();
        }
    }

}
