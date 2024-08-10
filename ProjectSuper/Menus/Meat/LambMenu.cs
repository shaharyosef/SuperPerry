using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectSuper
{
    public partial class LambMenu : UserControl
    {
        public double price, amnt;
        public string lambText, name, cutType;

        public Button temp;
        public static bool _isMoved = false;
        public Point tempLoc;

        public LambMenu()
        {
            InitializeComponent();
        }
        private void ShoulderButtonMove()
        {
            lambText = MainScreen.instance.WeightChoose();
            if (lambText != "Error")
            {
                price = 99.9;    // price per 1 kg's
                amnt = (double.Parse(lambText)) / 1000;    //weight in gram
                name = "Lamb shoulder";
                cutType = "Fillet";
                price *= amnt;    //price per item by grams
                Lamb shoulder = new Lamb(name, price, cutType);
                MainScreen.productsList.Add(shoulder);
                MainScreen.instance.addListViewItem(shoulder);
            }
        }
        private void RibsButtonMove()
        {
            lambText = MainScreen.instance.WeightChoose();
            if (lambText != "Error")
            {
                price = 199.9;    // price per 1 kg's
                amnt = (double.Parse(lambText)) / 1000;    //weight in gram
                name = "Lamb ribs";
                cutType = "Ribs";
                price *= amnt;    //price per item by grams
                Lamb ribs = new Lamb(name, price, cutType);
                MainScreen.productsList.Add(ribs);
                MainScreen.instance.addListViewItem(ribs);
            }
        }
        private void LegButtonMove()
        {
            lambText = MainScreen.instance.WeightChoose();
            if (lambText != "Error")
            {
                price = 139.9;    // price per 1 kg's
                amnt = (double.Parse(lambText)) / 1000;    //weight in gram
                name = "Lamb leg";
                cutType = "Fillet";
                price *= amnt;    //price per item by grams
                Lamb leg = new Lamb(name, price, cutType);
                MainScreen.productsList.Add(leg);
                MainScreen.instance.addListViewItem(leg);
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
                        ShoulderButtonMove();
                    else if (temp.Tag.ToString().Equals("2"))
                        LegButtonMove();
                    else if (temp.Tag.ToString().Equals("3"))
                        RibsButtonMove();
                }
                temp.Location = tempLoc;
            }
        }
    }
}