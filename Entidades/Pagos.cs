using System;

namespace Entidades
{
    public class Pagos
    {
        int _idPago;
        decimal _valorMonto;
        String _descripcionPago;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        ConceptoPago _conceptoPago;
        Estudiante _estudiante;

        public Pagos()
        {

        }

        public Pagos(int idPago, decimal valorMonto, String descripcionPago, String usuarioCreacion, DateTime fechaCreacion, ConceptoPago conceptoPago, Estudiante estudiante)
        {
            this._idPago = idPago;
            this._valorMonto = valorMonto;
            this._descripcionPago = descripcionPago;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._conceptoPago = conceptoPago;
            this._estudiante = estudiante;
        }

        public int IdPago
        {
            get => _idPago;
            set => _idPago = value;
        }
        public decimal ValorMonto
        {
            get => _valorMonto;
            set => _valorMonto = value;
        }

        public String DescripcionPago
        {
            get => _descripcionPago;
            set => _descripcionPago = value;
        }
        public String UsuarioCreacion
        {
            get => _usuarioCreacion;
            set => _usuarioCreacion = value;
        }
        public DateTime FechaCreacion
        {
            get => _fechaCreacion;
            set => _fechaCreacion = value;
        }

        public ConceptoPago ConceptoPago
        {
            get => _conceptoPago;
            set => _conceptoPago = value;
        }

        public Estudiante Estudiante
        {
            get => _estudiante;
            set => _estudiante = value;
        }
    }
}
