using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoardUI
{
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
            ttbMensajePU.Text = "Tienes que seleccionar un comercial para ver los datos";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ttbMensajePU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
