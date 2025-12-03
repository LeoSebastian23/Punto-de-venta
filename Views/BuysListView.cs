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

        }

        private void LoadBuys()
        {
            
        }
    }
}
