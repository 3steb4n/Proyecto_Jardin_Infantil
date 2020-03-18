using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLUsuario
    {

        public Usuario IniciarSesion(String correo_electronico, String clave)
        {
            DaoUsuario daoUsuario = new DaoUsuario();

            return daoUsuario.IniciarSesion(correo_electronico, clave);
        }
        public List<Usuario> ListarUsuarios()
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ListaGeneral();
        }

        public List<Usuario> ListarDocentes()
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ListarDocentes();
        }

        public Usuario ListaPorDocumento(String documento)
        {
            DaoUsuario daoUsuario = new DaoUsuario();

            return daoUsuario.ListaPorDocumento(documento);
        }

        public Usuario ListarPorDocumentoProfesor(String documento)
        {
            DaoUsuario daoUsuario = new DaoUsuario();

            return daoUsuario.ListaPorDocumentoProfesor(documento);
        }

        public List<Usuario> ListarIDyNombres()
        {
            DaoUsuario daoUsuario = new DaoUsuario();

            return daoUsuario.ListarIDyNombres();
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.InsertarUsuario(usuario);
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ModificarUsuario(usuario);
        }

        public bool ModificarUsuarioPropio(Usuario usuario)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ModificarUsuarioPropio(usuario);
        }

        public bool ModificarUsuarioContrasena(Usuario usuario)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ModificarUsuarioContrasena(usuario);
        }

        public bool EliminarUsuario(int id)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.EliminarUsuario(id);
        }

    }
}
