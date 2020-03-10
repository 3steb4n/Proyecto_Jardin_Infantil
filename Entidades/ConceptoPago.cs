using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConceptoPago
    {
        int _idConcepto;
        String _nombreConcepto;
        String _descripcionConcepto;
        decimal _valorConcepto;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        String _usuarioModificacion;
        DateTime _fechaModificacion;

        public ConceptoPago()
        {

        }

        public ConceptoPago(int idConcepto, String nombreConcepto, String descripcionConcepto, decimal valorConcepto, String usuarioCreacion, DateTime fechaCreacion, String usuarioModificacion, DateTime fechaModificacion)
        {
            this._idConcepto = idConcepto;
            this._nombreConcepto = nombreConcepto;
            this._descripcionConcepto = descripcionConcepto;
            this._valorConcepto = valorConcepto;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._usuarioModificacion = usuarioModificacion;
            this._fechaModificacion = fechaModificacion;
        }

        public int IdConcepto
        {
            get => _idConcepto;
            set => _idConcepto = value;
        }

        public string NombreConcepto
        {
            get => _nombreConcepto;
            set => _nombreConcepto = value;
        }

        public string DescripcionConcepto
        {
            get => _descripcionConcepto;
            set => _descripcionConcepto = value;
        }

        public decimal ValorConcepto
        {
            get => _valorConcepto;
            set => _valorConcepto = value;
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

        public String UsuarioModificacion
        {
            get => _usuarioModificacion;
            set => _usuarioModificacion = value;
        }

        public DateTime FechaModificacion
        {
            get => _fechaModificacion;
            set => _fechaModificacion = value;
        }

    }
}
