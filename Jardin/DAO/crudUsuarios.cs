using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Jardin.DTO;
using System.Data.SqlClient;

namespace Jardin.DAO
{
    class crudUsuarios:conexionBD
    {
        SqlConnection con;

        List<consultarUsuarios> obtenerDatosUsu = new List<consultarUsuarios>();

        public List<consultarUsuarios> verUsuario(String nomUsu)
        {
            con = conexion;
            SqlDataReader consultarData;
            SqlCommand instanciaSq = new SqlCommand("listarUsuarios", con);
            instanciaSq.CommandType = CommandType.StoredProcedure;
            instanciaSq.Parameters.AddWithValue("@NombreUsuario", nomUsu);
           /* int inc = 0;
            string[,] dt = new string[13,5];
            futuras entregas
            */
            con.Open();

            consultarData = instanciaSq.ExecuteReader();

            while (consultarData.Read())
            {
                obtenerDatosUsu.Add(new consultarUsuarios
                {
                    DocumentoUsuario = consultarData.GetString(0),
                    //TipoDocumento = consultarData.GetString(1),
                    //NombreUsuario = consultarData.GetString(2),
                    //ApellidoUsuario = consultarData.GetString(3),
                    //DireccionUsuario = consultarData.GetString(4),
                    //NumeroUsuario = consultarData.GetString(5),
                    //TelefonoUsuario = consultarData.GetString(6),
                    //EmailUsuario = consultarData.GetString(7),
                    //UsuarioLogin = consultarData.GetString(8),
                    //UsuarioCreacion = consultarData.GetString(9),
                    //FechaCreacion = consultarData.GetDateTime(10),
                    //EstadoUsuario = consultarData.GetString(11),
                    //TipoUsuario = consultarData.GetString(12)
                });
                /*
                for(int a=0; a<5; a++)
                {
                    dt[0,0]=consultarData.GetString(0);
                    Console.WriteLine(a);
                }

                inc += 1;
                futuras entregas
                */
                Console.WriteLine(consultarData.GetString(0));
            }

            consultarData.Close();
            con.Close();
            return obtenerDatosUsu;
        }
    }
}
