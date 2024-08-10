using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class IceCreamMenu : UserControl
    {
        public int fat;
        public double price, amnt;
        public string name;
        public IceCreamMenu()
        {
            InitializeComponent();
        }
        private void ChocolateButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 22.9;
                fat = 10;
                name = "Chocolate";
                price *= amnt;
                IceCream chocolate = new IceCream(name, price, fat.ToString());
                MainScreen.productsList.Add(chocolate);
                MainScreen.instance.addListViewItem(chocolate);
            }
        }
        private void VanillaButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 19.9;
                fat = 17;
                name = "Vanilla";
                price *= amnt;
                IceCream Vanilla = new IceCream(name, price, fat.ToString());
                MainScreen.productsList.Add(Vanilla);
                MainScreen.instance.addListViewItem(Vanilla);
            }
        }
        private void StrawberryButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 24.9;
                fat = 4;
                name = "Strawberry";
                price *= amnt;
                IceCream Strawberry = new IceCream(name, price, fat.ToString());
                MainScreen.productsList.Add(Strawberry);
                MainScreen.instance.addListViewItem(Strawberry);
            }
        }
    }
}