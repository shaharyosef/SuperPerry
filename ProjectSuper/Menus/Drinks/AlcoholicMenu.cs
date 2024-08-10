using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class AlcoholicMenu : UserControl
    {
        public double price, amnt;
        public string name, flavor;
        public AlcoholicMenu()
        {
            InitializeComponent();
        }
        private void RumButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 84.9;
                name = "Carta Blanca Rum";
                flavor = "Spicy";
                price *= amnt;
                Alcoholic Rum = new Alcoholic(name, price, flavor);
                MainScreen.productsList.Add(Rum);
                MainScreen.instance.addListViewItem(Rum);
            }
        }
        private void BeerButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 9.9;
                name = "Corona";
                flavor = "Sweet and little bitter";
                price *= amnt;
                Alcoholic Beer = new Alcoholic(name, price, flavor);
                MainScreen.productsList.Add(Beer);
                MainScreen.instance.addListViewItem(Beer);
            }
        }
        private void WhiskeyButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 134.9;
                name = "Black Label Scotch";
                flavor = "Bitter";
                price *= amnt;
                Alcoholic Whiskey = new Alcoholic(name, price, flavor);
                MainScreen.productsList.Add(Whiskey);
                MainScreen.instance.addListViewItem(Whiskey);
            }
        }
    }
}