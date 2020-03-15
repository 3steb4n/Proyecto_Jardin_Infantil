using System;

namespace Entidades
{
    public class Materiaa
    {
        int _idMateria;
        String _nombreMateria;
        String _descripcionMateria;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        String _usuarioModificacion;
        DateTime _fechaModificacion;
        String _estadoMateria;
        int _numeroHorasMaterias;
        Area _area;
        Grado _grado;

        public Materiaa()
        {
            _area = new Area();
            _grado = new Grado();
        }

        public Materiaa(int idMateria, String nombreMateria, String descripcionMateria, String usuarioCreacion, DateTime fechaCreacion, String usuarioModificacion, DateTime fechaModificacion, String estadoMateria, int numeroHorasMaterias, Area area, Grado grado)
        {
            this._idMateria = idMateria;
            this._nombreMateria = nombreMateria;
            this._descripcionMateria = descripcionMateria;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._usuarioModificacion = usuarioModificacion;
            this._fechaModificacion = fechaModificacion;
            this._estadoMateria = estadoMateria;
            this._numeroHorasMaterias = numeroHorasMaterias;
            this._area = area;
            this._grado = grado;
        }

        public int IdMateria
        {
            get => _idMateria;
            set => _idMateria = value;
        }
        public string NombreMateria
        {
            get => _nombreMateria;
            set => _nombreMateria = value;
        }

        public string DescripcionMateria
        {
            get => _descripcionMateria;
            set => _descripcionMateria = value;
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
            get => _fechaCreacion;
            set => _fechaCreacion = value;
        }

        public string EstadoMateria
        {
            get => _estadoMateria;
            set => _estadoMateria = value;
        }

        public int NumeroHorasMaterias
        {
            get => _numeroHorasMaterias;
            set => _numeroHorasMaterias = value;
        }

        public Area Area
        {
            get => _area;
            set => _area = value;
        }

        public Grado Grado
        {
            get => _grado;
            set => _grado = value;
        }

    }
}
