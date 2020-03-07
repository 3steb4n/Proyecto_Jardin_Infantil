using System;

namespace Jardin.DTO
{
    class Usuarios
    {
        private int _id_usuario;
        private String _documento;
        private String _tipoDocumento;
        private String _nombres;
        private String _apellidos;
        private String _direccion;
        private String _celular;
        private String _telefono;
        private String _correoElectronico;
        private String _usuarioLogin;
        private String _Clave;
        private String _usuarioCreacion;
        private DateTime _fechaCreacion;
        private String _usuarioModificacion;
        private DateTime _fechaModificacion;
        private String _estadoUsuario;
        private String _estadoClave;
        private String _tipoUsuario;


        public Usuarios(int id, String documento, String tipoDocumento, String nombres, String apellidos, String direccion, String celular, String telefono, String correo_electronico, String usuarioLogin, String clave, String usuarioCreacion, DateTime fechaCreacion, String usuarioModificacion, DateTime fechaModificacion, String estadoUsuario, String estadoClave, String tipoUsuario)
        {
            this._id_usuario = id;
            this._documento = documento;
            this._tipoDocumento = tipoDocumento;
            this._nombres = nombres;
            this._apellidos = apellidos;
            this._direccion = direccion;
            this._celular = celular;
            this._telefono = telefono;
            this._correoElectronico = correo_electronico;
            this._usuarioLogin = usuarioLogin;
            this._Clave = clave;
            this._usuarioCreacion = usuarioCreacion;
            this._fechaCreacion = fechaCreacion;
            this._usuarioModificacion = usuarioModificacion;
            this._fechaModificacion  = fechaModificacion;
            this._estadoUsuario = estadoUsuario;
            this._estadoClave = estadoClave;
            this._tipoUsuario = tipoUsuario;

        }

        public int id_usuario
        { 
            get => _id_usuario;
            set => _id_usuario = value;
        }
        public string documento
        {
            get => _documento;
            set => _documento = value;
        }
        public string tipoDocumento
        {
            get => _tipoDocumento;
            set => _tipoDocumento = value;
        }
        public string nombres
        {
            get => _nombres;
            set => _nombres = value;
        }
        public string apellidos
        {
            get => _apellidos;
            set => _apellidos = value;
        }
        public string direccion
        {
            get => _direccion;
            set => _direccion = value;
        }

        public String celular
        {
            get => _celular;
            set => _celular = value;
        }

        public String telefono
        {
            get => _telefono;
            set => _telefono = value;
        }

        public String correoElectronico
        {
            get => _correoElectronico;
            set => _correoElectronico = value;
        }

        public String usuarioLogin
        {
            get => _usuarioLogin;
            set => _usuarioLogin = value;
        }

        public String clave
        {
            get => _Clave;
            set => _Clave = value;
        }

        public string usuarioCreacion
        {
            get => _usuarioCreacion;
            set => _usuarioCreacion = value;
        }
        public DateTime fechaCreacion
        {
            get => _fechaCreacion;
            set => _fechaCreacion = value;
        }
        public string usuarioModificacion
        {
            get => _usuarioModificacion;
            set => _usuarioModificacion = value;
        }

        public DateTime fechaModificacion
        {
            get => _fechaModificacion;
            set => _fechaModificacion = value;
        }

        public string estadoUsuario
        {
            get => _estadoUsuario;
            set => _estadoUsuario = value;
        }

        public String estadoClave
        {
            get => _estadoClave;
            set => _estadoClave = value;
        }

        public String tipoUsuario
        {
            get => _tipoUsuario;
            set => _tipoUsuario = value;
        }

    }
}
