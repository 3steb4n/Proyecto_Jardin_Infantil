using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class BLMateria
    {
        public List<Materia> ListarMateria()
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.ListaGeneral();
        }

        public Materia ListarMateriaPorNombre(String nombre)
        {
            DaoMateria daoMateria = new DaoMateria();

            return daoMateria.ListaPorNombre(nombre);
        }

        public bool InsertarMateria(Materia materia)
        {
            DaoMateria daoMateria = new DaoMateria();
            return daoMateria.InsertarMateria(materia);
        }

        public bool ModificarMateria(Materia materia)
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
