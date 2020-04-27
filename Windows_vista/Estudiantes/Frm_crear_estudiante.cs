using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Windows_vista.estudiantes;

namespace Windows_vista
{
    public partial class Frm_crear_estudiante : Form
    {
        public Frm_crear_estudiante(Usuario usuario)
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            CargarDatos();
            this.usuario = usuario;
        }

        BLEstudiante blEstudiante = new BLEstudiante();
        Usuario usuario;

        private void CargarDatos()
        {
            ComboboxItem item_td1 = new ComboboxItem(); item_td1.Text = "Seleccione..."; item_td1.Value = "";
            ComboboxItem item_td2 = new ComboboxItem(); item_td2.Text = "Registro Civil"; item_td2.Value = "RC";
            ComboboxItem item_td3 = new ComboboxItem(); item_td3.Text = "Tarjeta de identidad"; item_td3.Value = "TI";
            ComboboxItem item_td4 = new ComboboxItem(); item_td4.Text = "DNI"; item_td4.Value = "DNI";
            Object[] items_td = new Object[4];
            items_td[0] = item_td1;
            items_td[1] = item_td2;
            items_td[2] = item_td3;
            items_td[3] = item_td4;
            Combo_tipo_documento.Items.AddRange(items_td);
            Combo_tipo_documento.SelectedIndex = 0;


            ComboboxItem item_g1 = new ComboboxItem(); item_g1.Text = "Seleccione..."; item_g1.Value = "";
            ComboboxItem item_g2 = new ComboboxItem(); item_g2.Text = "Femenino"; item_g2.Value = "F";
            ComboboxItem item_g3 = new ComboboxItem(); item_g3.Text = "Masculino"; item_g3.Value = "M";
            Object[] items_g = new Object[3];
            items_g[0] = item_g1;
            items_g[1] = item_g2;
            items_g[2] = item_g3;

            combo_genero.Items.AddRange(items_g);
            combo_genero.SelectedIndex = 0;


        }

        private void Frm_crear_estudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes(usuario);
            frm_admin_estudiantes.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Estudiante estudiante = new Estudiante();

                guardar(estudiante);
                Frm_crear_matricula frm_crear_matricula = new Frm_crear_matricula();
                frm_crear_matricula.Show();
            }
        }

        private void guardar(Estudiante estudiante)
        {
            DateTime fechaActual = DateTime.Today;

            estudiante.DocumentoEstudiante = Txt_numero_documento.Text;
            estudiante.TipoDocumento = (Combo_tipo_documento.SelectedItem as ComboboxItem).Value.ToString();
            estudiante.FechaNacimiento = date_fecha.Value.Date;
            estudiante.NombreEstudiante = Txt_nombres.Text;
            estudiante.ApellidoEstudiante = Txt_apellidos.Text;
            estudiante.Genero = (combo_genero.SelectedItem as ComboboxItem).Value.ToString();
            estudiante.Direccion = Txt_direccion.Text;
            estudiante.CorreoElectronicoAcudiente = Txt_correo_electronico.Text;
            estudiante.TelefonoAcudiente = Txt_telefono.Text;
            estudiante.CelularAcudiente = Txt_telefono.Text;
            estudiante.NombreAcudiente = Txt_nombre_acudiente.Text;
            estudiante.ObservacionesEstudiante = Txt_observaciones.Text;
            estudiante.UsuarioCreacion = "1";
            estudiante.FechaCreacion = fechaActual;
            estudiante.Ruta_foto = Txt_foto.Text;

            bool bandera = blEstudiante.InsertarEstudiante(estudiante);

            if (bandera)
            {
                MessageBox.Show("Estudiante creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
