using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoGrado
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

        public List<Grado> ListaGeneral()
        {
            List<Grado> list = new List<Grado>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarGrados", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Grado grado = new Grado();

                            grado.IdGrado = (int)dr["idGrado"];
                            grado.NombreGrado = (String)dr["NombreGrado"];

                            list.Add(grado);
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
