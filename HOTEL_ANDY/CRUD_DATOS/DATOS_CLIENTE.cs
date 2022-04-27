using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_DATOS
{
    public class DATOS_CLIENTE
    {
        private DATOS_CONECION conexion = new DATOS_CONECION();
        SqlDataReader lee;

        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.Abrirconexion();
            comando.CommandText = "motrar_estancia";
            comando.CommandType = CommandType.StoredProcedure;
            lee = comando.ExecuteReader();
            tabla.Load(lee);
            conexion.Cerrarconexion();
            return tabla;

        }
    }
}
