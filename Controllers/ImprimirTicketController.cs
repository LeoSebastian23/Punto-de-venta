using Punto_de_venta.Models;
using Punto_de_venta.Services;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Punto_de_venta.Controllers
{
    public class ImprimirTicketController
    {
        private readonly TicketGenerator _generator;

        public ImprimirTicketController(TicketGenerator generator)
        {
            _generator = generator;
        }

        public void MostrarVistaPrevia(Sale sale)
        {
            PrintDocument ticket = _generator.CreateTicket(sale);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = ticket;
            preview.Width = 600;
            preview.Height = 800;

            preview.ShowDialog();
        }

        public void ImprimirDirectoPDF(Sale sale)
        {
            PrintDocument ticket = _generator.CreateTicket(sale);

            PrintDialog dialog = new PrintDialog();
            dialog.Document = ticket;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ticket.Print();
            }
        }
    }
}
