using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Area
    {
        int _idArea;
        String _nombreArea;

        public Area()
        {

        }

        public Area(int idArea, String nombreArea)
        {
            this._idArea = idArea;
            this._nombreArea = nombreArea;
        }

        public int IdArea
        {
            get => _idArea;
            set => _idArea = value;
        }

        public string NombreArea
        {
            get => _nombreArea;
            set => _nombreArea = value;
        }
    }
}
