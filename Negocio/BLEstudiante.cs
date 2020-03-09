using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class BLEstudiante
    {

        public List<Estudiante> ListarEstudiante()
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            return daoEstudiante.ListaGeneral();
        }

        public Estudiante ListarEstudianteID(String documento)
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();

            return daoEstudiante.ListaPorDocumento(documento);
        }

        public bool InsertarEstudiante(Estudiante estudiante)
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            return daoEstudiante.InsertarEstudiante(estudiante);
        }

        public bool ModificarEstudiante(Estudiante estudiante)
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            return daoEstudiante.ModificarEstudiante(estudiante);
        }

        public bool EliminarEstudiante(int id)
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            return daoEstudiante.EliminarEstudiante(id);
        }
    }
}
