using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoPago
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

        public List<Pago> ListaGeneral()
        {
            List<Pago> list = new List<Pago>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarPago", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Pago pago = new Pago();

                            pago.IdPago = (int)dr["idPago"];
                            pago.ValorMonto = (int)dr["ValorMonto"];
                            pago.DescripcionPago = (String)dr["DescripcionPago"];
                            pago.Usuario.Id_usuario = (int)dr["UsuarioCreacion"];
                            pago.Usuario.Nombres = (String)dr["Nombres"];
                            pago.Usuario.Apellidos = (String)dr["Apellidos"];
                            pago.FechaCreacion = (DateTime)dr["FechaCreacion"];
                            pago.ConceptoPago.IdConcepto = (int)dr["IdConcepto"];
                            pago.ConceptoPago.NombreConcepto = (String)dr["NombreConcepto"];
                            pago.Estudiante.Id_estudiante = (int)dr["IDEstudiante"];
                            pago.Estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                            pago.Estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                            pago.Estudiante.ApellidoEstudiante = (String)dr["ApellidoEstudiante"];
                            pago.Estudiante.NombreAcudiente = (String)dr["AcudienteNombre"];
                            pago.Estudiante.CorreoElectronicoAcudiente = (String)dr["CorreoElectronico"];
                            pago.Estudiante.TelefonoAcudiente = (String)dr["telefono"];
                            pago.Estudiante.CelularAcudiente = (String)dr["celular"];
                            pago.Estudiante.Direccion = (String)dr["direccion"];

                            list.Add(pago);
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

        public List<Pago> ListarFiltro(String documento, String nombreConcepto)
        {
            List<Pago> list = new List<Pago>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarPagoFiltro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@documentoEstudiante", documento);
                    cmd.Parameters.AddWithValue("@nombreConcepto", nombreConcepto);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Pago pago = new Pago();

                            pago.IdPago = (int)dr["idPago"];
                            pago.ValorMonto = (int)dr["ValorMonto"];
                            pago.DescripcionPago = (String)dr["DescripcionPago"];
                            pago.Usuario.Id_usuario = (int)dr["UsuarioCreacion"];
                            pago.Usuario.Nombres = (String)dr["Nombres"];
                            pago.Usuario.Apellidos = (String)dr["Apellidos"];
                            pago.FechaCreacion = (DateTime)dr["FechaCreacion"];
                            pago.ConceptoPago.IdConcepto = (int)dr["IdConcepto"];
                            pago.ConceptoPago.NombreConcepto = (String)dr["NombreConcepto"];
                            pago.Estudiante.Id_estudiante = (int)dr["IDEstudiante"];
                            pago.Estudiante.DocumentoEstudiante = (String)dr["DocumentoEstudiante"];
                            pago.Estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];
                            pago.Estudiante.ApellidoEstudiante = (String)dr["ApellidoEstudiante"];
                            pago.Estudiante.NombreAcudiente = (String)dr["AcudienteNombre"];
                            pago.Estudiante.CorreoElectronicoAcudiente = (String)dr["CorreoElectronico"];
                            pago.Estudiante.TelefonoAcudiente = (String)dr["telefono"];
                            pago.Estudiante.CelularAcudiente = (String)dr["celular"];
                            pago.Estudiante.Direccion = (String)dr["direccion"];

                            list.Add(pago);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListarFiltro: " + e);
                return list;
            }
        }

        public bool InsertarPago(Pago pago)
        {
            bool flag = false;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarPago", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ValorMonto", pago.ValorMonto);
                    cmd.Parameters.AddWithValue("@DescripcionPago", pago.DescripcionPago);
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", pago.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@FechaCreacion", pago.FechaCreacion);
                    cmd.Parameters.AddWithValue("@IdConceptoPago", pago.ConceptoPago.IdConcepto);
                    cmd.Parameters.AddWithValue("@IdEstudiante", pago.Estudiante.Id_estudiante);

                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar pago : +" + e);
                return flag;
            }
        }
    }
}
