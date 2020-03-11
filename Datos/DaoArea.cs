using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoArea
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

        public List<Area> ListaGeneral()
        {
            List<Area> list = new List<Area>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarAreas", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Area area = new Area();

                            area.IdArea = (int)dr["IdArea"];
                            area.NombreArea = (String)dr["NombreArea"];

                            list.Add(area);
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
