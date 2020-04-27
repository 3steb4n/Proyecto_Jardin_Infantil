using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows_vista.estudiantes
{
    public partial class Frm_crear_matricula : Form
    {
        public Frm_crear_matricula()
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            CargarDatos();
            this.usuario = usuario;
        }

        BLMatricula blmatricula = new BLMatricula();
        BLEstudiante blEstudiante = new BLEstudiante();
        BLGrupo blGrupo = new BLGrupo();

        List<Estudiante> lista_estudiante = null;
        List<Grupo> lista = null;
        Usuario usuario;

        Random rmd = new Random();
        DateTime fechaActual = DateTime.Today;
        private void CargarDatos()
        {
            int ma = fechaActual.Year + 1;
            int numeroramdom = rmd.Next(1000, 20000);
            int newNumber = int.Parse(ma.ToString() + numeroramdom.ToString());

            Numeromatricula.Text = newNumber.ToString();

            lista_estudiante = blEstudiante.ListarEstudiantesIdNombre();
            combo_estudiante.DataSource = lista_estudiante;
            combo_estudiante.DisplayMember = "NombreEstudiante";
            combo_estudiante.ValueMember = "Id_estudiante";

            lista = blGrupo.ListarGruposNombreyID();
            combo_grupo.DataSource = lista;
            combo_grupo.DisplayMember = "NombreGrupo";
            combo_grupo.ValueMember = "IdGrupo";

        }
        
        private void guardar(Matricula matricula)
        {
            DateTime fechaActual = DateTime.Today;
            

            matricula.Numeromatricula = Convert.ToInt32(Numeromatricula.Text);
            matricula.Anoreguistro = date_fecha.Value.Date;
            matricula.Fechacreacion = fechaActual;
            matricula.estudiante.Id_estudiante = idPorNombreEstudiante(combo_estudiante.Text);
            matricula.grupo.IdGrupo = IDPorNombre(combo_grupo.Text);

            bool bandera = blmatricula.InsertarMatriculas(matricula);

            if (bandera)
            {
                MessageBox.Show("Matricula creada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int idPorNombreEstudiante(String nombree)
        {
            int value = 0;
            for (int i = 0; i < lista_estudiante.Count; i++)
            {
                if (lista_estudiante[i].NombreEstudiante == nombree)
                {
                    value = lista_estudiante[i].Id_estudiante;
                }
            }

            return value;
        }


        private void Frm_crear_matricula_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Matricula matricula = new Matricula();
                guardar(matricula);
            }
        }
    }
}
