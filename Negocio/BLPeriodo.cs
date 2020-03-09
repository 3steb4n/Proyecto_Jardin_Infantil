using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

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
