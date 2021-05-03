using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoardUI.Controles_Usuario
{
    public partial class ChartUC : UserControl
    {
        public ChartUC()
        {
            InitializeComponent();
        }
        public void cargarDatos(int[] mensualidades1, int[] mensualidades2)
        {
            string[] series = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            chartFactura1.Series[0].Points.DataBindXY(series, mensualidades1);
            chartFactura2.Series[0].Points.DataBindXY(series, mensualidades2);
        }

        private void chartFactura1_Click(object sender, EventArgs e)
        {

        }

        private void tlpCharts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloChart2_Click(object sender, EventArgs e)
        {

        }

        private void chartFactura2_Click(object sender, EventArgs e)
        {

        }
    }
}
