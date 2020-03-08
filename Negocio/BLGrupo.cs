using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    class BLGrupo
    {

        public List<Grupo> ListarGrupos()
        {
            DaoGrupo daoGrupo = new DaoGrupo();
            return daoGrupo.ListaGeneral();
        }

        public Grupo ListarGrupoPorNombre(String nombre)
        {
            DaoGrupo daoGrupo = new DaoGrupo();

            return daoGrupo.ListaPorNombre(nombre);
        }

        public bool InsertarGrupo(Grupo grupo)
        {
            DaoGrupo daoGrupo = new DaoGrupo();
            return daoGrupo.InsertarGrupo(grupo);
        }

        public bool ModificarEstudiante(Grupo grupo)
        {
            DaoGrupo daoGrupo = new DaoGrupo();
            return daoGrupo.ModificarGrupo(grupo);
        }

        public bool EliminarEstudiante(int id)
        {
            DaoGrupo daoGrupo = new DaoGrupo();
            return daoGrupo.EliminarGrupo(id);
        }
    }
}
