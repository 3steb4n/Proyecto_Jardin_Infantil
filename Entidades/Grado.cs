using System;

namespace Entidades
{
    public class Grado
    {
        int _idGrado;
        String _nombreGrado;

        public Grado()
        {

        }

        public Grado(int idGrado, String nombreGrado)
        {
            this._idGrado = idGrado;
            this._nombreGrado = nombreGrado;
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
    }
}
