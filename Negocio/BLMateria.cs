using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLMateria
    {
        public List<Materiaa> ListarMateria()
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.ListaGeneral();
        }

        public List<Materiaa> ListarIdNombre()
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.ListarIdNombre();
        }


        public Materiaa ListarMateriaPorNombre(String nombre)
        {
            DaoMateria daoMateria = new DaoMateria();

            return daoMateria.ListaPorNombre(nombre);
        }

        public bool InsertarMateria(Materiaa materia)
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.InsertarMateria(materia);
        }

        public bool ModificarMateria(Materiaa materia)
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
