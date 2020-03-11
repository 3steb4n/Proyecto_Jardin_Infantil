using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class BLArea
    {
        public List<Area> ListarAreas()
        {
            DaoArea daoArea = new DaoArea();
            return daoArea.ListaGeneral();
        }
    }
}
