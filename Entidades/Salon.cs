using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salon
    {

        int _idSalon;
        String _nombreSalon;

        public Salon()
        {

        }

        public Salon(int idSalon, String nombreSalon)
        {
            this._idSalon = idSalon;
            this._nombreSalon = nombreSalon;
        }

        public int IdSalon
        {
            get => _idSalon;
            set => _idSalon = value;
        }

        public String NombreSalon
        {
            get => _nombreSalon;
            set => _nombreSalon = value;
        }
    }
}
