using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class BLAbonoPago
    {
        public List<AbonoPago> ListarAbonos(int idPago)
        {
            DaoAbonoPago daoAbonoPago = new DaoAbonoPago();
            return daoAbonoPago.ListaGeneral(idPago);
        }

        public int ValorAbonado(int idPago)
        {
            DaoAbonoPago daoAbonoPago = new DaoAbonoPago();
            return daoAbonoPago.ValorAbonado(idPago);
        }

        public bool InsertarAbono(AbonoPago abono)
        {
            DaoAbonoPago daoAbonoPago = new DaoAbonoPago();
            return daoAbonoPago.InsertarAbono(abono);
        }
    }
}
