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

        public List<Pagos> ListaGeneral()
        {
            List<Pagos> list = new List<Pagos>();
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
                            Pagos pago = new Pagos();

                            pago.IdPago = (int)dr["IdPago"];
                            pago.ValorMonto = (Decimal)dr["ValorMonto"];
                            pago.DescripcionPago = (String)dr["DescripcionPago"];
                            pago.ConceptoPago.IdConcepto = (int)dr["IdConcepto"];
                            pago.ConceptoPago.NombreConcepto = (String)dr["NombreConcepto"];
                            pago.Estudiante.Id_estudiante = (int)dr["IdEstudiante"];
                            pago.Estudiante.NombreEstudiante = (String)dr["NombreEstudiante"];


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
    }
}
