using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class BLPago
    {
        public List<Pago> ListarPagos()
        {
            DaoPago daoPago = new DaoPago();
            return daoPago.ListaGeneral();
        }

        public List<Pago> ListarFiltro(string documento, string concepto)
        {
            DaoPago daoPago = new DaoPago();
            return daoPago.ListarFiltro(documento, concepto);
        }


        public bool InsertarPago(Pago pago)
        {
            DaoPago daoPago = new DaoPago();
            return daoPago.InsertarPago(pago);
        }
    }
}
