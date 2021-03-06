﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Datos
{
    public class DaoUsuario
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

        public List<Usuario> ListaGeneral()
        {
            List<Usuario> list = new List<Usuario>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarUsuarios", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.Id_usuario = (int)dr["ID"];
                            usuario.Documento = (String)dr["Documento"];
                            usuario.TipoDocumento = OrdenarTipoDocumento((String)dr["Tipo_Documento"]);
                            usuario.Nombres = (String)dr["Nombres"];
                            usuario.Apellidos = (String)dr["Apellidos"];
                            usuario.Direccion = (String)dr["Direccion"];
                            usuario.Celular = (String)dr["Celular"];
                            usuario.Telefono = (String)dr["Telefono"];
                            usuario.CorreoElectronico = (String)dr["Correo_Electronico"];
                            usuario.UsuarioCreacion = (String)dr["Usuario_Creacion"];
                            usuario.FechaCreacion = (DateTime)dr["Fecha_Creacion"];
                            usuario.UsuarioModificacion = (String)dr["Usuario_Modificacion"];
                            usuario.FechaModificacion = (DateTime)dr["Fecha_Modificacion"];
                            usuario.EstadoUsuario = OrdenarEstadoUsuario((String)dr["Estado_Usuario"]);
                            usuario.EstadoClave = OrdenarEstadoClave((String)dr["Estado_Clave"]);
                            usuario.TipoUsuario = OrdenarTipoUsuario((String)dr["Tipo_Usuario"]);

                            list.Add(usuario);
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

        public Usuario ListaPorDocumento(String documento)
        {

            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarUsuarioDocumento", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        usuario = new Usuario();
                        usuario.Id_usuario = (int)dr["ID"];
                        usuario.Documento = (String)dr["Documento"];
                        usuario.TipoDocumento = OrdenarTipoDocumento((String)dr["Tipo_Documento"]);
                        usuario.Nombres = (String)dr["Nombres"];
                        usuario.Apellidos = (String)dr["Apellidos"];
                        usuario.Direccion = (String)dr["Direccion"];
                        usuario.Celular = (String)dr["Celular"];
                        usuario.Telefono = (String)dr["Telefono"];
                        usuario.CorreoElectronico = (String)dr["Correo_Electronico"];
                        usuario.UsuarioCreacion = (String)dr["Usuario_Creacion"];
                        usuario.FechaCreacion = (DateTime)dr["Fecha_Creacion"];
                        usuario.UsuarioModificacion = (String)dr["Usuario_Modificacion"];
                        usuario.FechaModificacion = (DateTime)dr["Fecha_Modificacion"];
                        usuario.EstadoUsuario = OrdenarEstadoUsuario((String)dr["Estado_Usuario"]);
                        usuario.EstadoClave = OrdenarEstadoClave((String)dr["Estado_Clave"]);
                        usuario.TipoUsuario = OrdenarTipoUsuario((String)dr["Tipo_Usuario"]);

                    }
                }

                return usuario;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listaPorDocumento: " + e);
                return usuario;
            }
        }

        public Usuario ListaPorDocumentoProfesor(String documento)
        {

            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarUsuarioDocumentoProfesor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        usuario = new Usuario();
                        usuario.Id_usuario = (int)dr["ID"];
                        usuario.Documento = (String)dr["Documento"];
                        usuario.TipoDocumento = OrdenarTipoDocumento((String)dr["Tipo_Documento"]);
                        usuario.Nombres = (String)dr["Nombres"];
                        usuario.Apellidos = (String)dr["Apellidos"];
                        usuario.Direccion = (String)dr["Direccion"];
                        usuario.Celular = (String)dr["Celular"];
                        usuario.Telefono = (String)dr["Telefono"];
                        usuario.CorreoElectronico = (String)dr["Correo_Electronico"];
                        usuario.UsuarioCreacion = (String)dr["Usuario_Creacion"];
                        usuario.FechaCreacion = (DateTime)dr["Fecha_Creacion"];
                        usuario.UsuarioModificacion = (String)dr["Usuario_Modificacion"];
                        usuario.FechaModificacion = (DateTime)dr["Fecha_Modificacion"];
                        usuario.EstadoUsuario = OrdenarEstadoUsuario((String)dr["Estado_Usuario"]);
                        usuario.EstadoClave = OrdenarEstadoClave((String)dr["Estado_Clave"]);

                    }
                }

                return usuario;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListaPorDocumentoProfesor: " + e);
                return usuario;
            }
        }

        public List<Usuario> ListarIDyNombres()
        {
            List<Usuario> list = new List<Usuario>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarDocentesIdNombre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.Id_usuario = (int)dr["ID"];
                            usuario.Nombres = (String)dr["Nombres"];
                            usuario.Apellidos = (String)dr["Apellidos"];

                            list.Add(usuario);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListarIDyNombres: " + e);
                return list;
            }
        }

        public List<Usuario> ListarDocentes()
        {
            List<Usuario> list = new List<Usuario>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarDocentes", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.Id_usuario = (int)dr["ID"];
                            usuario.Documento = (String)dr["Documento"];
                            usuario.TipoDocumento = OrdenarTipoDocumento((String)dr["Tipo_Documento"]);
                            usuario.Nombres = (String)dr["Nombres"];
                            usuario.Apellidos = (String)dr["Apellidos"];
                            usuario.Direccion = (String)dr["Direccion"];
                            usuario.Celular = (String)dr["Celular"];
                            usuario.Telefono = (String)dr["Telefono"];
                            usuario.CorreoElectronico = (String)dr["Correo_Electronico"];
                            usuario.UsuarioCreacion = (String)dr["Usuario_Creacion"];
                            usuario.FechaCreacion = (DateTime)dr["Fecha_Creacion"];
                            usuario.UsuarioModificacion = (String)dr["Usuario_Modificacion"];
                            usuario.FechaModificacion = (DateTime)dr["Fecha_Modificacion"];
                            usuario.EstadoUsuario = OrdenarEstadoUsuario((String)dr["Estado_Usuario"]);
                            usuario.EstadoClave = OrdenarEstadoClave((String)dr["Estado_Clave"]);

                            list.Add(usuario);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListarDocentes: " + e);
                return list;
            }
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            bool flag = false;
            try
            {

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarUsuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Documento", usuario.Documento);
                    cmd.Parameters.AddWithValue("@Tipo_Documento", usuario.TipoDocumento);
                    cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                    cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Correo_Electronico", usuario.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@UsuarioClave", IncriptarContraseña(usuario.Documento));
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", usuario.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreacion", usuario.FechaCreacion);
                    cmd.Parameters.AddWithValue("@Estado_Usuario", "A");
                    cmd.Parameters.AddWithValue("@Estado_Clave", "S");
                    cmd.Parameters.AddWithValue("@Tipo_Usuario", usuario.TipoUsuario);

                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar usuario: +" + e);
                return flag;
            }
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("modificarUsuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@ID", usuario.Id_usuario);
                    cmd.Parameters.AddWithValue("@Documento", usuario.Documento);
                    cmd.Parameters.AddWithValue("@Tipo_Documento", usuario.TipoDocumento);
                    cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                    cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Correo_Electronico", usuario.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", usuario.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", usuario.FechaModificacion);
                    cmd.Parameters.AddWithValue("@Estado_Usuario", usuario.EstadoUsuario);
                    cmd.Parameters.AddWithValue("@Estado_Clave", usuario.EstadoClave);
                    cmd.Parameters.AddWithValue("@Tipo_Usuario", usuario.TipoUsuario);

                    flag = cmd.ExecuteNonQuery() != 0;

                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al modificar usuario: " + e);
                return flag;
            }
        }

        public bool ModificarUsuarioPropio(Usuario usuario)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("modificarUsuarioPropio", con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@ID", usuario.Id_usuario);
                    cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                    cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Correo_Electronico", usuario.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", usuario.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", usuario.FechaModificacion);

                    flag = cmd.ExecuteNonQuery() != 0;

                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al modificar usuario: " + e);
                return flag;
            }
        }

        public bool ModificarUsuarioContrasena(Usuario usuario)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("modificarUsuarioPropioPasswd", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", usuario.Id_usuario);
                    cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                    cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@Correo_Electronico", usuario.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", usuario.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", usuario.FechaModificacion);
                    cmd.Parameters.AddWithValue("@Passwd", IncriptarContraseña(usuario.Clave));
                    cmd.Parameters.AddWithValue("@EstadoClave", "C");

                    flag = cmd.ExecuteNonQuery() != 0;

                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el metodo ModificarUsuarioContrasena: " + e);
                return flag;
            }
        }


        public bool EliminarUsuario(int id)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("eliminarUsuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al eliminar usuario: " + e);
                return flag;
            }
        }

        public static string IncriptarContraseña(string originalPassword)
        {
            try
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();

                byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
                byte[] hash = sha1.ComputeHash(inputBytes);

                return Convert.ToBase64String(hash);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error al incriptar contraseña: " + e);
                return null;
            }

        }

        public Usuario IniciarSesion(String correo_electronico, String clave)
        {
            Usuario usuario = new Usuario();
            try
            {
                String clave_encrypt = IncriptarContraseña(clave);
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("IniciarSesion", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Correo_Electronico", correo_electronico);
                    cmd.Parameters.AddWithValue("@Usuario_Clave", clave_encrypt);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        usuario = new Usuario();
                        usuario.Id_usuario = (int)dr["ID"];
                        usuario.Documento = (String)dr["Documento"];
                        usuario.Nombres = (String)dr["Nombres"];
                        usuario.Apellidos = (String)dr["Apellidos"];
                        usuario.EstadoUsuario = (String)dr["Estado_Usuario"];
                        usuario.EstadoClave = (String)dr["Estado_Clave"];
                        usuario.TipoUsuario = (String)dr["Tipo_Usuario"];
                    }
                }
                return usuario;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar iniciar sesion: " + e);
                return usuario;
            }
        }

        public String OrdenarTipoDocumento(String tipo)
        {
            String valor = "";

            if (tipo == "CC")
            {
                valor = "Cedula de ciudadania";
            }
            else if (tipo == "TI")
            {
                valor = "Tarjeta de identidad";
            }
            else if (tipo == "P")
            {
                valor = "Pasaporte";
            }
            else if (tipo == "DNI")
            {
                valor = "DNI";
            }
            else if (tipo == "CE")
            {
                valor = "Cedula de extranjeria";
            }
            return valor;
        }

        public String OrdenarTipoUsuario(String tipo)
        {
            String valor = "";

            if (tipo == "D")
            {
                valor = "Docente";
            }
            else if (tipo == "A")
            {
                valor = "Administrador";
            }
            else if (tipo == "S")
            {
                valor = "Secretaria";
            }
            return valor;
        }

        public String OrdenarEstadoUsuario(String tipo)
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

        public String OrdenarEstadoClave(String tipo)
        {
            String valor = "";

            if (tipo == "C")
            {
                valor = "Cambiada";
            }
            else
            {
                valor = "Sin cambiar";
            }
            return valor;
        }

    }
}
