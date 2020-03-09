using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        int _id_estudiante;
        String _documentoEstudiante;
        String _tipoDocumento;
        String _nombreEstudiante;
        String _apellidoEstudiante;
        DateTime _fechaNacimiento;
        String _ruta_foto;
        String _nombreAcudiente;
        String _direccion;
        String _genero;
        String _telefonoAcudiente;
        String _celularAcudiente;
        String _correoElectronicoAcudiente;
        String _observacionesEstudiante;
        String _usuarioCreacion;
        DateTime _fechaCreacion;
        String _usuarioModificacion;
        DateTime _fechaModificacion;
        String _estadoEstudiante;
        Grupo _grupo;


        public Estudiante()
        {
            grupo = new Grupo();
        }

        public Estudiante(int id_estudiante,String documentoEstudiante,String tipoDocumento,String nombreEstudiante,String apellidoEstudiante, DateTime fechaNacimiento, String ruta_foto, String nombreAcudiente, String direccion,String genero,String telefonoAcudiente,String celularAcudiante,String correoElectronicoAcudiente,String observacionesEstudiante,String usuarioCreacion,DateTime fechaCreacion, String usuarioModificacion, DateTime fechaModificacion, String EstadoEstudiante, Grupo grupo)
        {
            this._id_estudiante = id_estudiante;
            this._documentoEstudiante = documentoEstudiante;
            this._tipoDocumento = tipoDocumento;
            this._nombreEstudiante = nombreEstudiante;
            this._apellidoEstudiante = apellidoEstudiante;
            this._fechaNacimiento = fechaNacimiento;
            this._ruta_foto = ruta_foto;
            this._nombreAcudiente = nombreAcudiente;
            this._direccion = direccion;
            this._genero = genero;
            this._telefonoAcudiente = telefonoAcudiente;
            this._celularAcudiente = celularAcudiante;
            this._correoElectronicoAcudiente = correoElectronicoAcudiente;
            this._observacionesEstudiante = observacionesEstudiante;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._usuarioModificacion = usuarioModificacion;
            this._fechaModificacion = fechaModificacion;
            this._estadoEstudiante = EstadoEstudiante;
            this._grupo = grupo;
        }

        public int Id_estudiante
        {
            get => _id_estudiante;
            set => _id_estudiante = value;
        }
        public string DocumentoEstudiante
        {
            get => _documentoEstudiante;
            set => _documentoEstudiante = value;
        }
        public string TipoDocumento
        {
            get => _tipoDocumento;
            set => _tipoDocumento = value;
        }
        public string NombreEstudiante
        {
            get => _nombreEstudiante;
            set => _nombreEstudiante = value;
        }
        public string ApellidoEstudiante
        {
            get => _apellidoEstudiante;
            set => _apellidoEstudiante = value;
        }
        public DateTime FechaNacimiento
        {
            get => _fechaNacimiento;
            set => _fechaNacimiento = value;
        }

        public String Ruta_foto
        {
            get => _ruta_foto;
            set => _ruta_foto = value;
        }

        public String NombreAcudiente
        {
            get => _nombreAcudiente;
            set => _nombreAcudiente = value;
        }

        public String Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }

        public String Genero
        {
            get => _genero;
            set => _genero = value;
        }

        public String TelefonoAcudiente
        {
            get => _telefonoAcudiente;
            set => _telefonoAcudiente = value;
        }

        
        public string CelularAcudiente
        {
            get => _celularAcudiente;
            set => _celularAcudiente = value;
        }

        public String CorreoElectronicoAcudiente
        {
            get => _correoElectronicoAcudiente;
            set => _correoElectronicoAcudiente = value;
        }

        public String ObservacionesEstudiante
        {
            get => _observacionesEstudiante;
            set => _observacionesEstudiante = value;
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

        public Grupo grupo
        {
            get => _grupo;
            set => _grupo = value;
        }

        public string EstadoEstudiante
        {
            get => _estadoEstudiante;
            set => _estadoEstudiante = value;
        }
        
    }
}
