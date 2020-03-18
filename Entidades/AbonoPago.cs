using System;

namespace Entidades
{
    public class AbonoPago
    {
        int _idAbonoPago;
        String _tipoAbono;
        int _valorAbono;
        String _descripcionAbono;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        Pago _pago;
        Usuario _usuario;

        public AbonoPago()
        {
            _usuario = new Usuario();
            _pago = new Pago();
        }

        public AbonoPago(int idAbonoPago, String tipoAbono, int valorAbono, String descripcionAbono, String usuarioCreacion, DateTime fechaCreacion, Pago pago, Usuario usuario)
        {
            this._idAbonoPago = idAbonoPago;
            this._tipoAbono = tipoAbono;
            this._valorAbono = valorAbono;
            this._descripcionAbono = descripcionAbono;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._pago = pago;
            this._usuario = usuario;
        }

        public int IdAbonoPago
        {
            get => _idAbonoPago;
            set => _idAbonoPago = value;
        }

        public string TipoAbono
        {
            get => _tipoAbono;
            set => _tipoAbono = value;
        }

        public int ValorAbono
        {
            get => _valorAbono;
            set => _valorAbono = value;
        }

        public string DescripcionAbono
        {
            get => _descripcionAbono;
            set => _descripcionAbono = value;
        }

        public string UsuarioCreacion
        {
            get => _usuarioCreacion;
            set => _usuarioCreacion = value;
        }

        public DateTime FechaCreacion
        {
            get => _fechaCreacion;
            set => _fechaCreacion = value;
        }

        public Pago Pago
        {
            get => _pago;
            set => _pago = value;
        }

        public Usuario usuario
        {
            get => _usuario;
            set => _usuario = value;
        }
    }
}
