using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista
{
    public partial class Frm_modificar_estudiante : Form
    {
        public Frm_modificar_estudiante(Estudiante estudiante, Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            cargarDatos(estudiante);
            id_Estudiante = estudiante.Id_estudiante;
            this.usuario = usuario;
        }

        int id_Estudiante;
        BLEstudiante blEstudiante = new BLEstudiante();
        BLGrupo blGrupo = new BLGrupo();
        List<Grupo> lista = null;
        Usuario usuario;

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
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuario);
            frm_admin_estudiantes.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.Enabled))
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
                estudiante.Ruta_foto = Txt_foto.Text;
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

        private void Txt_numero_documento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_numero_documento.Text == "" || Txt_numero_documento.Text == "0")
            {
                e.Cancel = true;
                errorNum.SetError(Txt_numero_documento, "Introdusca numero de documento");
                Txt_nombres.Focus();
            }
            else if (!Regex.IsMatch(Txt_numero_documento.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorNum.SetError(Txt_numero_documento, "Solo numeros");
                Txt_numero_documento.Focus();
            }
            else
            {
                errorNum.Clear();
            }
        }

        private void Combo_tipo_documento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Combo_tipo_documento.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorTipoDocumento.SetError(Combo_tipo_documento, "Seleccione el tipo de documento");
                Combo_tipo_documento.Focus();
            }
            else
            {
                errorTipoDocumento.Clear();
            }
        }

        private void Txt_nombres_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_nombres.Text == "")
            {
                e.Cancel = true;
                errorNombres.SetError(Txt_nombres, "Ingrese nombre");
                Txt_nombres.Focus();
            }
            else if (!Regex.IsMatch(Txt_nombres.Text, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                errorNombres.SetError(Txt_nombres, "Solo letras");
                Txt_nombres.Focus();
            }
            else
            {
                errorNombres.Clear();
            }
        }

        private void Txt_apellidos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_apellidos.Text == "")
            {
                e.Cancel = true;
                errorApellidos.SetError(Txt_apellidos, "Ingrese apellido");
                Txt_apellidos.Focus();
            }
            else if (!Regex.IsMatch(Txt_apellidos.Text, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                errorApellidos.SetError(Txt_apellidos, "Solo letras");
                Txt_apellidos.Focus();
            }
            else
            {
                errorApellidos.Clear();
            }
        }

        private void combo_genero_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_genero.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorTipoDocumento.SetError(combo_genero, "Seleccione el genero del estudiante");
                combo_genero.Focus();
            }
            else
            {
                errorTipoDocumento.Clear();
            }
        }

        private void Txt_direccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_direccion.Text == "")
            {
                e.Cancel = true;
                errorDireccion.SetError(Txt_direccion, "Ingrese la dirección");
                Txt_direccion.Focus();
            }
            else
            {
                errorDireccion.Clear();
            }
        }

        private void Txt_correo_electronico_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_correo_electronico.Text == "")
            {
                e.Cancel = true;
                errorCorreoElectronico.SetError(Txt_correo_electronico, "Ingrese el correo electrónico");
                Txt_correo_electronico.Focus();
            }
            else if (!Regex.IsMatch(Txt_correo_electronico.Text, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))
            {
                e.Cancel = true;
                errorCorreoElectronico.SetError(Txt_correo_electronico, "Dirección de correo electrónico no valida");
                Txt_correo_electronico.Focus();
            }
            else
            {
                errorCorreoElectronico.Clear();
            }
        }

        private void Txt_telefono_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_telefono.Text == "" || Txt_telefono.Text == "0")
            {
                e.Cancel = true;
                errorTelefono.SetError(Txt_telefono, "Ingrese el numero de telefono");
                Txt_telefono.Focus();
            }
            else if (!Regex.IsMatch(Txt_telefono.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorTelefono.SetError(Txt_telefono, "Solo numeros");
                Txt_telefono.Focus();
            }
            else
            {
                errorTelefono.Clear();
            }
        }

        private void Txt_celular_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_celular.Text == "" || Txt_celular.Text == "0")
            {
                e.Cancel = true;
                errorCelular.SetError(Txt_celular, "Ingrese el numero de celular");
                Txt_celular.Focus();
            }
            else if (!Regex.IsMatch(Txt_celular.Text, @"[0-9]{1,9}(\.[0-9]{0,2})?$"))
            {
                e.Cancel = true;
                errorCelular.SetError(Txt_celular, "Solo numeros");
                Txt_celular.Focus();
            }
            else
            {
                errorCelular.Clear();
            }
        }

        private void Txt_nombre_acudiente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_nombre_acudiente.Text == "")
            {
                e.Cancel = true;
                errorNombreAcudiente.SetError(Txt_nombre_acudiente, "Ingrese nombre");
                Txt_nombre_acudiente.Focus();
            }
            else if (!Regex.IsMatch(Txt_nombre_acudiente.Text, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                errorNombreAcudiente.SetError(Txt_nombre_acudiente, "Solo letras");
                Txt_nombre_acudiente.Focus();
            }
            else
            {
                errorNombreAcudiente.Clear();
            }
        }

        private void Txt_foto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_foto.Text == "")
            {
                e.Cancel = true;
                errorGrupo.SetError(Txt_foto, "Seleccione la foto");
                Txt_foto.Focus();
            }
            else
            {
                errorGrupo.Clear();
            }
        }

        private void Txt_observaciones_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Txt_observaciones.Text == "")
            {
                e.Cancel = true;
                errorObservaciones.SetError(Txt_observaciones, "Ingrese las observaciones");
                Txt_observaciones.Focus();
            }
            else
            {
                errorObservaciones.Clear();
            }
        }

        private void combo_grupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (combo_grupo.Text == "Seleccione...")
            {
                e.Cancel = true;
                errorGrupo.SetError(combo_grupo, "Seleccione el grupo del estudiante");
                combo_grupo.Focus();
            }
            else
            {
                errorGrupo.Clear();
            }
        }
    }
}
