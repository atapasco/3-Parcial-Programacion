using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ManejoArchivoService
    {
        public ManejoArchivoRepository manejoArchivoRepository;
        public ArchivoVentaTryCatch archivoVentaTryCatch;
        public ManejoArchivoService()
        {
            manejoArchivoRepository = new ManejoArchivoRepository();
        }

        public ArchivoVentaTryCatch Consultar(string filename)
        {
            try
            {
                List<Venta> archivo = manejoArchivoRepository.ConsultarVentas(filename);
                archivoVentaTryCatch = new ArchivoVentaTryCatch(archivo);

                return archivoVentaTryCatch;
            }
            catch (Exception e)
            {
                archivoVentaTryCatch = new ArchivoVentaTryCatch("Se ha presentado la excepcion: " + e.Message);
                return archivoVentaTryCatch;
            }
        }

        public class ArchivoVentaTryCatch
        {
            public List<Venta> Ventas { get; set; }
            public string MensajeDeError { get; set; }

            public ArchivoVentaTryCatch(List<Venta> ventas)
            {
                this.Ventas = ventas;
                this.MensajeDeError = null;
            }
            public ArchivoVentaTryCatch(string mensajeDeError)
            {
                this.Ventas = null;
                this.MensajeDeError = mensajeDeError;
            }
            public ArchivoVentaTryCatch()
            {

            }
        }
    }
}
