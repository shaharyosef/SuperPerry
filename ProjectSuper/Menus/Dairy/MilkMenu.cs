using System;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class MilkMenu : UserControl
    {
        public int fat;
        public double price, amnt;
        public string name;
        public MilkMenu()
        {
            InitializeComponent();
        }

        private void GoatMilkButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 12.9;
                fat = 5;
                name = "Goat milk";
                price *= amnt;
                Milk GoatMilk = new Milk(name, price, fat.ToString());
                MainScreen.productsList.Add(GoatMilk);
                MainScreen.instance.addListViewItem(GoatMilk);
            }
        }
        private void CowMilkButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 7.9;
                fat = 3;
                name = "Cow milk";
                price *= amnt;
                Milk CowMilk = new Milk(name, price, fat.ToString());
                MainScreen.productsList.Add(CowMilk);
                MainScreen.instance.addListViewItem(CowMilk);
            }
        }
        private void AlmondMilkButton_Click(object sender, EventArgs e)
        {
            amnt = MainScreen.instance.amountChoose();
            if (amnt != 0)
            {
                price = 14.9;
                fat = 1;
                name = "Almond milk";
                price *= amnt;
                Milk AlmondMilk = new Milk(name, price, fat.ToString());
                MainScreen.productsList.Add(AlmondMilk);
                MainScreen.instance.addListViewItem(AlmondMilk);
            }
        }
    }
}