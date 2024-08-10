using System;
using System.Windows.Forms;
using System.Drawing;


namespace ProjectSuper
{
    public partial class BeefMenu : UserControl
    {
        public double price, amnt;
        public string beefText, name, cutType;

        public Button temp;
        public static bool _isMoved = false;
        public Point tempLoc;

        public BeefMenu()
        {
            InitializeComponent();
        }
        private void SteakButtonMove()
        {
            beefText = MainScreen.instance.WeightChoose();
            if (beefText != "Error")
            {
                price = 119.9;    // price per 1 kg's
                amnt = (double.Parse(beefText)) / 1000;    //weight in gram
                name = "Steak";
                cutType = "Fillet";
                price *= amnt;    //price per item by grams
                Beef steak = new Beef(name, price, cutType);
                MainScreen.productsList.Add(steak);
                MainScreen.instance.addListViewItem(steak);
            }
        }
        private void TBoneButtonMove() {
            beefText = MainScreen.instance.WeightChoose();
            if (beefText != "Error")
            {
                price = 149.9;    // price per 1 kg's
                amnt = (double.Parse(beefText)) / 1000;    //weight in gram
                name = "T-Bone";
                cutType = "Rib-Eye";
                price *= amnt;    //price per item by grams
                Beef TBone = new Beef(name, price, cutType);
                MainScreen.productsList.Add(TBone);
                MainScreen.instance.addListViewItem(TBone);
            }
        }
        private void RibsButtonMove() {
            beefText = MainScreen.instance.WeightChoose();
            if (beefText != "Error")
            {
                price = 169.9;    // price per 1 kg's
                amnt = (double.Parse(beefText)) / 1000;    //weight in gram
                name = "Ribs";
                cutType = "Ribs";
                price *= amnt;    //price per item by grams
                Beef Ribs = new Beef(name, price, cutType);
                MainScreen.productsList.Add(Ribs);
                MainScreen.instance.addListViewItem(Ribs);
            }
        }

        private void Generic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMoved = true;
                temp = (Button)sender;
                tempLoc = temp.Location;
                temp.BringToFront();
            }
        }
        private void Generic_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMoved)
            {
                Point currPos = PointToClient(Cursor.Position);
                temp.Location = new Point(currPos.X - temp.Width / 2, currPos.Y - temp.Height / 2);
            }
        }
        private void Generic_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMoved = false;
                if (temp.Location.X > 612)
                {
                    if (temp.Tag.ToString().Equals("1"))
                        SteakButtonMove();
                    else if (temp.Tag.ToString().Equals("2"))
                        TBoneButtonMove();
                    else if (temp.Tag.ToString().Equals("3"))
                        RibsButtonMove();
                }
                temp.Location = tempLoc;
            }
        }
    }
}