using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Logro
    {
        int _idLogro;
        String _nombreLogro;
        String _descripcionLogro;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        String _usuarioModificacion;
        DateTime _fechaModificacion;
        String _estadoLogro;
        Materias _materia;

        public Logro(int idLogro, String nombreLogro, String descripcionLogro, String usuarioCreacion, DateTime fechaCreacion, String usuarioModificacion, DateTime fechaModificacion, String estadoLogro, Materias materia)
        {
            this._idLogro = idLogro;
            this._nombreLogro = nombreLogro;
            this._descripcionLogro = descripcionLogro;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._usuarioModificacion = usuarioModificacion;
            this._fechaModificacion = fechaModificacion;
            this._estadoLogro = estadoLogro;
            this._materia = materia;
        }

        public Logro()
        {
            _materia = new Materias();
        }

        public int IdLogro
        {
            get => _idLogro;
            set => _idLogro = value;
        }
        public string NombreLogro
        {
            get => _nombreLogro;
            set => _nombreLogro = value;
        }

        public string DescripcionLogro
        {
            get => _descripcionLogro;
            set => _descripcionLogro = value;
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

        public string UsuarioModificacion
        {
            get => _usuarioModificacion;
            set => _usuarioModificacion = value;
        }

        public DateTime FechaModificacion
        {
            get => _fechaModificacion;
            set => _fechaModificacion = value;
        }

        public string EstadoLogro
        {
            get => _estadoLogro;
            set => _estadoLogro = value;
        }

        public Materias Materia
        {
            get => _materia;
            set => _materia = value;
        }

    }
}
