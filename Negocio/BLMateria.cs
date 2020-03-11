using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLMateria
    {
        public List<Materias> ListarMateria()
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.ListaGeneral();
        }

        public List<Materias> ListarIdNombre()
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.ListarIdNombre();
        }


        public Materias ListarMateriaPorNombre(String nombre)
        {
            DaoMateria daoMateria = new DaoMateria();

            return daoMateria.ListaPorNombre(nombre);
        }

        public bool InsertarMateria(Materias materia)
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.InsertarMateria(materia);
        }

        public bool ModificarMateria(Materias materia)
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.ModificarMateria(materia);
        }

        public bool EliminarMateria(int id)
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.EliminarMateria(id);
        }

    }
}
