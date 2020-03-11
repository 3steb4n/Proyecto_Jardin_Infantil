using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLEstudiante
    {

        public List<Estudiante> ListarEstudiante()
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            return daoEstudiante.ListaGeneral();
        }

        public Estudiante ListarEstudiantePorDocumento(String documento)
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
