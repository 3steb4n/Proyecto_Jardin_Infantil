using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class BLGrupo
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

        public List<Grupo> ListarGruposNombreyID()
        {
            DaoGrupo daoGrupo = new DaoGrupo();

            return daoGrupo.ListarGruposNombreyID();
        }

        public bool InsertarGrupo(Grupo grupo)
        {
            DaoGrupo daoGrupo = new DaoGrupo();
            return daoGrupo.InsertarGrupo(grupo);
        }

        public bool ModificarGrupo(Grupo grupo)
        {
            DaoGrupo daoGrupo = new DaoGrupo();
            return daoGrupo.ModificarGrupo(grupo);
        }

        public bool EliminarGrupo(int id)
        {
            DaoGrupo daoGrupo = new DaoGrupo();
            return daoGrupo.EliminarGrupo(id);
        }
    }
}
