using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class BLConceptoPago
    {
        public List<ConceptoPago> ListarConceptos()
        {
            DaoConceptoPago daoConcepto = new DaoConceptoPago();
            return daoConcepto.ListaIDNombre();
        }
    }
}
