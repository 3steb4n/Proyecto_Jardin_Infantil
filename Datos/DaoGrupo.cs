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
                            grupo.UsuarioCreacion = (String)dr["UsuarioCreacion"];
                            grupo.FechaCreacion = (DateTime)dr["FechaCreacion"];
                            grupo.UsuarioModificacion = (String)dr["UsuarioModificacion"];
                            grupo.FechaModificacion = (DateTime)dr["FechaModificacion"];
                            grupo.EstadoGrupo = (String)dr["EstadoGrupo"];
                            grupo.Idgrado = (int)dr["IdGrado"];

                            list.Add(grupo);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante listaGeneral: "+e);
                return list;
            }
        }

    }
}
