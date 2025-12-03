
using Punto_de_venta.Controllers;

namespace Punto_de_venta.Views
{
    public partial class BuysListView : Form
    {
        private readonly BuyController _controller;
        public BuysListView(BuyController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void BuysListView_Load(object sender, EventArgs e)
        {
            LoadBuys();
        }


        private void LoadBuys()
        {
            var buys = _controller.GetAllBuys().ToList();

            dgvBuysList.Rows.Clear();

            foreach (var b in buys)
            {
                dgvBuysList.Rows.Add(b.Id, b.Supplier?.Name, b.InvoiceNumber, b.Date, b.TotalAmount); 
                
            }
        }



    }
}
