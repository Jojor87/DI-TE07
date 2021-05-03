using DashboardBLL;
using DashBoardUI.Controles_Usuario;  //para utilizar los controles de usuario
using DashboardUtilidades;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DashBoardUI
{
    public partial class Form1 : Form
    {
        private ChartUC guChart; // Control de usuario Chart
        private DatosComercial guDatos; // Control de usuario datos comercial
        private TableLayoutPanel tlp;
        private ComercialVO comercial;
        private FacturacionVO facturacion1;
        private FacturacionVO facturacion2;
        private int numComercial = 0; // variable para saber que comercial se selecciona
        bool visibleChartFactura = false; // Var para poner visible la gráfica de facturacion total anual

        public Form1()
        {
            InitializeComponent();
            tlp = tlpChar;
            guChart = new Controles_Usuario.ChartUC();
            guDatos = new Controles_Usuario.DatosComercial();

            this.ttMensaje.SetToolTip(this.btnDatos, "Haz click para que se muestren los datos del comercial");
            this.ttMensaje.SetToolTip(this.btnFacturacion, "Haz click para que se muestren las ventas totales anuales a cada empresa");
            this.ttMensaje.SetToolTip(this.btnVentas, "Haz click para que se muestren los gráficos de las ventas mensualmente");
            this.ttMensaje.SetToolTip(this.btnComercial1, "Haz click para seleccionar el comercial 1");
            this.ttMensaje.SetToolTip(this.btnComercial2, "Haz click para seleccionar el comercial 2");
            this.ttMensaje.SetToolTip(this.btnComercial3, "Haz click para seleccionar el comercial 3");
            this.ttMensaje.SetToolTip(this.pictureComercial1, "Imagen de comercial 1");
            this.ttMensaje.SetToolTip(this.pictureComercial2, "Imagen de comercial 2");
            this.ttMensaje.SetToolTip(this.pictureComercial3, "Imagen de comercial 3");
        }
        private void btnComercial1_Click_1(object sender, EventArgs e)
        {
            // Se eliminan los controles de usuario
            tlp.Controls.Remove(guDatos);
            tlp.Controls.Remove(guChart);

            numComercial = 1;
            this.comercial = new ComercialVO(1);

            // cambiamos color para hacer ver cual esta seleccionado
            btnComercial1.ForeColor = Color.Yellow;
            btnComercial2.ForeColor = Color.WhiteSmoke;
            btnComercial2.ForeColor = Color.WhiteSmoke;
        }

        private void btnComercial2_Click_1(object sender, EventArgs e)
        {
            // Se eliminan los controles de usuario
            tlp.Controls.Remove(guDatos);
            tlp.Controls.Remove(guChart);

            numComercial = 2;
            this.comercial = new ComercialVO(2);
            // cambiamos color para hacer ver cual esta seleccionado
            btnComercial2.ForeColor = Color.Yellow;
            btnComercial3.ForeColor = Color.WhiteSmoke;
            btnComercial1.ForeColor = Color.WhiteSmoke;
        }

        private void btnComercial3_Click_1(object sender, EventArgs e)
        {
            // Se eliminan los controles de usuario
            tlp.Controls.Remove(guDatos);
            tlp.Controls.Remove(guChart);

            numComercial = 3;
            this.comercial = new ComercialVO(3);

            // cambiamos color para hacer ver cual esta seleccionado
            btnComercial3.ForeColor = Color.Yellow;
            btnComercial2.ForeColor = Color.WhiteSmoke;
            btnComercial1.ForeColor = Color.WhiteSmoke;
        }


        //Método mostrar facturacíón anual comercial
        private void btnDatos_Click(object sender, EventArgs e)
        {
            if (numComercial < 1)
            {
                PopUp pu = new PopUp();
                pu.Show();
            } else { 
                tlp.Controls.Remove(guDatos); // Se eliminan los controles de usuario
                tlp.Controls.Remove(guChart);

                GestionDatosBLL comercialDatos = new GestionDatosBLL();// se inicializa la clase BLL

                guDatos.pintaTextBox(comercialDatos.gestionaDatos(comercial)); //se manda el objeto parseado al control de usuario

                tlp.Controls.Add(guDatos, 0, 0); // Lo añade en la columna 0, fila 0
            }
        }

        // Método mostrar facturacíón anual comercial
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            if (numComercial < 1)
            {
                PopUp pu = new PopUp();
                pu.Show();
            }
            else
            {
                tlp.Controls.Remove(guDatos); // Se eliminan los controles de usuario
                tlp.Controls.Remove(guChart);

                facturacion1 = new FacturacionVO(numComercial, 1);// se inicializa las clases factura
                facturacion2 = new FacturacionVO(numComercial, 2);
                visibleChartFactura = true;

                GestionDatosBLL comercialDatos = new GestionDatosBLL();// se inicializa la clase BLL

                guDatos.pintaTextBoxFacturacion(comercialDatos.gestionaFactura(facturacion1), comercialDatos.gestionaFactura(facturacion2), visibleChartFactura);
                guDatos.Dock = DockStyle.Fill;
                tlp.Controls.Add(guDatos, 0, 0); // Lo añade en la columna 0, fila 0
            }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (numComercial < 1)
            {
                PopUp pu = new PopUp();
                pu.Show();
            }
            else
            {
                tlp.Controls.Remove(guDatos); // Elimina el control datos comercial
                visibleChartFactura = false;

                facturacion1 = new FacturacionVO(numComercial, 1);// se inicializa las clases factura
                facturacion2 = new FacturacionVO(numComercial, 2);

                GestionDatosBLL comercialDatos = new GestionDatosBLL();// se inicializa la clase BLL

                guDatos.pintaTextBoxFacturacion(comercialDatos.gestionaFactura(facturacion1), comercialDatos.gestionaFactura(facturacion2), visibleChartFactura);
                guChart.cargarDatos(facturacion1.mes, facturacion2.mes);
                guChart.Dock = DockStyle.Fill;
                tlp.Controls.Add(guChart, 0, 0); // Lo añade en la columna 0, fila 0
            }
        }

        /*
         * Acciones del menú menuStrip
         */
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que abre archivo csv donde se guardan los datos de comerciales
        private void archivoDatosComercialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("..\\..\\..\\DashboardDAL\\BD\\1_datos_comerciales.csv");
            }
            catch (Exception i)
            {
                Console.WriteLine("Exception: " + i.Message);
            }
        }

        //Método que abre archivo csv donde se guarda la facturación de cada comercial
        private void archivoDatosFacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("..\\..\\..\\DashboardDAL\\BD\\2_facturacion_comercial.csv");
            }
            catch (Exception i)
            {
                Console.WriteLine("Exception: " + i.Message);
            }
        }

        /*
         * Selección de comercial
         */
        private void comercial1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnComercial1_Click_1(sender, e);
        }

        private void comercial2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnComercial2_Click_1(sender, e);
        }

        private void comercial3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnComercial3_Click_1(sender, e);
        }

        /*
         * Opciones en ayuda
         */
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://..\\..\\..\\..\\Manual de usuario\\Manual de Usuario.chm");
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacción desarrollada por Jordi Osuna\nSi desea ponerse en contacto, hágalo a través de:\njosuna@birt.eus", "ACERCA DE...");
        }

        private void tlpMenuDer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpChar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ttMensaje_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
