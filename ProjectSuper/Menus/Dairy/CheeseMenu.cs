using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class CheeseMenu : UserControl
    {
        public int fat;
        public double price, amnt;
        public string cheeseText, name;

        public CheeseMenu()
        {
            InitializeComponent();
        }
        private void CheddarButton_Click(object sender, EventArgs e)
        {
            cheeseText = MainScreen.instance.WeightChoose();
            if (cheeseText != "Error")
            {
                price = 114.9;    // price per 1 kg's
                fat = 3;
                amnt = (double.Parse(cheeseText)) / 1000;    //weight in gram
                name = "Cheddar";
                price *= amnt;    //price per item by grams
                Cheese Cheddar = new Cheese(name, price, fat.ToString());
                MainScreen.productsList.Add(Cheddar);
                MainScreen.instance.addListViewItem(Cheddar);
            }
        }
        private void GoudaButton_Click(object sender, EventArgs e)
        {
            cheeseText = MainScreen.instance.WeightChoose();
            if (cheeseText != "Error")
            {
                price = 129.9;    // price per 1 kg's
                fat = 28;
                amnt = (double.Parse(cheeseText)) / 1000;    //weight in gram
                name = "Gouda";
                price *= amnt;    //price per item by grams
                Cheese Gouda = new Cheese(name, price, fat.ToString());
                MainScreen.productsList.Add(Gouda);
                MainScreen.instance.addListViewItem(Gouda);
            }
        }
        private void GoatButton_Click(object sender, EventArgs e)
        {
            cheeseText = MainScreen.instance.WeightChoose();
            if (cheeseText != "Error")
            {
                price = 119.9;    // price per 1 kg's
                fat = 25;
                amnt = (double.Parse(cheeseText)) / 1000;    //weight in gram
                name = "Goat Cheese";
                price *= amnt;    //price per item by grams
                Cheese GoatCheese = new Cheese(name, price, fat.ToString());
                MainScreen.productsList.Add(GoatCheese);
                MainScreen.instance.addListViewItem(GoatCheese);
            }
        }
    }
}