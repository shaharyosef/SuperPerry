using System.Drawing;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class DairyDept : UserControl
    {
        public double price, amnt;
        public string text, name;
        public int fat;
        public PictureBox temp;
        public static bool _isMoved = false;
        public Point tempLoc;

        public DairyDept()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"DairyWallpaper.png");
            setImages();
        }
        private void setImages()
        {
            //  Sets the images to the picture boxes
            GoatMilk.Image = Image.FromFile(@"GoatMilk.png");
            CowMilk.Image = Image.FromFile(@"CowMilk.png");
            AlmondMilk.Image = Image.FromFile(@"AlmondMilk.png");
            Chocolate.Image = Image.FromFile(@"Chocolate.png");
            Vanilla.Image = Image.FromFile(@"Vanilla.png");
            Strawberry.Image = Image.FromFile(@"Strawberry.png");
            Cheddar.Image = Image.FromFile(@"CheddarCheese.png");
            Gouda.Image = Image.FromFile(@"GoudaCheese.png");
            GoatCheese.Image = Image.FromFile(@"GoatCheese.png");
        }
        private void GoatMilkButtonMove()
        {
            price = 12.9;
            fat = 5;
            name = "Goat milk";
            Milk GoatMilk = new Milk(name, price, fat.ToString());
            MainScreen.productsList.Add(GoatMilk);
            MainScreen.instance.addListViewItem(GoatMilk);
        }
        private void CowMilkButtonMove()
        {
            price = 7.9;
            fat = 3;
            name = "Cow milk";
            Milk CowMilk = new Milk(name, price, fat.ToString());
            MainScreen.productsList.Add(CowMilk);
            MainScreen.instance.addListViewItem(CowMilk);

        }
        private void AlmondMilkButtonMove()
        {
            price = 14.9;
            fat = 1;
            name = "Almond milk";
            Milk AlmondMilk = new Milk(name, price, fat.ToString());
            MainScreen.productsList.Add(AlmondMilk);
            MainScreen.instance.addListViewItem(AlmondMilk);

        }
        private void ChocolateButtonMove()
        {
            price = 22.9;
            fat = 10;
            name = "Chocolate";
            IceCream chocolate = new IceCream(name, price, fat.ToString());
            MainScreen.productsList.Add(chocolate);
            MainScreen.instance.addListViewItem(chocolate);

        }
        private void VanillaButtonMove()
        {
            price = 19.9;
            fat = 17;
            name = "Vanilla";
            IceCream Vanilla = new IceCream(name, price, fat.ToString());
            MainScreen.productsList.Add(Vanilla);
            MainScreen.instance.addListViewItem(Vanilla);

        }
        private void StrawberryButtonMove()
        {
            price = 24.9;
            fat = 4;
            name = "Strawberry";
            IceCream Strawberry = new IceCream(name, price, fat.ToString());
            MainScreen.productsList.Add(Strawberry);
            MainScreen.instance.addListViewItem(Strawberry);
        }
        private void CheddarButtonMove()
        {
            price = 114.9;    // price per 1 kg's
            fat = 3;
            name = "Cheddar";
            Cheese Cheddar = new Cheese(name, price, fat.ToString());
            MainScreen.productsList.Add(Cheddar);
            MainScreen.instance.addListViewItem(Cheddar);
        }
        private void GoudaButtonMove()
        {
            price = 129.9;    // price per 1 kg's
            fat = 28;
            name = "Gouda";
            Cheese Gouda = new Cheese(name, price, fat.ToString());
            MainScreen.productsList.Add(Gouda);
            MainScreen.instance.addListViewItem(Gouda);
        }
        private void GoatButtonMove()
        {
            price = 119.9;    // price per 1 kg's
            fat = 25;
            name = "Goat Cheese";
            Cheese GoatCheese = new Cheese(name, price, fat.ToString());
            MainScreen.productsList.Add(GoatCheese);
            MainScreen.instance.addListViewItem(GoatCheese);
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
                        GoatMilkButtonMove();
                    else if (temp.Tag.ToString().Equals("2"))
                        CowMilkButtonMove();
                    else if (temp.Tag.ToString().Equals("3"))
                        AlmondMilkButtonMove();
                    else if (temp.Tag.ToString().Equals("4"))
                        ChocolateButtonMove();
                    else if (temp.Tag.ToString().Equals("5"))
                        VanillaButtonMove();
                    else if (temp.Tag.ToString().Equals("6"))
                        StrawberryButtonMove();
                    else if (temp.Tag.ToString().Equals("7"))
                        CheddarButtonMove();
                    else if (temp.Tag.ToString().Equals("8"))
                        GoudaButtonMove();
                    else if (temp.Tag.ToString().Equals("9"))
                        GoatButtonMove();
                }
                temp.Location = tempLoc;
            }
        }
    }
}
