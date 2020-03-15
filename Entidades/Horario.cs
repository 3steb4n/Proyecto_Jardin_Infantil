using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Horario
    {

        int _idHorario;
        Salon _salon;
        Bloque _bloque;
        Grupo _grupo;
        Materiaa _materia;
        Usuario _usuario;

        public Horario()
        {

        }

        public Horario (int idHorario, Salon salon, Bloque bloque, Grupo grupo, Materiaa materia, Usuario usuario)
        {
            this._idHorario = idHorario;
            this._salon = salon;
            this._bloque = bloque;
            this._grupo = grupo;
            this._materia = materia;
            this._usuario = usuario;
        }

        public int IdHorario
        {
            get => _idHorario;
            set => _idHorario = value;
        }

        public Salon Salon
        {
            get => _salon;
            set => _salon = value;
        }

        public Bloque Bloque
        {
            get => _bloque;
            set => _bloque = value;
        }

        public Grupo Grupo
        {
            get => _grupo;
            set => _grupo = value;
        }

        public Materiaa Materiaa
        {
            get => _materia;
            set => _materia = value;
        }

        public Usuario Usuario
        {
            get => _usuario;
            set => _usuario = value;
        }
    }
}
