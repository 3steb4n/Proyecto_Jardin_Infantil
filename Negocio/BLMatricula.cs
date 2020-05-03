using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLMatricula
    {
        public List<Matricula> ListarMatricula()
        {
            DaoMatricula daoMatricula = new DaoMatricula();
            return daoMatricula.ListaGeneral();
        }


        public List<Matricula> ListarMatriculaporDocumento(String documento)
        {
            DaoMatricula daoMatricula = new DaoMatricula();

            return daoMatricula.ListaPorDocumento(documento);

        }

        public List<Matricula> ListarMatriculasPorGrupo(int idGrupo)
        {
            DaoMatricula daoMatricula = new DaoMatricula();

            return daoMatricula.ListarPorGrupo(idGrupo);
        }

        public List<Matricula> ListarMatriculasPorDocumentoyGrupo(String documento, int idGrupo)
        {
            DaoMatricula daoMatricula = new DaoMatricula();

            return daoMatricula.ListarPorDocumentoyGrupo(documento, idGrupo);
        }

        public bool InsertarMatriculas(Matricula matricula)
        {
            DaoMatricula daoMatricula = new DaoMatricula();
            return daoMatricula.InsertarMatricula(matricula);
        }
    }
}
