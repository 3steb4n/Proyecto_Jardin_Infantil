using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

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
                    SqlCommand cmd = new SqlCommand("ListarEstudiante", con);
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
                            estudiante.NombreAcudiente = (String)dr["NombreAcudiente"];
                            estudiante.Direccion = (String)dr["Direccion"];
                            estudiante.Genero = (String)dr["Genero"];
                            estudiante.TelefonoAcudiente = (String)dr["TelefonoAcudiente"];
                            estudiante.CelularAcudiente = (String)dr["CelularEstudiante"];
                            estudiante.CorreoElectronicoAcudiente = (String)dr["CorreoElectronicoAcudiente"];
                            estudiante.ObservacionesEstudiante = (String)dr["ObservacionesEstudiante"];
                            estudiante.UsuarioCreacion = (String)dr["UsuarioCreacion"];
                            estudiante.FechaCreacion = (DateTime)dr["FechaCreaacion"];
                            estudiante.UsuarioModificacion = (String)dr["UsuarioModificacion"];
                            estudiante.FechaModificacion = (DateTime)dr["FechaModificacion"];
                            estudiante.EstadoEstudiante = OrdenarEstadoEstudiante((String)dr["EstadoEstudiante"]);
                            estudiante.IdGrupo = (int)dr["IdGrupo"];

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

        public Estudiante ListaPorDocumento(String documento)
        {

            Estudiante estudiante = new Estudiante();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarEstudiante", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        estudiante = new Estudiante();

                        estudiante.Id_estudiante = (int)dr["IdEstudiante"];
                        estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                        estudiante.TipoDocumento = OrdenarTipoDocumento((String)dr["TipoDocumento"]);
                        estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                        estudiante.ApellidoEstudiante = (String)dr["ApellidoEstudiante"];
                        estudiante.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                        estudiante.Ruta_foto = (String)dr["RutaFoto"];
                        estudiante.NombreAcudiente = (String)dr["NombreAcudiente"];
                        estudiante.Direccion = (String)dr["Direccion"];
                        estudiante.Genero = (String)dr["Genero"];
                        estudiante.TelefonoAcudiente = (String)dr["TelefonoAcudiente"];
                        estudiante.CelularAcudiente = (String)dr["CelularEstudiante"];
                        estudiante.CorreoElectronicoAcudiente = (String)dr["CorreoElectronicoAcudiente"];
                        estudiante.ObservacionesEstudiante = (String)dr["ObservacionesEstudiante"];
                        estudiante.UsuarioCreacion = (String)dr["UsuarioCreacion"];
                        estudiante.FechaCreacion = (DateTime)dr["FechaCreaacion"];
                        estudiante.UsuarioModificacion = (String)dr["UsuarioModificacion"];
                        estudiante.FechaModificacion = (DateTime)dr["FechaModificacion"];
                        estudiante.EstadoEstudiante = OrdenarEstadoEstudiante((String)dr["EstadoEstudiante"]);
                        estudiante.IdGrupo = (int)dr["IdGrupo"];

                    }
                }

                return estudiante;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listaPorDocumento: " + e);
                return estudiante;
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
                    cmd.Parameters.AddWithValue("@NombreAcudiente", estudiante.NombreAcudiente);
                    cmd.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                    cmd.Parameters.AddWithValue("@Genero", estudiante.Genero);
                    cmd.Parameters.AddWithValue("@TelefonoAcudiente", estudiante.TelefonoAcudiente);
                    cmd.Parameters.AddWithValue("@CelularEstudiante", estudiante.CelularAcudiente);
                    cmd.Parameters.AddWithValue("@CorreoElectronicoAcudiente", "A");
                    cmd.Parameters.AddWithValue("@ObservacionesEstudiante", "S");
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", estudiante.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreaacion", estudiante.FechaCreacion);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", estudiante.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", estudiante.FechaModificacion);
                    cmd.Parameters.AddWithValue("@EstadoEstudiante", estudiante.EstadoEstudiante);
                    cmd.Parameters.AddWithValue("@IdGrupo",estudiante.IdGrupo);

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
                    cmd.Parameters.AddWithValue("@NombreAcudiente", estudiante.NombreAcudiente);
                    cmd.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                    cmd.Parameters.AddWithValue("@Genero", estudiante.Genero);
                    cmd.Parameters.AddWithValue("@TelefonoAcudiente", estudiante.TelefonoAcudiente);
                    cmd.Parameters.AddWithValue("@CelularEstudiante", estudiante.CelularAcudiente);
                    cmd.Parameters.AddWithValue("@CorreoElectronicoAcudiente", "A");
                    cmd.Parameters.AddWithValue("@ObservacionesEstudiante", "S");
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", estudiante.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreaacion", estudiante.FechaCreacion);
                    cmd.Parameters.AddWithValue("@UsuarioModificacion", estudiante.UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@FechaModificacion", estudiante.FechaModificacion);
                    cmd.Parameters.AddWithValue("@EstadoEstudiante", estudiante.EstadoEstudiante);
                    cmd.Parameters.AddWithValue("@IdGrupo", estudiante.IdGrupo);

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
                    SqlCommand cmd = new SqlCommand("EliminarEstudiante", con);
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

            if (tipo == "RG")
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

    }
}
