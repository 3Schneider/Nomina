using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para trabajar con instruciones SQL
using System.Data;

namespace LayerBusinness
{
    public class LayerBusinnessEmpleado
    {
        LayerData.LayerDataEmpleado DALe = new LayerData.LayerDataEmpleado();
        //metodo que reciba los 5 parametros y se los pase a star procidius
        public int InsertarEmpleado(Int64 Id, string Apellidos, string Nombre, double Horas, double Sueldo)
        {
            try
            {
                return DALe.InsertarEmpleado(Id, Apellidos, Nombre, Horas, Sueldo);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DALe = null;
            }
        }
        //metodo mostrar
        public DataTable MostrarEmpleado()
        {
            try
            {
                return DALe.MostrarEmpleados();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DALe = null;
            }
        }
    }
}
 