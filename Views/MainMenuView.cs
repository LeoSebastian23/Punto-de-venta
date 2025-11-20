using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Punto_de_venta.Views
{
    public partial class MainMenuView : Form
    {
        private readonly IServiceProvider _services;

        public MainMenuView(IServiceProvider services)
        {
            InitializeComponent();
            _services = services;
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            var view = _services.GetRequiredService<SupplierView>();
            view.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var view = _services.GetRequiredService<ProductView>();
            view.ShowDialog();
        }

        private void btnBuys_Click(object sender, EventArgs e)
        {
            var view = _services.GetRequiredService<BuyView>();
            view.ShowDialog();
        }
    }
}

