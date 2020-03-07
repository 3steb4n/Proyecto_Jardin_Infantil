using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class BLUsuario
    {

        public Usuario IniciarSesion(String correo_electronico, String clave)
        {
            DaoUsuario daoUsuario = new DaoUsuario();

            return daoUsuario.IniciarSesion(correo_electronico,clave);
        }
        public List<Usuario> ListarUsuarios()
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ListaGeneral();
        }

        public Usuario ListarUsuariosID(String documento)
        {
            DaoUsuario daoUsuario = new DaoUsuario();

            return daoUsuario.ListaPorDocumento(documento);
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

        public bool EliminarUsuario(int id)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.EliminarUsuario(id);
        }

    }
}
