using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_modificar_estudiante : Form
    {
        public Frm_modificar_estudiante(Estudiante estudiante)
        {
            InitializeComponent();
            cargarDatos(estudiante);
            id_Estudiante = estudiante.Id_estudiante;
        }

        int id_Estudiante;
        BLEstudiante blEstudiante = new BLEstudiante();
        BLGrupo blGrupo = new BLGrupo();
        List<Grupo> lista = null;

        public void cargarDatos(Estudiante estudiante)
        {


            // se llenan valores fijos de los tipos de documentos
            Combo_tipo_documento.Items.Add("Seleccione...").ToString();
            Combo_tipo_documento.Items.Add("Registro civil").ToString();
            Combo_tipo_documento.Items.Add("Tarjeta de identidad").ToString();
            Combo_tipo_documento.Items.Add("DNI").ToString();
            Combo_tipo_documento.Items.Add("DNI").ToString();
            Combo_tipo_documento.Items.Add("Cedula de extranjeria").ToString();


            // se llenan valores fijos de los tipos de documentos
            combo_genero.Items.Add("Seleccione...").ToString();
            combo_genero.Items.Add("Femenino").ToString();
            combo_genero.Items.Add("Masculino").ToString();


            lista = blGrupo.ListarGruposNombreyID();

            for (int i = 0; i < lista.Count; i++)
            {
                combo_grupo.Items.Add(lista[i].NombreGrupo).ToString();
            }

            Txt_numero_documento.Text = estudiante.DocumentoEstudiante;
            Combo_tipo_documento.SelectedItem = estudiante.TipoDocumento;
            date_fecha.Value = estudiante.FechaNacimiento;
            Txt_nombres.Text = estudiante.NombreEstudiante;
            Txt_apellidos.Text = estudiante.ApellidoEstudiante;
            combo_genero.SelectedItem = estudiante.Genero;
            Txt_direccion.Text = estudiante.Direccion;
            Txt_correo_electronico.Text = estudiante.CorreoElectronicoAcudiente;
            Txt_telefono.Text = estudiante.TelefonoAcudiente;
            Txt_celular.Text = estudiante.CelularAcudiente;
            Txt_nombre_acudiente.Text = estudiante.NombreAcudiente;
            Txt_observaciones.Text = estudiante.ObservacionesEstudiante;
            combo_grupo.SelectedItem = estudiante.grupo.NombreGrupo;
            Txt_foto.Text = estudiante.Ruta_foto;
        }

        private void Frm_modificar_estudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes();
            frm_admin_estudiantes.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            DateTime fechaActual = DateTime.Today;

            estudiante.Id_estudiante = id_Estudiante;
            estudiante.DocumentoEstudiante = Txt_numero_documento.Text;
            estudiante.TipoDocumento = OrdenarTipoDocumento(Combo_tipo_documento.Text);
            estudiante.FechaNacimiento = date_fecha.Value;
            estudiante.NombreEstudiante = Txt_nombres.Text;
            estudiante.ApellidoEstudiante = Txt_apellidos.Text;
            estudiante.Genero = OrdenarGenero(combo_genero.Text);
            estudiante.Direccion = Txt_direccion.Text;
            estudiante.CorreoElectronicoAcudiente = Txt_correo_electronico.Text;
            estudiante.TelefonoAcudiente = Txt_telefono.Text;
            estudiante.CelularAcudiente = Txt_celular.Text;
            estudiante.NombreAcudiente = Txt_nombre_acudiente.Text;
            estudiante.Ruta_foto = Txt_direccion.Text;
            estudiante.ObservacionesEstudiante = Txt_observaciones.Text;
            estudiante.UsuarioModificacion = "1";
            estudiante.FechaModificacion = fechaActual;
            estudiante.grupo.IdGrupo = IDPorNombre(combo_grupo.Text);


            bool flag = blEstudiante.ModificarEstudiante(estudiante);
            if (flag)
            {
                MessageBox.Show("Estudiante modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].NombreGrupo == nombre)
                {
                    value = lista[i].IdGrupo;
                }
            }

            return value;
        }

        public String OrdenarTipoDocumento(String tipoDocumento)
        {
            String value = "";

            if (tipoDocumento == "Registro civil")
            {
                value = "RC";

            }
            else if (tipoDocumento == "Tarjeta de identidad")
            {
                value = "TI";
            }
            else if (tipoDocumento == "DNI")
            {
                value = "DNI";
            }

            return value;
        }


        public String OrdenarGenero(String genero)
        {
            String value = "";

            if (genero == "Femenino")
            {
                value = "F";

            }
            else
            {
                value = "M";
            }

            return value;
        }



        public Usuario Ordenar(Usuario usuario)
        {
            // formato a combobox tipo documento


            // formato a combobox tipo usuario

            if (usuario.TipoUsuario == "Administrador")
            {
                usuario.TipoUsuario = "A";
            }
            else if (usuario.TipoUsuario == "Docente")
            {
                usuario.TipoUsuario = "D";
            }
            else if (usuario.TipoUsuario == "Secretaria")
            {
                usuario.TipoUsuario = "S";
            }

            // ordenar estado usuario
            if (usuario.EstadoUsuario == "Activo")
            {
                usuario.EstadoUsuario = "A";
            }
            else
            {
                usuario.EstadoUsuario = "I";
            }

            // ordenar estado clave

            if (usuario.EstadoClave == "Cambiada")
            {
                usuario.EstadoClave = "C";
            }
            else
            {
                usuario.EstadoClave = "S";
            }
            return usuario;

        }

    }
}
