using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class ConexionBDRepository
    {
        private ConexionManager conexionManager;
        SqlConnection sqlConnection;

        public ConexionBDRepository(ConexionManager conexionManager)
        {
            sqlConnection = conexionManager.Conexion;
        }
    }
}
