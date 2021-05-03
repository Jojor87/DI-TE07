using System;
using System.Collections.Generic;
using System.Text;

namespace DashboardUtilidades
{
    public class FacturacionVO
    {
        private int id;
        private int empresa;
        public int[] mes = new int[12];

        public FacturacionVO(int id, int empresa)
        {
            this.id = id;
            this.empresa = empresa;
        }

        public int Id { get => id; set => id = value; }
        public int Empresa { get => empresa; set => empresa = value; }

        public int total()
        {
            int total = 0;

            foreach (int t in mes)
            {
                total += t;
            }

            return total;
        }
        //public int[] Mes { get => mes; set => mes = value; }

        public override string ToString()
        {
            string factura;

            factura = "Facturación total anual en empresa nº" + empresa + ": " + total() + "€ \r\n";

            return factura;
        }
    }
}
