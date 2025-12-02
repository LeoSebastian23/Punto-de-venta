using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Views
{
    public partial class ImprimirTicketView : Form
    {
        public ImprimirTicketView()
        {
            InitializeComponent();
        }

        private void ImprimirTicketView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ImprimirTicketView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //añadir logica aca
            }
        }
    }
}
