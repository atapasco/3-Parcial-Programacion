using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Presentacion
{
    public partial class Form3 : Form
    {
        ConexionBDService conexionBDService;
        public Form3()
        {
            InitializeComponent();
            conexionBDService = new ConexionBDService(ExtraccionCadena.Conexion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexionBDService.ConsultarVentas();
        }
    }
}
