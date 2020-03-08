using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        int _idGrupo;
        String _codigGrupo;
        String _nombreGrupo;
        String _descripcionGrupo;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        String _usuarioModificacion;
        DateTime _fechaModificacion;
        String _estadoGrupo;
        int _idgrado;

        public Grupo()
        {

        }

        public Grupo(int idGrupo, String codigoCrupo, String nombreGrupo, String descripcionGrupo, String usuarioCreacion, DateTime fechaCreacion, String usuarioModificacion, DateTime fechaModificacion, String estadoGrupo, int idgrado)
        {
            this._idGrupo = idGrupo;
            this._codigGrupo = codigoCrupo;
            this._nombreGrupo = nombreGrupo;
            this._descripcionGrupo = descripcionGrupo;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._usuarioModificacion = usuarioModificacion;
            this._fechaModificacion = fechaModificacion;
            this._usuarioModificacion = usuarioModificacion;
            this._fechaModificacion = fechaModificacion;
            this._estadoGrupo = estadoGrupo;
            this._idgrado = idgrado;
        }

        public int IdGrupo
        {
            get => _idGrupo;
            set => _idGrupo = value;
        }

        public string CodigGrupo
        {
            get => _codigGrupo;
            set => _codigGrupo = value;
        }

        public string NombreGrupo
        {
            get => _nombreGrupo;
            set => _nombreGrupo = value;
        }
        public string DescripcionGrupo
        {
            get => _descripcionGrupo;
            set => _descripcionGrupo = value;
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

        public String EstadoGrupo
        {
            get => _estadoGrupo;
            set => _estadoGrupo = value;
        }

        public int Idgrado
        {
            get => _idgrado;
            set => _idgrado = value;
        }

    }
}
