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
        SedeTryCatch sedeTryCatch;
        private ConexionBDRepository conexionBDRepository;
        private ConexionManager conexionManager;
        private ProductoTryCatch productoTryCatch;

        public ConexionBDService(string cadena)
        {
            conexionManager = new ConexionManager(cadena);
            conexionBDRepository = new ConexionBDRepository(conexionManager);
        }

        public string GuardarVentas(Venta venta)
        {
            try
            {
                conexionManager.Open();
                conexionBDRepository.GuardarVentas(venta);
                return "se guardo correctamente";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
            finally
            {
                conexionManager.Close();
            }
        }

        public string GuardarProducto(Producto producto)
        {
            try
            {
                conexionManager.Open();
                conexionBDRepository.GuardarProductos(producto);
                return "se guardo correctamente";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
            }
            finally
            {
                conexionManager.Close();
            }
        }

        public SedeTryCatch ConsultarSede()
        {
            try
            {
                conexionManager.Open();
                sedeTryCatch = new SedeTryCatch(conexionBDRepository.ConsultarSedes());
                return sedeTryCatch;
            }
            catch (Exception e)
            {
                sedeTryCatch = new SedeTryCatch($"ERROR: {e}");
                return sedeTryCatch;
            }
            finally
            {
                conexionManager.Close();
            }
        }

        public ProductoTryCatch ConsultarProductos()
        {
            try
            {
                conexionManager.Open();
                productoTryCatch = new ProductoTryCatch(conexionBDRepository.ConsultarProductos());
                return productoTryCatch;
            }
            catch (Exception e)
            {
                productoTryCatch = new ProductoTryCatch($"ERROR: {e}");
                return productoTryCatch;
            }
            finally
            {
                conexionManager.Close();
            }
        }

        public class SedeTryCatch
        {
            public List<Sede> Sedes { get; set; }
            public string MensajeDeError { get; set; }

            public SedeTryCatch(List<Sede> sedes)
            {
                this.Sedes = sedes;
                this.MensajeDeError = null;
            }
            public SedeTryCatch(string mensajeDeError)
            {
                this.Sedes = null;
                this.MensajeDeError = mensajeDeError;
            }
            public SedeTryCatch()
            {

            }
        }

        public class ProductoTryCatch
        {
            public List<Producto> productos { get; set; }
            public string MensajeDeError { get; set; }

            public ProductoTryCatch(List<Producto> productos)
            {
                this.productos = productos;
                this.MensajeDeError = null;
            }
            public ProductoTryCatch(string mensajeDeError)
            {
                this.productos = null;
                this.MensajeDeError = mensajeDeError;
            }
            public ProductoTryCatch()
            {

            }
        }
    }
}
