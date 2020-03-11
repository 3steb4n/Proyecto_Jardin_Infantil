using Datos;
using Entidades;
using System.Collections.Generic;

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
