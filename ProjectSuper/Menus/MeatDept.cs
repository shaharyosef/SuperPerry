using System.Drawing;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class MeatDept : UserControl
    {
        public double price, amnt;
        public string text, name, cutType;
        public PictureBox temp;
        public static bool _isMoved = false;
        public Point tempLoc;

        public MeatDept()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"MeatWallpaper.png");
            setImages();
        }
        private void setImages()
        {
            //  Sets the images to the picture boxes
            Steak.Image = Image.FromFile(@"BeefSteak.png");
            BeefRibs.Image = Image.FromFile(@"BeefRibs.png");
            TBone.Image = Image.FromFile(@"BeefTBone.png");
            Shoulder.Image = Image.FromFile(@"LambShoulder.png");
            LambLeg.Image = Image.FromFile(@"LambLeg.png");
            LambRibs.Image = Image.FromFile(@"LambRibs.png");
            ChickenLeg.Image = Image.FromFile(@"ChickenLeg.png");
            ChickenBreast.Image = Image.FromFile(@"ChickenBreast.png");
            ChickenWings.Image = Image.FromFile(@"ChickenWings.png");
        }
        private void BeefSteakButtonMove()
        {
            price = 119.9;    // price per 1 kg's
            name = "Steak";
            cutType = "Fillet";
            Beef steak = new Beef(name, price, cutType);
            MainScreen.productsList.Add(steak);
            MainScreen.instance.addListViewItem(steak);
        }
        private void BeefTBoneButtonMove()
        {
            price = 149.9;    // price per 1 kg's
            name = "T-Bone";
            cutType = "Rib-Eye";
            Beef TBone = new Beef(name, price, cutType);
            MainScreen.productsList.Add(TBone);
            MainScreen.instance.addListViewItem(TBone);
        }
        private void BeefRibsButtonMove()
        {
            price = 169.9;    // price per 1 kg's
            name = "Ribs";
            cutType = "Ribs";
            Beef Ribs = new Beef(name, price, cutType);
            MainScreen.productsList.Add(Ribs);
            MainScreen.instance.addListViewItem(Ribs);
        }
        private void LambShoulderButtonMove()
        {
            price = 99.9;    // price per 1 kg's
            name = "Lamb shoulder";
            cutType = "Fillet";
            Lamb shoulder = new Lamb(name, price, cutType);
            MainScreen.productsList.Add(shoulder);
            MainScreen.instance.addListViewItem(shoulder);
        }
        private void LambRibsButtonMove()
        {
            price = 199.9;    // price per 1 kg's
            name = "Lamb ribs";
            cutType = "Ribs";
            Lamb ribs = new Lamb(name, price, cutType);
            MainScreen.productsList.Add(ribs);
            MainScreen.instance.addListViewItem(ribs);
        }
        private void LambLegButtonMove()
        {
            price = 139.9;    // price per 1 kg's
            name = "Lamb leg";
            cutType = "Fillet";
            Lamb leg = new Lamb(name, price, cutType);
            MainScreen.productsList.Add(leg);
            MainScreen.instance.addListViewItem(leg);
        }
        private void ChickenWingsButtonMove()
        {
            price = 29.9;    // price per 1 kg's
            name = "Chicken wings";
            cutType = "2 parts";
            Chicken wings = new Chicken(name, price, cutType);
            MainScreen.productsList.Add(wings);
            MainScreen.instance.addListViewItem(wings);
        }
        private void ChickenBreastButtonMove()
        {
            price = 54.9;    // price per 1 kg's
            name = "Chicken breast";
            cutType = "Fillet";
            Chicken breast = new Chicken(name, price, cutType);
            MainScreen.productsList.Add(breast);
            MainScreen.instance.addListViewItem(breast);
        }
        private void ChickenLegButtonMove()
        {
            price = 39.9;    // price per 1 kg's
            name = "Chicken leg";
            cutType = "1 part";
            Chicken leg = new Chicken(name, price, cutType);
            MainScreen.productsList.Add(leg);
            MainScreen.instance.addListViewItem(leg);
        }
        private void Generic_MouseDown(object sender, MouseEventArgs e)
        {
            //  Event handler when mouse button is being clicked
            if (e.Button == MouseButtons.Left)
            {
                _isMoved = true;
                temp = (PictureBox)sender;
                tempLoc = temp.Location;
                temp.BringToFront();
            }
        }
        private void Generic_MouseMove(object sender, MouseEventArgs e)
        {
            //  Event handler when mouse is moving
            if (_isMoved)
            {
                Point currPos = PointToClient(Cursor.Position);
                temp.Location = new Point(currPos.X - temp.Width / 2, currPos.Y - temp.Height / 2);
            }
        }
        private void Generic_MouseUp(object sender, MouseEventArgs e)
        {
            //  Event handler when mouse button released
            if (e.Button == MouseButtons.Left)
            {
                _isMoved = false;
                if (temp.Location.X > 612)
                {
                    if (temp.Tag.ToString().Equals("1"))
                        BeefSteakButtonMove();
                    else if (temp.Tag.ToString().Equals("2"))
                        BeefRibsButtonMove();
                    else if (temp.Tag.ToString().Equals("3"))
                        BeefTBoneButtonMove();
                    else if (temp.Tag.ToString().Equals("4"))
                        LambShoulderButtonMove();
                    else if (temp.Tag.ToString().Equals("5"))
                        LambRibsButtonMove();
                    else if (temp.Tag.ToString().Equals("6"))
                        LambLegButtonMove();
                    else if (temp.Tag.ToString().Equals("7"))
                        ChickenBreastButtonMove();
                    else if (temp.Tag.ToString().Equals("8"))
                        ChickenLegButtonMove();
                    else if (temp.Tag.ToString().Equals("9"))
                        ChickenWingsButtonMove();
                }
                temp.Location = tempLoc;
            }
        }
    }
}
