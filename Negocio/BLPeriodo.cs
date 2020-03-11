using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class BLPeriodo
    {
        public List<Periodo> ListarAreas()
        {
            DaoPeriodo daoPeriodo = new DaoPeriodo();
            return daoPeriodo.ListaGeneral();
        }
    }
}
