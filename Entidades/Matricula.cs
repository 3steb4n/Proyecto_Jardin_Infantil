using System;

namespace Entidades
{
    public class Matricula
    {
        int _id_matricula;
        int _numeromatricula;
        DateTime _anoreguistro;
        DateTime _fechacreacion;
        String _estadomatricula;
        Estudiante _estudiante;
        Grupo _grupo;

        public Matricula(){
            _estudiante = new Estudiante();
            _grupo = new Grupo();
        }

        public Matricula(int id_matricula, int numeromatricula, DateTime anoreguistro,DateTime fechacreacion, String estadomatricula, Estudiante estudiante, Grupo grupo)
        {
            this._id_matricula = id_matricula;
            this._numeromatricula = numeromatricula;
            this._anoreguistro = anoreguistro;
            this._fechacreacion = fechacreacion;
            this._estadomatricula = estadomatricula;
            this._estudiante = estudiante;
            this._grupo = grupo;
        }

        public int Id_matricula
        {
            get => _id_matricula;
            set => _id_matricula = value;
        }

        public int Numeromatricula
        {
            get => _numeromatricula;
            set => _numeromatricula = value;
        }
        
        public DateTime Anoreguistro
        {
            get => _anoreguistro;
            set => _anoreguistro = value;
        }

        public DateTime Fechacreacion 
        {
            get => _fechacreacion;
            set => _fechacreacion = value;
        }

        public string Estadomatricula
        {
            get => _estadomatricula;
            set => _estadomatricula = value;
        }

        public Estudiante estudiante
        {
            get => _estudiante;
            set => _estudiante = value;
        }

        public Grupo grupo
        {
            get => _grupo;
            set => _grupo = value;
        }
    }
}
