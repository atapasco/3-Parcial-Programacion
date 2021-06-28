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

        public List<Sede> ConsultarSedes()
        {
            List<Sede> sedes = new List<Sede>();
            using (var comando = sqlConnection.CreateCommand())
            {
                comando.CommandText = "SELECT idSede, NombreDeLaSede FROM Sedes";
                var lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Sede sede = new Sede();
                        sede.idSede = lector.GetInt32(0);
                        sede.NombreDeLaSede = lector.GetString(1);

                        sedes.Add(sede);
                    }
                }
                lector.Close();
            }
            return sedes;
        }

        public List<Producto> ConsultarProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (var comando = sqlConnection.CreateCommand())
            {
                comando.CommandText = "SELECT Codigo,Nombre,Valor FROM Productos";
                var lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Producto producto = new Producto();
                        producto.Codigo = lector.GetString(0);
                        producto.Nombre = lector.GetString(1);
                        producto.Valor = lector.GetDouble(2);

                        productos.Add(producto);
                    }
                }
                lector.Close();
            }
            return productos;
        }

        public void GuardarVentas(Venta venta)
        {
            using (var comando = sqlConnection.CreateCommand())
            {
                comando.CommandText = "insert into Ventas(idSede,codigoProducto,valor) values(@idSede,@codigoProducto,@valor)";
                comando.Parameters.AddWithValue("@idSede", venta.IdSede);
                comando.Parameters.AddWithValue("@codigoProducto", venta.CodigoProducto);
                comando.Parameters.AddWithValue("@valor", venta.Valor);

                comando.ExecuteNonQuery();
            }
        }

        public void GuardarProductos(Producto producto)
        {
            using (var comando = sqlConnection.CreateCommand())
            {
                comando.CommandText = "insert into Productos(Codigo,Nombre,Valor) values(@codigo,@nombre,@valor)";
                comando.Parameters.AddWithValue("@codigo", producto.Codigo);
                comando.Parameters.AddWithValue("@nombre", "nuevo producto");
                comando.Parameters.AddWithValue("@valor", producto.Valor);

                comando.ExecuteNonQuery();
            }
        }
    }
}
