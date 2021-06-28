using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class ManejoArchivoRepository
    {
        
        public List<Venta> ConsultarVentas(string fileName)
        {
            List<Venta> ventas = new List<Venta>();

            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Venta venta = Map(linea);
                ventas.Add(venta);
            }

            reader.Close();
            file.Close();

            return ventas;
        }

        public Venta Map(string linea)
        {
            Venta venta = new Venta();
            string[] matriz = linea.Split(';');

            venta.IdSede = Convert.ToInt32(matriz[0]);
            venta.CodigoProducto = matriz[1];
            venta.Valor = Convert.ToDouble(matriz[2]);

            return venta;
        }
    }
}
