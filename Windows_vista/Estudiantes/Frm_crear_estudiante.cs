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
    public partial class Frm_crear_estudiante : Form
    {
        public Frm_crear_estudiante()
        {
            InitializeComponent();
            CargarDatos();
        }

        BLEstudiante blEstudiante = new BLEstudiante();
        BLGrupo blGrupo = new BLGrupo();
        List<Grupo> lista = null;

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

            lista = blGrupo.ListarGruposNombreyID();
            combo_grupo.DataSource = lista;
            combo_grupo.DisplayMember = "NombreGrupo";
            combo_grupo.ValueMember = "IdGrupo";

        }

        private void Frm_crear_estudiante_Load(object sender, EventArgs e)
        {

        }

        private void Frm_crear_estudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_administracion_estudiantes frm_admin_estudiantes = new Frm_administracion_estudiantes();
            frm_admin_estudiantes.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Estudiante estudiante = new Estudiante();

                guardar(estudiante);

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
            estudiante.grupo.IdGrupo = IDPorNombre(combo_grupo.Text);

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

        private void Combo_tipo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {

            bool flag = true;
            if (Txt_numero_documento.Text == "")
            {
                errorProvider.SetError(Txt_numero_documento, "Introdusca numero de documento");
                Txt_numero_documento.Focus();
                flag = false;
            }
            if (Combo_tipo_documento.Text == "")
            {
                errorProvider.SetError(Combo_tipo_documento, "Seleccione...");
                Combo_tipo_documento.Focus();
                flag = false;
            }
            if (Txt_nombres.Text == "")
            {
                errorProvider.SetError(Txt_nombres, "Ingrese nombre");
                Txt_nombres.Focus();
                flag = false;
            }
            if (Txt_apellidos.Text == "")
            {
                errorProvider.SetError(Txt_apellidos, "Ingrese apellido");
                Txt_apellidos.Focus();
                flag = false;
            }
            if (combo_genero.Text == "")
            {
                errorProvider.SetError(Txt_nombres, "Seleccione genero");
                combo_genero.Focus();
                flag = false;
            }
            if (Txt_direccion.Text == "")
            {
                errorProvider.SetError(Txt_direccion, "Ingrese dirección");
                Txt_direccion.Focus();
                flag = false;
            }
            if (Txt_correo_electronico.Text == "")
            {
                errorProvider.SetError(Txt_correo_electronico, "Ingrese el correo electrónico");
                Txt_correo_electronico.Focus();
                flag = false;
            }
            if (Txt_telefono.Text == "")
            {
                errorProvider.SetError(Txt_telefono, "Ingrese el telefono acudiente");
                Txt_telefono.Focus();
                flag = false;
            }
            if (Txt_celular.Text == "")
            {
                errorProvider.SetError(Txt_celular, "Ingrese el celular acudiente");
                Txt_celular.Focus();
                flag = false;
            }
            if (Txt_nombre_acudiente.Text == "")
            {
                errorProvider.SetError(Txt_nombre_acudiente, "Ingrese el nombre del acudiente");
                Txt_nombre_acudiente.Focus();
                flag = false;
            }
            if (Txt_observaciones.Text == "")
            {
                errorProvider.SetError(Txt_observaciones, "Ingrese las observaciones");
                Txt_observaciones.Focus();
                flag = false;
            }
            if (Txt_foto.Text == "")
            {
                errorProvider.SetError(Txt_foto, "Seleccione la foto");
                Txt_observaciones.Focus();
                flag = false;
            }
            return flag;
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

        private void combo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_foto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
