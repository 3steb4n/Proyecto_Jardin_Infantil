using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoConceptoPago
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

        public List<ConceptoPago> ListaIDNombre()
        {
            List<ConceptoPago> list = new List<ConceptoPago>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Listar_Concepto_Pago", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        ConceptoPago c = new ConceptoPago();
                        c.IdConcepto = 0;
                        c.NombreConcepto = "Seleccione...";
                        c.ValorConcepto = 0;
                        list.Add(c);
                        while (dr.Read())
                        {
                            ConceptoPago conceptoPago = new ConceptoPago();

                            conceptoPago.IdConcepto = (int)dr["IdConcepto"];
                            conceptoPago.NombreConcepto = (String)dr["NombreConcepto"];
                            conceptoPago.ValorConcepto = (int)dr["ValorConcepto"];

                            list.Add(conceptoPago);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListaIDNombre: " + e);
                return list;
            }
        }
    }
}
