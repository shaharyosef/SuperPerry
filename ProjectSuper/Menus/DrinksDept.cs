using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class DrinksDept : UserControl
    {
        public double price, amnt;
        public string name, flavor;
        public static DrinksDept instance;
        public PictureBox temp;
        public static bool _isMoved = false;
        public Point tempLoc;

        public DrinksDept()
        {
            InitializeComponent();
            instance = this;
            this.BackgroundImage = Image.FromFile(@"DrinksWallpaper.png");
            setImages();
        }
        private void setImages()
        {
            //  Sets the images to the picture boxes
            PinoNoir.Image = Image.FromFile(@"PinoNoir.png");
            Cava.Image = Image.FromFile(@"Cava.png");
            Merlot.Image = Image.FromFile(@"Merlot.png");
            Beer.Image = Image.FromFile(@"Beer.png");
            Whiskey.Image = Image.FromFile(@"Whiskey.png");
            Rum.Image = Image.FromFile(@"Rum.png");
            Sprite.Image = Image.FromFile(@"Sprite.png");
            CokeZero.Image = Image.FromFile(@"CokeZero.png");
            Coke.Image = Image.FromFile(@"Coke.png");
        }
        private void CokeButtonMove()
        {
            switch (DrinkTypeChoose())
            {
                case 0:
                    price = 0;
                    name = "Error";
                    break;
                case 1:
                    price = 5.9;
                    name = "Coca cola, 0.5L";
                    break;
                case 2:
                    price = 7.5;
                    name = "Coca cola, 1.5L";
                    break;
                case 3:
                    price = 41.1;
                    name = "Coca cola, 6 Pack";
                    break;
            }
            flavor = "Sweet";
            SoftDrink sprite = new SoftDrink(name, price, flavor);
            MainScreen.productsList.Add(sprite);
            MainScreen.instance.addListViewItem(sprite);
        }
        private void ZeroButtonMove()
        {
            switch (DrinkTypeChoose())
            {
                case 0:
                    price = 0;
                    name = "Error";
                    break;
                case 1:
                    price = 5.9;
                    name = "Zero cola, 0.5L";
                    break;
                case 2:
                    price = 7.7;
                    name = "Zero cola, 1.5L";
                    break;
                case 3:
                    price = 39.9;
                    name = "Zero cola, 6 Pack";
                    break;
            }
            flavor = "Diet";
            SoftDrink sprite = new SoftDrink(name, price, flavor);
            MainScreen.productsList.Add(sprite);
            MainScreen.instance.addListViewItem(sprite);
        }
        private void SpriteButtonMove()
        {
            switch (DrinkTypeChoose())
            {
                case 0:
                    price = 0;
                    name = "Error";
                    break;
                case 1:
                    price = 3.9;
                    name = "Sprite, 0.5L";
                    break;
                case 2:
                    price = 6.9;
                    name = "Sprite, 1.5L";
                    break;
                case 3:
                    price = 31.9;
                    name = "Sprite, 6 Pack";
                    break;
            }
            flavor = "Disgusting";
            SoftDrink sprite = new SoftDrink(name, price, flavor);
            MainScreen.productsList.Add(sprite);
            MainScreen.instance.addListViewItem(sprite);
        }
        public int DrinkTypeChoose()
        {
            int temp = 0;

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Amount Choose";
            messageBox.Height = 150;
            messageBox.Width = 250;
            messageBox.TopMost = true;

            // Add label to the message box
            var typeMsg = "Please pick the wanted type:"; // The message to display
            var typeMessageLabel = new Label();
            typeMessageLabel.AutoSize = false;
            typeMessageLabel.Text = typeMsg;
            typeMessageLabel.Font = new Font("Arial", 12);
            typeMessageLabel.Width = 250;
            typeMessageLabel.Location = new Point(10, 10);
            messageBox.Controls.Add(typeMessageLabel);

            // Add radio buttons to the message box
            var radioButton1 = new RadioButton();
            radioButton1.Text = "0.5L Bottle";
            radioButton1.Location = new Point(30, 30);
            messageBox.Controls.Add(radioButton1);
            var radioButton2 = new RadioButton();
            radioButton2.Text = "1.5L Bottle";
            radioButton2.Location = new Point(30, 50);
            messageBox.Controls.Add(radioButton2);
            var radioButton3 = new RadioButton();
            radioButton3.Text = "Six pack";
            radioButton3.Location = new Point(30, 70);
            messageBox.Controls.Add(radioButton3);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(130, 50);
            messageBox.Controls.Add(okButton);
            okButton.Enabled = false;

            // Attach event handlers to radio buttons and combo box
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;

            // Function to check if a radio button selection is made
            bool IsSelectionValid()
            {
                return (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked);
            }

            // Event handler for radio button selection change
            void RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                okButton.Enabled = IsSelectionValid();
            }

            // Show the message box
            var result = messageBox.ShowDialog();

            if (result == DialogResult.OK && IsSelectionValid())
            {
                // Retrieve the selected values
                if (radioButton1.Checked)
                    temp = 1; // 0.5L
                else if (radioButton2.Checked)
                    temp = 2; // 1.5L
                else if (radioButton3.Checked)
                    temp = 3; // Six pack
            }

            return temp;
        }
        private void RumButtonMove()
        {
            price = 84.9;
            name = "Carta Blanca Rum";
            flavor = "Spicy";
            Alcoholic Rum = new Alcoholic(name, price, flavor);
            MainScreen.productsList.Add(Rum);
            MainScreen.instance.addListViewItem(Rum);
        }
        private void BeerButtonMove()
        {
            price = 9.9;
            name = "Corona";
            flavor = "Sweet and little bitter";
            Alcoholic Beer = new Alcoholic(name, price, flavor);
            MainScreen.productsList.Add(Beer);
            MainScreen.instance.addListViewItem(Beer);
        }
        private void WhiskeyButtonMove()
        {
            price = 134.9;
            name = "Black Label Scotch";
            flavor = "Bitter";
            Alcoholic Whiskey = new Alcoholic(name, price, flavor);
            MainScreen.productsList.Add(Whiskey);
            MainScreen.instance.addListViewItem(Whiskey);
        }
        private void PinoButtonMove()
        {
            price = 54.9;
            name = "Pino Noir";
            flavor = "Sweet";
            Wine Pino = new Wine(name, price, flavor);
            MainScreen.productsList.Add(Pino);
            MainScreen.instance.addListViewItem(Pino);
        }
        private void CavaButtonMove()
        {
            price = 42.9;
            name = "Cava";
            flavor = "Very sweet";
            Wine Cava = new Wine(name, price, flavor);
            MainScreen.productsList.Add(Cava);
            MainScreen.instance.addListViewItem(Cava);
        }
        private void MerlotButtonMove()
        {
            price = 39.9;
            name = "Merlot";
            flavor = "Bitter";
            Wine Merlot = new Wine(name, price, flavor);
            MainScreen.productsList.Add(Merlot);
            MainScreen.instance.addListViewItem(Merlot);
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
                string[] alcoholic= { "1", "2", "3", "4", "5", "6" };
                if (temp.Location.X > 612)
                {
                        if (temp.Tag.ToString().Equals("1"))
                        PinoButtonMove();
                    else if (temp.Tag.ToString().Equals("2"))
                        CavaButtonMove();
                    else if (temp.Tag.ToString().Equals("3"))
                        MerlotButtonMove();
                    else if (temp.Tag.ToString().Equals("4"))
                        BeerButtonMove();
                    else if (temp.Tag.ToString().Equals("5"))
                        RumButtonMove();
                    else if (temp.Tag.ToString().Equals("6"))
                        WhiskeyButtonMove();
                    else if (temp.Tag.ToString().Equals("7"))
                        SpriteButtonMove();
                    else if (temp.Tag.ToString().Equals("8"))
                        ZeroButtonMove();
                    else if (temp.Tag.ToString().Equals("9"))
                        CokeButtonMove();
                }
                temp.Location = tempLoc;
            }
        }
    }
}
