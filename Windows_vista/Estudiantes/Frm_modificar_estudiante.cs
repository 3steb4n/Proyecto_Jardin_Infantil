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
    }
}
