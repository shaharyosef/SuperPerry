using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class VegtablesMenu : UserControl
    {
        public double price, amnt;
        public string name, organic;
        public VegtablesMenu()
        {
            InitializeComponent();
        }
        private void TomatoButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 3.9;
                name = "Tomato";
                organic = "Organic";
                price *= amnt;
                Vegetables Tomato = new Vegetables(name, price, organic);
                MainScreen.productsList.Add(Tomato);
                MainScreen.instance.addListViewItem(Tomato);
            }
        }
        private void CucumberButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 4.9;
                name = "Cucumber";
                organic = "Organic";
                price *= amnt;
                Vegetables Cucumber = new Vegetables(name, price, organic);
                MainScreen.productsList.Add(Cucumber);
                MainScreen.instance.addListViewItem(Cucumber);
            }
        }
        private void OnionButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 2.9;
                name = "Onion";
                organic = "Not organic";
                price *= amnt;
                Vegetables Onion = new Vegetables(name, price, organic);
                MainScreen.productsList.Add(Onion);
                MainScreen.instance.addListViewItem(Onion);
            }
        }
    }
}