using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Jardin.DTO;

namespace Jardin.DAO
{
    class verificarUsuario:conexionBD
    {
        SqlConnection conn;
        List<usuariosLogin> obtenerDatos = new List<usuariosLogin>();
        public List<usuariosLogin> consultarUsuarios(String nombreUsuario, String claveUsuario)
        {
            conn = conexion;
            SqlDataReader consultarDatos;
            SqlCommand instanciaCmd = new SqlCommand("verificarUsuario", conn);
            instanciaCmd.CommandType = CommandType.StoredProcedure;
            instanciaCmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
            instanciaCmd.Parameters.AddWithValue("@Clave", claveUsuario);

            conn.Open();

            consultarDatos = instanciaCmd.ExecuteReader();

            while (consultarDatos.Read())
            {
                obtenerDatos.Add(new usuariosLogin
                {
                    TipoUsuario = consultarDatos.GetString(0),
                    NombreUsuario = consultarDatos.GetString(1)
                }); 
            }           

            consultarDatos.Close();
            conn.Close();
            return obtenerDatos;
        }
    }
}