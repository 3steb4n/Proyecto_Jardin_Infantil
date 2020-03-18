using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoAbonoPago
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

        public List<AbonoPago> ListaGeneral(int idPago)
        {
            List<AbonoPago> list = new List<AbonoPago>();
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarAbonoPago", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Pago", idPago);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            AbonoPago abono = new AbonoPago();

                            abono.IdAbonoPago = (int)dr["IdAbonoPago"];
                            abono.TipoAbono = OrdenarTipoAbono((String)dr["TipoAbono"]);
                            abono.ValorAbono = (int)dr["ValorAbonado"];
                            abono.DescripcionAbono = (String)dr["DescripcionAbono"];
                            abono.FechaCreacion = (DateTime)dr["fechaCreacion"];
                            abono.Pago.IdPago = (int)dr["idPago"];
                            abono.Pago.DescripcionPago = (String)dr["descripcionPago"];
                            abono.usuario.Id_usuario = (int)dr["idUsuario"];
                            abono.usuario.Nombres = (String)dr["Nombres"];
                            abono.usuario.Apellidos = (String)dr["Apellidos"];

                            list.Add(abono);
                        }
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ListaGeneral: " + e);
                return list;
            }
        }

        public int ValorAbonado(int idPago)
        {
            int valorAbonado = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ListarDineroAbonado", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Pago", idPago);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr != null & dr.HasRows)
                    {
                        dr.Read();
                        valorAbonado = (int)dr["ValorAbonado"];
                    }
                }
                return valorAbonado;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar mediante ValorAbonado: " + e);
                return valorAbonado;
            }
        }

        public bool InsertarAbono(AbonoPago abono)
        {
            bool flag = false;
            try
            {

                using (SqlConnection con = new SqlConnection(CadenaConexion))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("registrarAbonoPago", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Tipo_Abono", abono.TipoAbono);
                    cmd.Parameters.AddWithValue("@Valor_Abonado", abono.ValorAbono);
                    cmd.Parameters.AddWithValue("@Descripcion_Abono", abono.DescripcionAbono);
                    cmd.Parameters.AddWithValue("@Usuario_Creacion", abono.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@Fecha_Creacion", abono.FechaCreacion);
                    cmd.Parameters.AddWithValue("@Id_Pago_Registrado", abono.Pago.IdPago);

                    flag = cmd.ExecuteNonQuery() != 0;
                }
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al insertar abono: +" + e);
                return flag;
            }
        }

        public String OrdenarTipoAbono(String tipo)
        {
            String value = "";
            if (tipo == "P")
            {
                value = "Parcial";
            }
            else if (tipo == "C")
            {
                value = "Completado";
            }
            return value;
        }
    }
}
