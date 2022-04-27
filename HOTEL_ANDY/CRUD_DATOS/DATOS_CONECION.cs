using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_DATOS
{
    public class DATOS_CONECION
    {
        private SqlConnection conexcion = new SqlConnection("server=DESKTOP-JOV9P95;database=BD_HOTE;user=sa;password=123");
        public SqlConnection Abrirconexion()
        {
            if (conexcion.State == ConnectionState.Closed)
                conexcion.Open();
            return conexcion;
        }
        public SqlConnection Cerrarconexion()
        {
            if (conexcion.State == ConnectionState.Open)
                conexcion.Close();
            return conexcion;
        }
    }
}
