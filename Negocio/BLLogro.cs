using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLogro
    {
        public List<Logro> ListarLogros()
        {
            DaoLogro daoLogro = new DaoLogro();
            return daoLogro.ListaGeneral();
        }

        public Logro ListarLogroPorNombre(String nombre)
        {
            DaoLogro daoLogro = new DaoLogro();

            return daoLogro.ListaPorNombre(nombre);
        }

        public bool InsertarLogro(Logro logro)
        {
            DaoLogro daoLogro = new DaoLogro();
            return daoLogro.InsertarLogro(logro);
        }

        public bool ModificarLogro(Logro logro)
        {
            DaoLogro daoLogro = new DaoLogro();
            return daoLogro.ModificarLogro(logro);
        }

        public bool EliminarLogro(int id)
        {
            DaoLogro daoLogro = new DaoLogro();
            return daoLogro.EliminarLogro(id);
        }
    }

}
