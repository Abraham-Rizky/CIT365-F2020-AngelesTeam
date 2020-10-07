using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Abraham
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(Desk desk)
        {
            InitializeComponent();
            nameLabel.Text = desk.CustomerName;
            widthLabel.Text = Convert.ToString( desk.Width );
            depthLabel.Text = Convert.ToString( desk.Depth );
            drawersLabel.Text = Convert.ToString( desk.NumberOfDrawers );
            materialLabel.Text = Convert.ToString(desk.SurfaceMaterial);
            materialCostLabel.Text = "$ " + Convert.ToString(desk.MaterialCost);
            drawerCostLabel.Text = "$ " + Convert.ToString(desk.DrawerCost) + ".00";
            shippingLabel.Text = "$ " + Convert.ToString(desk.ShippingCost);
            oversizeCostLabel.Text = "$ " + Convert.ToString(desk.OversizeCost + ".00");
            dateLabel.Text = desk.Date;
            totalPriceLabel.Text = "$ " + Convert.ToString(desk.OversizeCost + desk.basePrice + desk.DrawerCost + desk.ShippingCost + desk.MaterialCost);
            //dateLabel.Text = Convert.ToString (desk.Area);
        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {

            AddQuote openAddQuote = new AddQuote();
            openAddQuote.Tag = this;
            openAddQuote.Show(this);
            Hide();
        }

    }
}
