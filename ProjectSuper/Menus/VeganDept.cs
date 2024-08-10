using System.Drawing;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class VeganDept : UserControl
    {
        public double price, amnt;
        public string frozenText, name, organic;
        public PictureBox temp;
        public static bool _isMoved = false;
        public Point tempLoc;

        public VeganDept()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"VeganWallpaper.png");
            setImages();
        }
        private void setImages()
        {
            //  Sets the images to the picture boxes
            Tomato.Image = Image.FromFile(@"Tomato.png");
            Cucumber.Image = Image.FromFile(@"Cucumber.png");
            Onion.Image = Image.FromFile(@"Onion.png");
            Watermelon.Image = Image.FromFile(@"Watermelon.png");
            Orange.Image = Image.FromFile(@"Orange.png");
            Lemon.Image = Image.FromFile(@"Lemon.png");
            Peas.Image = Image.FromFile(@"Peas.png");
            Spinach.Image = Image.FromFile(@"Spinach.png");
            Broccoli.Image = Image.FromFile(@"Broccoli.png");
        }
        private void TomatoButtonMove()
        {
            price = 8.9;
            name = "Tomato";
            organic = "Organic";
            Vegetables Tomato = new Vegetables(name, price, organic);
            MainScreen.productsList.Add(Tomato);
            MainScreen.instance.addListViewItem(Tomato);
        }
        private void CucumberButtonMove()
        {
            price = 9.9;
            name = "Cucumber";
            organic = "Organic";
            Vegetables Cucumber = new Vegetables(name, price, organic);
            MainScreen.productsList.Add(Cucumber);
            MainScreen.instance.addListViewItem(Cucumber);
        }
        private void OnionButtonMove()
        {
            price = 2.9;
            name = "Onion";
            organic = "Not organic";
            Vegetables Onion = new Vegetables(name, price, organic);
            MainScreen.productsList.Add(Onion);
            MainScreen.instance.addListViewItem(Onion);
        }
        private void WaterMelonButtonMove()
        {
            price = 9.9;
            name = "Watermelon";
            organic = "Not organic";
            Fruits Watermelon = new Fruits(name, price, organic);
            MainScreen.productsList.Add(Watermelon);
            MainScreen.instance.addListViewItem(Watermelon);
        }
        private void OrangeButtonmove()
        {
            price = 12.9;
            name = "Orange";
            organic = "Organic";
            Fruits Orange = new Fruits(name, price, organic);
            MainScreen.productsList.Add(Orange);
            MainScreen.instance.addListViewItem(Orange);
        }
        private void LemonButtonMove()
        {
            price = 14.9;
            name = "Lemon";
            organic = "Organic";
            Fruits Lemon = new Fruits(name, price, organic);
            MainScreen.productsList.Add(Lemon);
            MainScreen.instance.addListViewItem(Lemon);
        }
        private void PeaseButtonMove()
        {
            price = 13.9;    // price per 1 kg's
            name = "Pease";
            organic = "Not organic";
            Frozen pease = new Frozen(name, price, organic);
            MainScreen.productsList.Add(pease);
            MainScreen.instance.addListViewItem(pease);
        }
        private void SpinachButtonMove()
        {
            price = 19.9;    // price per 1 kg's
            name = "Spinach";
            organic = "Not organic";
            Frozen spinach = new Frozen(name, price, organic);
            MainScreen.productsList.Add(spinach);
            MainScreen.instance.addListViewItem(spinach);
        }
        private void BroccoliButtonMove()
        {
            price = 15.9;    // price per 1 kg's
            name = "Broccoli";
            organic = "Not organic";
            Frozen Pease = new Frozen(name, price, organic);
            MainScreen.productsList.Add(Pease);
            MainScreen.instance.addListViewItem(Pease);
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
                        TomatoButtonMove();
                    else if (temp.Tag.ToString().Equals("2"))
                        CucumberButtonMove();
                    else if (temp.Tag.ToString().Equals("3"))
                        OnionButtonMove();
                    else if (temp.Tag.ToString().Equals("4"))
                        WaterMelonButtonMove();
                    else if (temp.Tag.ToString().Equals("5"))
                        OrangeButtonmove();
                    else if (temp.Tag.ToString().Equals("6"))
                        LemonButtonMove();
                    else if (temp.Tag.ToString().Equals("7"))
                        PeaseButtonMove();
                    else if (temp.Tag.ToString().Equals("8"))
                        SpinachButtonMove();
                    else if (temp.Tag.ToString().Equals("9"))
                        BroccoliButtonMove();
                }
                temp.Location = tempLoc;
            }
        }
    }
}
