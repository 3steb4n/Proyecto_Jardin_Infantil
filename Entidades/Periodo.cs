using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Periodo
    {

        int _idPeriodo;
        String _nombrePeriodo;

        public Periodo()
        {

        }

        public Periodo(int idPeriodo, String nombrePeriodo)
        {
            this._idPeriodo = idPeriodo;
            this._nombrePeriodo = nombrePeriodo;
        }

        public int IdPeriodo
        {
            get => _idPeriodo;
            set => _idPeriodo = value;
        }

        public string NombrePeriodo
        {
            get => _nombrePeriodo;
            set => _nombrePeriodo = value;
        }
    }
}
