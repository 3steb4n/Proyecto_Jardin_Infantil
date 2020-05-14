using System;

namespace Entidades
{
    public class Grado
    {
        int _idGrado;
        String _nombreGrado;
        String _descripcion;
        String _estado;

        public Grado()
        {

        }

        public Grado(int idGrado, String nombreGrado, String descripcion, String estado)
        {
            this._idGrado = idGrado;
            this._nombreGrado = nombreGrado;
            this._descripcion = descripcion;
            this._estado = estado;
        }

        public int IdGrado
        {
            get => _idGrado;
            set => _idGrado = value;
        }

        public string NombreGrado
        {
            get => _nombreGrado;
            set => _nombreGrado = value;
        }

        public string Descripcion
        {
            get => _descripcion;
            set => _descripcion = value;
        }

        public string Estado
        {
            get => _estado;
            set => _estado = value;
        }
    }
}
