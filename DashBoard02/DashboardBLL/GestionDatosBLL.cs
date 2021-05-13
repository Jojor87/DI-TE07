using DashboardDAL;
using DashboardUtilidades;
using System;

namespace DashboardBLL
{
    public class GestionDatosBLL
    {
            //constructor() {}
            public GestionDatosBLL()
            {

            }

            //Método que manda el objetoVO a la capa del dal y lo retorna una vez se han parseado los datos 
            // del comercial en la capa DAL
            public ComercialVO gestionaDatos(ComercialVO comercial)
            {

                GestionDatosDAL comercialDatos = new GestionDatosDAL();
                comercialDatos.leerDatosComercial(comercial);

                return comercial;
            }

            //Método que manda el objetoVO a la capa del dal y lo retorna una vez se han parseado los datos 
            // de facturación en la capa DAL
            public FacturacionVO gestionaFactura(FacturacionVO factura)
            {

                GestionDatosDAL comercialDatos = new GestionDatosDAL();
                comercialDatos.leerFacturacionComercial(factura);

                return factura;
            }

        ////Método que manda el objetoVO a la capa del dal y lo retorna una vez se han parseado los datos 
        //// de facturación en la capa DAL
        //public string gestionaFactura(FacturacionVO factura)
        //{

        //    GestionDatosDAL comercialDatos = new GestionDatosDAL();
        //    comercialDatos.leerFacturacionComercial(factura);

        //    return factura.ToString();
        //}


    }
}
