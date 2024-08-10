using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class FruitsMenu : UserControl
    {
        public double price, amnt;
        public string name, organic;
        public FruitsMenu()
        {
            InitializeComponent();
        }
        private void WaterMelonButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 9.9;
                name = "Watermelon";
                organic = "Not organic";
                price *= amnt;
                Fruits Watermelon = new Fruits(name, price, organic);
                MainScreen.productsList.Add(Watermelon);
                MainScreen.instance.addListViewItem(Watermelon);
            }
        }
        private void OrangeButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 12.9;
                name = "Orange";
                organic = "Organic";
                price *= amnt;
                Fruits Orange = new Fruits(name, price, organic);
                MainScreen.productsList.Add(Orange);
                MainScreen.instance.addListViewItem(Orange);
            }
        }
        private void LemonButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 14.9;
                name = "Lemon";
                organic = "Organic";
                price *= amnt;
                Fruits Lemon = new Fruits(name, price, organic);
                MainScreen.productsList.Add(Lemon);
                MainScreen.instance.addListViewItem(Lemon);
            }
        }
    }
}