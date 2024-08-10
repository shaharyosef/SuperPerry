using System;
using System.Windows.Forms;
using System.Linq;
namespace ProjectSuper
{
    public partial class FrozenMenu : UserControl
    {
        public double price, amnt;
        public string frozenText, name, organic;

        public FrozenMenu()
        {
            InitializeComponent();
        }
        private void PeaseButton_Click(object sender, EventArgs e)
        {
            frozenText = MainScreen.instance.WeightChoose();
            if (frozenText != "Error")
            {
                price = 13.9;    // price per 1 kg's
                amnt = (double.Parse(frozenText)) / 1000;    //weight in gram
                name = "Peas";
                organic = "Not organic";
                price *= amnt;    //price per item by grams
                Frozen pease = new Frozen(name, price, organic);
                MainScreen.productsList.Add(pease);
                MainScreen.instance.addListViewItem(pease);
            }
        }
        private void Spinach_Click(object sender, EventArgs e)
        {
            frozenText = MainScreen.instance.WeightChoose();
            if (frozenText != "Error")
            {
                price = 19.9;    // price per 1 kg's
                amnt = (double.Parse(frozenText)) / 1000;    //weight in gram
                name = "Spinach";
                organic = "Not organic";
                price *= amnt;    //price per item by grams
                Frozen spinach = new Frozen(name, price, organic);
                MainScreen.productsList.Add(spinach);
                MainScreen.instance.addListViewItem(spinach);
            }
        }
        private void BroccoliButton_Click(object sender, EventArgs e)
        {
            frozenText = MainScreen.instance.WeightChoose();
            if (frozenText != "Error")
            {
                price = 15.9;    // price per 1 kg's
                amnt = (double.Parse(frozenText)) / 1000;    //weight in gram
                name = "Broccoli";
                organic = "Not organic";
                price *= amnt;    //price per item by grams
                Frozen Pease = new Frozen(name, price, organic);
                MainScreen.productsList.Add(Pease);
                MainScreen.instance.addListViewItem(Pease);
            }
        }
    }
}