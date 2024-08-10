using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class WineMenu : UserControl
    {
        public double price, amnt;
        public string name, flavor;
        public WineMenu()
        {
            InitializeComponent();
        }
        private void PinoButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 54.9;
                name = "Pino Noir";
                flavor = "Sweet";
                price *= amnt;
                Wine Pino = new Wine(name, price, flavor);
                MainScreen.productsList.Add(Pino);
                MainScreen.instance.addListViewItem(Pino);
            }
        }
        private void CavaButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 42.9;
                name = "Cava";
                flavor = "Very sweet";
                price *= amnt;
                Wine Cava = new Wine(name, price, flavor);
                MainScreen.productsList.Add(Cava);
                MainScreen.instance.addListViewItem(Cava);
            }
        }
        private void MerlotButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 39.9;
                name = "Merlot";
                flavor = "Bitter";
                price *= amnt;
                Wine Merlot = new Wine(name, price, flavor);
                MainScreen.productsList.Add(Merlot);
                MainScreen.instance.addListViewItem(Merlot);
            }
        }
    }
}