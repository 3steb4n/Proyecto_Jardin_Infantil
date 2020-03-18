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

        public List<Estudiante> ListarEstudiantePorDocumento(String documento)
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();

            return daoEstudiante.ListaPorDocumento(documento);
        }

        public List<Estudiante> ListarEstudiantePorDocumentoyGrupo(String documento, int idGrupo)
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();

            return daoEstudiante.ListarPorDocumentoyGrupo(documento, idGrupo);
        }

        public List<Estudiante> ListarEstudiantesIdNombre()
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();

            return daoEstudiante.ListaIDyNombre();
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
