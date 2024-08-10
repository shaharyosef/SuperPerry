using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class ChickenMenu : UserControl
    {
        public double price, amnt;
        public string chickenText, name, cutType;

        public ChickenMenu()
        {
            InitializeComponent();
        }
        private void WingsButton_Click(object sender, EventArgs e)
        {
            chickenText = MainScreen.instance.WeightChoose();
            if (chickenText != "Error")
            {
                price = 29.9;    // price per 1 kg's
                amnt = (double.Parse(chickenText)) / 1000;   //weight in gram
                name = "Chicken wings";
                cutType = "2 parts";
                price *= amnt;    //price per item by grams
                Chicken wings = new Chicken(name, price, cutType);
                MainScreen.productsList.Add(wings);
                MainScreen.instance.addListViewItem(wings);
            }
        }
        private void BreastButton_Click(object sender, EventArgs e)
        {
            chickenText = MainScreen.instance.WeightChoose();
            if (chickenText != "Error")
            {
                price = 54.9;    // price per 1 kg's
                amnt = (double.Parse(chickenText)) / 1000;   //weight in gram
                name = "Chicken breast";
                cutType = "Fillet";
                price *= amnt;    //price per item by grams
                Chicken breast = new Chicken(name, price, cutType);
                MainScreen.productsList.Add(breast);
                MainScreen.instance.addListViewItem(breast);
            }
        }
        private void LegButton_Click(object sender, EventArgs e)
        {
            chickenText = MainScreen.instance.WeightChoose();
            if (chickenText != "Error")
            {
                price = 39.9;    // price per 1 kg's
                amnt = (double.Parse(chickenText)) / 1000;   //weight in gram
                name = "Chicken leg";
                cutType = "1 part";
                price *= amnt;    //price per item by grams
                Chicken leg = new Chicken(name, price, cutType);
                MainScreen.productsList.Add(leg);
                MainScreen.instance.addListViewItem(leg);
            }
        }
    }
}