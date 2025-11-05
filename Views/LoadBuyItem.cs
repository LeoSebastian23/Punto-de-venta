using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.Controllers;
using Punto_de_venta.Models;

namespace Punto_de_venta.Views
{
    public partial class LoadBuyItem : Form
    {
        private readonly BuyController _buyController;
        private readonly Product _product;
        public LoadBuyItem(BuyController buyController, Product product)
        {
            InitializeComponent();
            _buyController = buyController;
            _product = product;

        }

        private void LoadBuyItem_Load(object sender, EventArgs e)
        {
            txtNombre.Text = _product.Name;
            txtNombre.ReadOnly = true;
        }

        //Hasta que se cree la BuyItemController

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*int quantity = quantity;
            decimal unitPrice = unitPrice;
            decimal salePrice = salePrice;
            decimal marginProfit = marginProfit;*/
        }
    }
}
