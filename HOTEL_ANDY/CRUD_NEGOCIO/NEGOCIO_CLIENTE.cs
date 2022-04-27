using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CRUD_DATOS;
namespace CRUD_NEGOCIO
{
    public class NEGOCIO_CLIENTE
    {
        private DATOS_CLIENTE objcliente = new DATOS_CLIENTE();

        public DataTable mostrar_estancia()
        {
            DataTable tabla = new DataTable();
            tabla = objcliente.mostrar();
            return tabla;
        }
    }
}
