﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoEstudiante
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

        public List<Estudiante> ListaGeneral()
        {
            List<Estudiante> list = new List<Estudiante>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarEstudiantes", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Estudiante estudiante = new Estudiante();

                            estudiante.Id_estudiante = (int)dr["IdEstudiante"];
                            estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                            estudiante.TipoDocumento = OrdenarTipoDocumento((String)dr["TipoDocumento"]);
                            estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                            estudiante.ApellidoEstudiante = (String)dr["ApellidoEstudiante"];
                            estudiante.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                            estudiante.Ruta_foto = (String)dr["RutaFoto"];
                            estudiante.NombreAcudiente = (String)dr["AcudienteNombre"];
                            estudiante.Direccion = (String)dr["Direccion"];
                            estudiante.Genero = OrdenarGenero((String)dr["GeneroEstudiante"]);
                            estudiante.TelefonoAcudiente = (String)dr["Telefono"];
                            estudiante.CelularAcudiente = (String)dr["Celular"];
                            estudiante.CorreoElectronicoAcudiente = (String)dr["CorreoElectronico"];
                            estudiante.ObservacionesEstudiante = (String)dr["Observaciones"];
                            estudiante.EstadoEstudiante = OrdenarEstadoEstudiante((String)dr["EstadoEstudiante"]);

                            list.Add(estudiante);
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

        public List<Estudiante> ListaPorDocumento(String documento)
        {

            List<Estudiante> lista = new List<Estudiante>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarEstudiantePorDocumento", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        Estudiante estudiante = new Estudiante();

                        estudiante.Id_estudiante = (int)dr["IdEstudiante"];
                        estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                        estudiante.TipoDocumento = OrdenarTipoDocumento((String)dr["TipoDocumento"]);
                        estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                        estudiante.ApellidoEstudiante = (String)dr["ApellidoEstudiante"];
                        estudiante.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                        estudiante.Ruta_foto = (String)dr["RutaFoto"];
                        estudiante.NombreAcudiente = (String)dr["AcudienteNombre"];
                        estudiante.Direccion = (String)dr["Direccion"];
                        estudiante.Genero = OrdenarGenero((String)dr["GeneroEstudiante"]);
                        estudiante.TelefonoAcudiente = (String)dr["Telefono"];
                        estudiante.CelularAcudiente = (String)dr["Celular"];
                        estudiante.CorreoElectronicoAcudiente = (String)dr["CorreoElectronico"];
                        estudiante.ObservacionesEstudiante = (String)dr["Observaciones"];
                        estudiante.EstadoEstudiante = OrdenarEstadoEstudiante((String)dr["EstadoEstudiante"]);

                        lista.Add(estudiante);

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


        public List<Estudiante> ListaIDyNombre()
        {
            List<Estudiante> list = new List<Estudiante>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarEstudiantesIdNombre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Estudiante estudiante = new Estudiante();
                            estudiante.Id_estudiante = (int)dr["ID"];
                            estudiante.NombreEstudiante = (String)dr["Nombres"];
                            estudiante.ApellidoEstudiante = (String)dr["Apellidos"];

                            list.Add(estudiante);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListaIDyNombre: " + e);
                return list;
            }
        }

        public bool InsertarEstudiante(Estudiante estudiante)
        {
            bool flag = false;
            try
            {

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarEstudiante", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@DocumentoEstudiante", estudiante.DocumentoEstudiante);
                    cmd.Parameters.AddWithValue("@TipoDocumento", estudiante.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NombreEstudiante", estudiante.NombreEstudiante);
                    cmd.Parameters.AddWithValue("@ApellidoEstudiante", estudiante.ApellidoEstudiante);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", estudiante.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@RutaFoto", estudiante.Ruta_foto);
                    cmd.Parameters.AddWithValue("@AcudienteNombre", estudiante.NombreAcudiente);
                    cmd.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                    cmd.Parameters.AddWithValue("@GeneroEstudiante", estudiante.Genero);
                    cmd.Parameters.AddWithValue("@Telefono", estudiante.TelefonoAcudiente);
                    cmd.Parameters.AddWithValue("@Celular", estudiante.CelularAcudiente);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", estudiante.CorreoElectronicoAcudiente);
                    cmd.Parameters.AddWithValue("@Observaciones", estudiante.ObservacionesEstudiante);
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", estudiante.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreacion", estudiante.FechaCreacion);
                    cmd.Parameters.AddWithValue("@EstadoEstudiante", "A");

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

        public bool ModificarEstudiante(Estudiante estudiante)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ModificarEstudiante", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEstudiante", estudiante.Id_estudiante);
                    cmd.Parameters.AddWithValue("@DocumentoEstudiante", estudiante.DocumentoEstudiante);
                    cmd.Parameters.AddWithValue("@TipoDocumento", estudiante.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NombreEstudiante", estudiante.NombreEstudiante);
                    cmd.Parameters.AddWithValue("@ApellidoEstudiante", estudiante.ApellidoEstudiante);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", estudiante.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@RutaFoto", estudiante.Ruta_foto);
                    cmd.Parameters.AddWithValue("@AcudienteNombre", estudiante.NombreAcudiente);
                    cmd.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                    cmd.Parameters.AddWithValue("@GeneroEstudiante", estudiante.Genero);
                    cmd.Parameters.AddWithValue("@Telefono", estudiante.TelefonoAcudiente);
                    cmd.Parameters.AddWithValue("@Celular", estudiante.CelularAcudiente);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", estudiante.CorreoElectronicoAcudiente);
                    cmd.Parameters.AddWithValue("@Observaciones", estudiante.ObservacionesEstudiante);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", estudiante.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", estudiante.FechaModificacion);

                    flag = cmd.ExecuteNonQuery() != 0;

                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al modificar estudiante: " + e);
                return flag;
            }
        }

        public bool EliminarEstudiante(int id)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("eliminarEstudiante", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar estudiante: " + e);
                return flag;
            }
        }

        public String OrdenarTipoDocumento(String tipo)
        {
            String valor = "";

            if (tipo == "RC")
            {
                valor = "Registro civil";
            }
            else if (tipo == "TI")
            {
                valor = "Tarjeta de identidad";
            }
            else if (tipo == "DNI")
            {
                valor = "DNI";
            }
            return valor;
        }

        public String OrdenarEstadoEstudiante(String tipo)
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

        public String OrdenarGenero(String tipo)
        {
            String valor = "";
            if (tipo == "F")
            {
                valor = "Femenino";
            }
            else
            {
                valor = "Masculino";
            }

            return valor;
        }

    }
}
