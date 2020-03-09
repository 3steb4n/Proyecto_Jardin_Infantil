using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class BLGrado
    {
        public List<Grado> ListarGados()
        {
            DaoGrado daoGrado = new DaoGrado();
            return daoGrado.ListaGeneral();
        }

    }
}
