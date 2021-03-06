﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoGrupo
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

        public List<Grupo> ListaGeneral()
        {
            List<Grupo> list = new List<Grupo>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarGrupos", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Grupo grupo = new Grupo();

                            grupo.IdGrupo = (int)dr["IdGrupo"];
                            grupo.NombreGrupo = (String)dr["NombreGrupo"];
                            grupo.DescripcionGrupo = (String)dr["DescripcionGrupo"];
                            grupo.EstadoGrupo = OrdenarEstado((String)dr["EstadoGrupo"]);
                            grupo.Grado.IdGrado = (int)dr["IdGrado"];
                            grupo.Grado.NombreGrado = (String)dr["NombreGrado"];
                            grupo.usuario.Id_usuario = (int)dr["idUsuario"];
                            grupo.usuario.Nombres = (String)dr["Nombres"];
                            grupo.usuario.Apellidos = (String)dr["Apellidos"];

                            list.Add(grupo);
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

        public Grupo ListaPorNombre(String nombre)
        {

            Grupo grupo = new Grupo();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarGrupoPorNombre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre_grupo", nombre);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        grupo = new Grupo();
                        grupo.IdGrupo = (int)dr["IdGrupo"];
                        grupo.NombreGrupo = (String)dr["NombreGrupo"];
                        grupo.DescripcionGrupo = (String)dr["DescripcionGrupo"];
                        grupo.EstadoGrupo = OrdenarEstado((String)dr["EstadoGrupo"]);
                        grupo.Grado.IdGrado = (int)dr["IdGrado"];
                        grupo.Grado.NombreGrado = (String)dr["NombreGrado"];
                        grupo.usuario.Id_usuario = (int)dr["idUsuario"];
                        grupo.usuario.Nombres = (String)dr["Nombres"];
                        grupo.usuario.Apellidos = (String)dr["Apellidos"];
                    }
                }

                return grupo;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listar por nombre: " + e);
                return grupo;
            }
        }

        public List<Grupo> ListarGruposNombreyID()
        {

            List<Grupo> list = new List<Grupo>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarGruposNombreyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {

                        Grupo grupo1 = new Grupo();
                        grupo1.IdGrupo = 0;
                        grupo1.NombreGrupo = "Seleccione...";
                        list.Add(grupo1);

                        while (dr.Read())
                        {
                            Grupo grupo = new Grupo();

                            grupo.IdGrupo = (int)dr["IdGrupo"];
                            grupo.NombreGrupo = (String)dr["NombreGrupo"];

                            list.Add(grupo);
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

        public bool InsertarGrupo(Grupo grupo)
        {
            bool flag = false;
            try
            {

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarGrupo", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreGrupo", grupo.NombreGrupo);
                    cmd.Parameters.AddWithValue("@DescripcionGrupo", grupo.DescripcionGrupo);
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", grupo.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreacion", grupo.FechaCreacion);
                    cmd.Parameters.AddWithValue("@EstadoGrupo", grupo.EstadoGrupo);
                    cmd.Parameters.AddWithValue("@IdGrado", grupo.Grado.IdGrado);
                    cmd.Parameters.AddWithValue("@IdDocente", grupo.usuario.Id_usuario);

                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar grupo: +" + e);
                return flag;
            }
        }

        public bool ModificarGrupo(Grupo grupo)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("modificarGrupo", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_grupo", grupo.IdGrupo);
                    cmd.Parameters.AddWithValue("@NombreGrupo", grupo.NombreGrupo);
                    cmd.Parameters.AddWithValue("@DescripcionGrupo", grupo.DescripcionGrupo);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", grupo.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", grupo.FechaModificacion);
                    cmd.Parameters.AddWithValue("@EstadoGrupo", grupo.EstadoGrupo);
                    cmd.Parameters.AddWithValue("@IdGrado", grupo.Grado.IdGrado);
                    cmd.Parameters.AddWithValue("@IdDocente", grupo.usuario.Id_usuario);

                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al modificar grupo: " + e);
                return flag;
            }
        }

        public bool EliminarGrupo(int idGrupo)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("eliminarGrupo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", idGrupo);
                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar grupo: " + e);
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
