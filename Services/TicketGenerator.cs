using System;
using System.Drawing;
using System.Drawing.Printing;
using Punto_de_venta.Models;

namespace Punto_de_venta.Services
{
    public class TicketGenerator
    {
        private Sale _sale;
        private Font _font = new Font("Consolas", 9);
        private int _y = 0;

        public PrintDocument CreateTicket(Sale sale)
        {
            _sale = sale;

            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.PaperSize = new PaperSize("Custom58mm", 240, 600);
            doc.PrintPage += PrintPage;

            return doc;
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            _y = 0;

            void Draw(string text, int left = 0)
            {
                e.Graphics.DrawString(text, _font, Brushes.Black, left, _y);
                _y += 18;
            }

            Draw("----------------------------------------".Substring(0, 30));
            Draw("        OLIVIA - TICKET");
            Draw("----------------------------------------".Substring(0, 30));

            Draw($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}");
            Draw("----------------------------------------".Substring(0, 30));

            foreach (var item in _sale.Items)
            {
                string name = item.Product?.Name ?? "Prod";
                string qty = item.Quantity.ToString();
                string price = item.UnitPrice.ToString("0.00");
                string subtotal = item.Subtotal.ToString("0.00");

                Draw($"{name}");
                Draw($"  x{qty}   ${price}    => ${subtotal}");
            }

            Draw("----------------------------------------".Substring(0, 30));
            Draw($"TOTAL:               ${_sale.TotalAmount:0.00}");
            Draw("----------------------------------------".Substring(0, 30));
            Draw("Gracias por su compra!");

            e.HasMorePages = false;
        }
    }
}
