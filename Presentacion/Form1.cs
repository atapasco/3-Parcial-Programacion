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
    public partial class Form1 : Form
    {
        private ConexionBDService conexionBDService;
        public Form1()
        {
            InitializeComponent();
            conexionBDService = new ConexionBDService(ExtraccionCadena.Conexion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
