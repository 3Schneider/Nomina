using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//se importan estas librerias
using System.Data.SqlClient;
using System.Data;

namespace LayerData
{
   public class LayerDataEmpleado
    {
        //string de conexion
        public string strconn = @"Data Source=COLSUTEC-PC;Initial Catalog=BDNomina;Integrated Security=True";
        //metodo constructor
        public LayerDataEmpleado(){}
        //metodo  insertar empleado
        public int InsertarEmpleado(Int64 Id, string Apellidos, string Nombre, double HorasTrabajadas, double SueldoXHora)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                //conexion a la base de datos
                cnx.Open();
                SqlCommand OrdenSql = new SqlCommand("SpInsertEmpleado", cnx);
                OrdenSql.CommandType = CommandType.StoredProcedure;
                //loque se va a ejecutar para validar si no prosigue
                try
                {
                    OrdenSql.Parameters.AddWithValue("@Id", Id);
                    OrdenSql.Parameters.AddWithValue("@Apellidos", Apellidos);
                    OrdenSql.Parameters.AddWithValue("@Nombre", Nombre);
                    OrdenSql.Parameters.AddWithValue("@SueldoXHora", SueldoXHora);
                    OrdenSql.Parameters.AddWithValue("@HorasTrabajadas", HorasTrabajadas);
                    return OrdenSql.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    //se cierra la conexion a la BD 
                    cnx.Close();
                    cnx.Dispose();
                    OrdenSql.Dispose();
                }
            }
        }
            public DataTable MostrarEmpleados()
            {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter dAd = new SqlDataAdapter("SpMostrarEmpleados", cnx);
                dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                try
                {
                    dAd.Fill(ds, "Table");
                    return ds.Tables["Table"];
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    dAd.Dispose();
                    ds.Dispose();
                }
            }
        }
     }
 }

