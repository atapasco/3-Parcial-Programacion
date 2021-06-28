using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ConexionBDService
    {
        private ConexionBDRepository conexionBDRepository;
        private ConexionManager conexionManager;

        public ConexionBDService(string cadena)
        {
            conexionManager = new ConexionManager(cadena);
            conexionBDRepository = new ConexionBDRepository(conexionManager);
        }
    }
}
