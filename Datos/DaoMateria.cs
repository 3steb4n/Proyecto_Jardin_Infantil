using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoMateria
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

        public List<Materiaa> ListaGeneral()
        {
            List<Materiaa> list = new List<Materiaa>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarMaterias", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Materiaa materia = new Materiaa();

                            materia.IdMateria = (int)dr["IdMateria"];
                            materia.NombreMateria = (String)dr["NomreMateria"];
                            materia.DescripcionMateria = (String)dr["DescripcionMateria"];
                            materia.EstadoMateria = (String)dr["EstadoMateria"];
                            materia.NumeroHorasMaterias = (int)dr["NumeroHoras"];
                            materia.Area.IdArea = (int)dr["IdArea"];
                            materia.Area.NombreArea = (String)dr["NombreArea"];
                            materia.Grado.IdGrado = (int)dr["IdGrado"];
                            materia.Grado.NombreGrado = (String)dr["NombreGrado"];

                            list.Add(materia);
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


        public List<Materiaa> ListarIdNombre()
        {
            List<Materiaa> list = new List<Materiaa>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarMateriaIdNombre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Materiaa materia = new Materiaa();

                            materia.IdMateria = (int)dr["IdMateria"];
                            materia.NombreMateria = (String)dr["NomreMateria"];

                            list.Add(materia);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListarIdNombre: " + e);
                return list;
            }
        }


        public Materiaa ListaPorNombre(String nombre)
        {

            Materiaa materia = new Materiaa();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarMateriasPorNombre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreMateria", nombre);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        materia = new Materiaa();

                        materia.IdMateria = (int)dr["IdMateria"];
                        materia.NombreMateria = (String)dr["NombreMateria"];
                        materia.DescripcionMateria = (String)dr["DescripcionMateria"];
                        materia.EstadoMateria = (String)dr["EstadoMateria"];
                        materia.NumeroHorasMaterias = (int)dr["NumeroHoras"];
                        materia.Area.IdArea = (int)dr["IdArea"];
                        materia.Area.NombreArea = (String)dr["NombreArea"];
                        materia.Grado.IdGrado = (int)dr["IdGrado"];
                        materia.Grado.NombreGrado = (String)dr["NombreGrado"];

                    }
                }

                return materia;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listaPorDocumento: " + e);
                return materia;
            }
        }

        public bool InsertarMateria(Materiaa materia)
        {
            bool flag = false;
            try
            {

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarMateria", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreMateria", materia.NombreMateria);
                    cmd.Parameters.AddWithValue("@DescripcionMateria", materia.DescripcionMateria);
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", materia.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreacion", materia.FechaCreacion);
                    cmd.Parameters.AddWithValue("@EstadoMateria", materia.EstadoMateria);
                    cmd.Parameters.AddWithValue("@NumeroHoras", materia.NumeroHorasMaterias);
                    cmd.Parameters.AddWithValue("@IdArea", materia.Area.IdArea);
                    cmd.Parameters.AddWithValue("@IdGrado", materia.Grado.IdGrado);

                    flag = cmd.ExecuteNonQuery() != 0;

                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar materia: +" + e);
                return flag;
            }
        }

        public bool ModificarMateria(Materiaa materia)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("modificarMateria", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdMateria", materia.IdMateria);
                    cmd.Parameters.AddWithValue("@NombreMateria", materia.NombreMateria);
                    cmd.Parameters.AddWithValue("@DescripcionMateria", materia.DescripcionMateria);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", materia.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", materia.FechaModificacion);
                    cmd.Parameters.AddWithValue("@NumeroHoras", materia.NumeroHorasMaterias);
                    cmd.Parameters.AddWithValue("@IdArea", materia.Area.IdArea);
                    cmd.Parameters.AddWithValue("@IdGrado", materia.Grado.IdGrado);

                    flag = cmd.ExecuteNonQuery() != 0;

                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al modificar materia: " + e);
                return flag;
            }
        }

        public bool EliminarMateria(int id)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("eliminarMateria", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMateria", id);
                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar materia: " + e);
                return flag;
            }
        }
    }
}
