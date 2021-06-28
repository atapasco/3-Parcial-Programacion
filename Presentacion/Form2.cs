using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form2 : Form
    {
        private List<Sede> sedes;
        private List<string> nombreSedes;
        private ConexionBDService conexionBDService;
        private ManejoArchivoService manejoArchivoService;
        private List<Venta> ventas;
        private int opcion = 0;
        private List<Producto> productos;
        public Form2()
        {
            InitializeComponent();
            productos = new List<Producto>();
            sedes = new List<Sede>();
            ventas = new List<Venta>();
            nombreSedes = new List<string>();
            manejoArchivoService = new ManejoArchivoService();
            conexionBDService = new ConexionBDService(ExtraccionCadena.Conexion);
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            SeleccionCombox();
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName != null)
            {
                string file = openFile.FileName;

                if (manejoArchivoService.Consultar(file).MensajeDeError == null)
                {
                    ventas = manejoArchivoService.Consultar(file).Ventas;
                    productos = conexionBDService.ConsultarProductos().productos;

                    MessageBox.Show("secargo el archivo");
                    foreach (var item in ventas)
                    {
                        foreach (var item2 in productos)
                        {
                            if (item.IdSede == opcion && item.Valor == item2.Valor && item.CodigoProducto == item2.Codigo)
                            {
                                conexionBDService.GuardarVentas(item) ;
                            }
                            if (item.IdSede == opcion && item.CodigoProducto != item2.Codigo)
                            {
                                Producto productoaux = new Producto();
                                productoaux.Codigo = item.CodigoProducto;
                                productoaux.Valor = item.Valor;
                                productoaux.Nombre = "";
                                conexionBDService.GuardarProducto(productoaux);
                            }
                        }
                    }
                }
                else
                {
                    ventas = null;
                    MessageBox.Show("Archivo invalido");
                }
            }

            
        }
        public void SeleccionCombox()
        {
            foreach (var item in sedes)
            {
                if (cmbCargueArchivo.Text == item.NombreDeLaSede)
                {
                    opcion = item.idSede;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (conexionBDService.ConsultarSede().MensajeDeError == null)
            {
                sedes = conexionBDService.ConsultarSede().Sedes;
                foreach (var item in sedes)
                {
                    nombreSedes.Add(item.NombreDeLaSede);
                }
                cmbCargueArchivo.DataSource = nombreSedes;
            }
        }
    }
}
