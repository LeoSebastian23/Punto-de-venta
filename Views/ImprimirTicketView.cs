using System;
using System.Windows.Forms;
using Punto_de_venta.Controllers;
using Punto_de_venta.Models;

namespace Punto_de_venta.Views
{
    public partial class ImprimirTicketView : Form
    {
        private readonly ImprimirTicketController _controller;
        private readonly Sale _sale;

        public ImprimirTicketView(ImprimirTicketController controller, Sale sale)
        {
            _controller = controller;
            _sale = sale;

            InitializeComponent();
        }

        private void ImprimirTicketView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            if (e.KeyCode == Keys.Enter)
            {
                _controller.MostrarVistaPrevia(_sale);
                Close();
            }
        }
    }
}
