using System;

namespace Entidades
{
    public class Pago
    {
        int _idPago;
        int _valorMonto;
        String _descripcionPago;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        ConceptoPago _conceptoPago;
        Usuario _usuario;
        Estudiante _estudiante;

        public Pago()
        {
            _conceptoPago = new ConceptoPago();
            _usuario = new Usuario();
            _estudiante = new Estudiante();

        }

        public Pago(int idPago, int valorMonto, String descripcionPago, String usuarioCreacion, DateTime fechaCreacion, ConceptoPago conceptoPago, Usuario usuario, Estudiante estudiante)
        {
            this._idPago = idPago;
            this._valorMonto = valorMonto;
            this._descripcionPago = descripcionPago;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._conceptoPago = conceptoPago;
            this._usuario = usuario;
            this._estudiante = estudiante;
        }

        public int IdPago
        {
            get => _idPago;
            set => _idPago = value;
        }
        public int ValorMonto
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

        public Usuario Usuario
        {
            get => _usuario;
            set => _usuario = value;
        }

        public Estudiante Estudiante
        {
            get => _estudiante;
            set => _estudiante = value;
        }
    }
}
