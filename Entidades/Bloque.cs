using System;

namespace Entidades
{
    public class Bloque
    {
        int _idBloque;
        String _nombreBloque;

        public Bloque()
        {

        }

        public Bloque(int idBloque, String nombreBloque)
        {
            this._idBloque = idBloque;
            this._nombreBloque = nombreBloque;
        }

        public int IdBloque
        {
            get => _idBloque;
            set => _idBloque = value;
        }

        public String NombreBloque
        {
            get => _nombreBloque;
            set => _nombreBloque = value;
        }
    }
}
