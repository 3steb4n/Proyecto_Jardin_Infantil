using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoMatricula
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

        public List<Matricula> ListaGeneral()
        {
            List<Matricula> list = new List<Matricula>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarMatricula", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Matricula matricula = new Matricula();

                            matricula.Id_matricula = (int)dr["Idmatricula"];
                            matricula.Numeromatricula = (int)dr["NumeroMatricula"];
                            matricula.Anoreguistro = (DateTime)dr["AnoReguistro"];
                            matricula.Estadomatricula = (String)dr["EstadoMatriculado"];
                            matricula.estudiante.Id_estudiante = (int)dr["Idestudiante"];
                            matricula.estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                            matricula.estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                            matricula.grupo.IdGrupo = (int)dr["Idgrupo"];
                            matricula.grupo.NombreGrupo = (String)dr["NombreGrupo"];

                            list.Add(matricula);
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
        public List<Matricula> ListaPorDocumento(String documento)
        {

            List<Matricula> lista = new List<Matricula>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarMatriculasPorDocumento", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        Matricula matricula = new Matricula();

                        matricula.Id_matricula = (int)dr["Idmatricula"];
                        matricula.Numeromatricula = (int)dr["NumeroMatricula"];
                        matricula.Anoreguistro = (DateTime)dr["AnoReguistro"];
                        matricula.Estadomatricula = (String)dr["EstadoMatriculado"];
                        matricula.estudiante.Id_estudiante = (int)dr["Idestudiante"];
                        matricula.estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                        matricula.estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                        matricula.grupo.IdGrupo = (int)dr["Idgrupo"];
                        matricula.grupo.NombreGrupo = (String)dr["NombreGrupo"];


                        lista.Add(matricula);

                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listaPorDocumento: " + e);
                return lista;
            }
        }


        public List<Matricula> ListarPorDocumentoyGrupo(String documento, int idGrupo)
        {

            List<Matricula> lista = new List<Matricula>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarMatriculasPorDocumentoyGrupo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Matricula matricula = new Matricula();

                            matricula.Id_matricula = (int)dr["Idmatricula"];
                            matricula.Numeromatricula = (int)dr["NumeroMatricula"];
                            matricula.Anoreguistro = (DateTime)dr["AnoReguistro"];
                            matricula.Estadomatricula = (String)dr["EstadoMatriculado"];
                            matricula.estudiante.Id_estudiante = (int)dr["Idestudiante"];
                            matricula.estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                            matricula.estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                            matricula.grupo.IdGrupo = (int)dr["Idgrupo"];
                            matricula.grupo.NombreGrupo = (String)dr["NombreGrupo"];

                            lista.Add(matricula);
                        }

                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListarEstudiantePorDocumentoyGrupo: " + e);
                return lista;
            }
        }

        public List<Matricula> ListarPorGrupo(int idGrupo)
        {

            List<Matricula> lista = new List<Matricula>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarMatriculasPorGrupo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Matricula matricula = new Matricula();

                            matricula.Id_matricula = (int)dr["Idmatricula"];
                            matricula.Numeromatricula = (int)dr["NumeroMatricula"];
                            matricula.Anoreguistro = (DateTime)dr["AnoReguistro"];
                            matricula.Estadomatricula = (String)dr["EstadoMatriculado"];
                            matricula.estudiante.Id_estudiante = (int)dr["Idestudiante"];
                            matricula.estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                            matricula.estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                            matricula.grupo.IdGrupo = (int)dr["Idgrupo"];
                            matricula.grupo.NombreGrupo = (String)dr["NombreGrupo"];

                            lista.Add(matricula);
                        }

                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListarEstudiantePorDocumentoyGrupo: " + e);
                return lista;
            }
        }


        public bool InsertarMatricula(Matricula matricula)
        {
            bool flag = false;
            try
            {

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarMatricula", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Numeromatricula", matricula.Numeromatricula);
                    cmd.Parameters.AddWithValue("@Anoreguistro", matricula.Anoreguistro);
                    cmd.Parameters.AddWithValue("@Fechacreacion", matricula.Fechacreacion);
                    cmd.Parameters.AddWithValue("@Estadomatricula", "A");
                    cmd.Parameters.AddWithValue("@IDestudiante", matricula.estudiante.Id_estudiante);
                    cmd.Parameters.AddWithValue("@IDgrupo", matricula.grupo.IdGrupo);

                    flag = cmd.ExecuteNonQuery() != 0;

                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar estudiante: +" + e);
                return flag;
            }
        }

    }

}
