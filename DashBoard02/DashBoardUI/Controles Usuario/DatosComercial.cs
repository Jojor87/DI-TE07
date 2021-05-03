using DashboardUtilidades;
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
    public partial class DatosComercial : UserControl
    {
        public DatosComercial()
        {
            InitializeComponent();
        }
        //método que pinta la información del comercial
        public void pintaTextBox(ComercialVO comercial)
        {
            txtDatosComercial.Text = comercial.ToString();
            chartFacturaTotal.Visible = false;
        }

        public void pintaTextBoxFacturacion(FacturacionVO factura1, FacturacionVO factura2, bool visible)
        {

            string[] series = { "Empresa 1", "Empresa 2" };
            int[] total = { factura1.total(), factura2.total() };
            txtDatosComercial.Text = "\r\n" + factura1.ToString() + factura2.ToString();

            chartFacturaTotal.Visible = visible;// pone visible cuando se da a botón de factura total
            chartFacturaTotal.Series[0].Points.DataBindXY(series, total);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void txtDatosComercial_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartFacturaTotal_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
