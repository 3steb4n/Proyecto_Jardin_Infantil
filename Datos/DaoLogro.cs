using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoLogro
    {
        String _cadenaConexion;


        public String CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {

                    _cadenaConexion = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
                }

                return _cadenaConexion;
            }
            set { _cadenaConexion = value; }
        }

        public List<Logro> ListaGeneral()
        {
            List<Logro> list = new List<Logro>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarLogros", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Logro logro = new Logro();

                            logro.IdLogro = (int)dr["IdLogro"];
                            logro.NombreLogro = (String)dr["NombreLogro"];
                            logro.DescripcionLogro = (String)dr["DescripcionLogro"];
                            logro.EstadoLogro = OrdenarEstado((String)dr["EstadoLogro"]);
                            logro.Materia.IdMateria = (int)dr["idMateria"];
                            logro.Materia.NombreMateria = (String)dr["nombreMateria"];

                            list.Add(logro);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listaGeneral: " + e);
                return list;
            }
        }

        public Logro ListaPorNombre(String nombre)
        {
            Logro logro = new Logro();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarLogrosNombre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreLogro", nombre);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        logro = new Logro();

                        logro.IdLogro = (int)dr["IdLogro"];
                        logro.NombreLogro = (String)dr["NombreLogro"];
                        logro.DescripcionLogro = (String)dr["DescripcionLogro"];
                        logro.EstadoLogro = OrdenarEstado((String)dr["EstadoLogro"]);
                        logro.Materia.IdMateria = (int)dr["idMateria"];
                        logro.Materia.NombreMateria = (String)dr["nombreMateria"];

                    }
                }

                return logro;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listar por nombre: " + e);
                return logro;
            }
        }

        public bool InsertarLogro(Logro logro)
        {
            bool flag = false;
            try
            {

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarLogro", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreLogro", logro.NombreLogro);
                    cmd.Parameters.AddWithValue("@DescripcionLogro", logro.DescripcionLogro);
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", logro.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreacion", logro.FechaCreacion);
                    cmd.Parameters.AddWithValue("@EstadoLogro", "A");
                    cmd.Parameters.AddWithValue("@Id_Materia", logro.Materia.IdMateria);

                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar logro: +" + e);
                return flag;
            }
        }

        public bool ModificarLogro(Logro logro)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("modificarLogro", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdLogro", logro.IdLogro);
                    cmd.Parameters.AddWithValue("@NombreLogro", logro.NombreLogro);
                    cmd.Parameters.AddWithValue("@DescripcionLogro", logro.DescripcionLogro);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", logro.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", logro.FechaModificacion);
                    cmd.Parameters.AddWithValue("@EstadoLogro", "A");
                    cmd.Parameters.AddWithValue("@Id_Materia", logro.Materia.IdMateria);

                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al modificar logro: " + e);
                return flag;
            }
        }

        public bool EliminarLogro(int idLogro)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("eliminarLogro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdLogro", idLogro);
                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar logro: " + e);
                return flag;
            }
        }

        public String OrdenarEstado(String tipo)
        {
            String valor = "";
            if (tipo == "A")
            {
                valor = "Activo";
            }
            else
            {
                valor = "Inactivo";
            }

            return valor;
        }
    }
}
