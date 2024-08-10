using System;
using System.Windows.Forms;
using System.Drawing;


namespace ProjectSuper
{
    public partial class SoftDrinksMenu : UserControl
    {
        public double price, amnt;
        public string name, flavor;
        public struct amount
        {
            public int drinksAmount, drinkType;
        }
        public SoftDrinksMenu()
        {
            InitializeComponent();
        }
        private void CokeButton_Click(object sender, EventArgs e)
        {
            amount g = DrinkAmountChoose();
            switch (g.drinkType)
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
            if (g.drinksAmount != 0)
            {
                flavor = "Sweet";
                amnt = g.drinksAmount;
                price *= amnt;
                SoftDrink sprite = new SoftDrink(name, price, flavor);
                MainScreen.productsList.Add(sprite);
                MainScreen.instance.addListViewItem(sprite);
            }
        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            amount g = DrinkAmountChoose();
            switch (g.drinkType)
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
            if (g.drinksAmount != 0)
            {
                amnt = g.drinksAmount;
                flavor = "Diet";
                price *= amnt;
                SoftDrink sprite = new SoftDrink(name, price, flavor);
                MainScreen.productsList.Add(sprite);
                MainScreen.instance.addListViewItem(sprite);
            }
        }
        private void SpriteButton_Click(object sender, EventArgs e)
        {
            amount g = DrinkAmountChoose();
            switch (g.drinkType)
            {
                case 0:
                    price = 0;
                    name = "Error";
                    break;
                case 1:
                    price = 3.9;
                    name = "7 UP, 0.5L";
                    break;
                case 2:
                    price = 6.9;
                    name = "7 UP, 1.5L";
                    break;
                case 3:
                    price = 31.9;
                    name = "7 UP, 6 Pack";
                    break;
            }
            if (g.drinksAmount != 0)
            {
                amnt = g.drinksAmount;
                flavor = "Disgusting";
                price *= amnt;
                SoftDrink sprite = new SoftDrink(name, price, flavor);
                MainScreen.productsList.Add(sprite);
                MainScreen.instance.addListViewItem(sprite);
            }
        }
        public amount DrinkAmountChoose()
        {
            amount temp;
            temp.drinksAmount = 0;
            temp.drinkType = 0;

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Amount Choose";
            messageBox.Height = 250;
            messageBox.Width = 400;
            messageBox.TopMost = true;
            
            // Add a label to the message box
            var amntMsg = "Please pick the wanted amount from the list below:"; // The message to display
            var amntMessageLabel = new Label();
            amntMessageLabel.AutoSize = false;
            amntMessageLabel.Text = amntMsg;
            amntMessageLabel.Font = new Font("Arial", 12);
            amntMessageLabel.Width = 400; // Set the width to 400 pixels
            amntMessageLabel.Location = new Point(10, 20);
            messageBox.Controls.Add(amntMessageLabel);

            // Add a combo box to the message box
            var comboBox = new ComboBox();
            comboBox.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            comboBox.Location = new Point(30, 50);
            messageBox.Controls.Add(comboBox);

            // Add another label to the message box
            var typeMsg = "Please pick the wanted type:"; // The message to display
            var typeMessageLabel = new Label();
            typeMessageLabel.AutoSize = false;
            typeMessageLabel.Text = typeMsg;
            typeMessageLabel.Font = new Font("Arial", 12);
            typeMessageLabel.Width = 250; // Set the width to 250 pixels
            typeMessageLabel.Location = new Point(10, 80);
            messageBox.Controls.Add(typeMessageLabel);

            // Add radio buttons to the message box
            var radioButton1 = new RadioButton();
            radioButton1.Text = "0.5L Bottle";
            radioButton1.Location = new Point(30, 100);
            messageBox.Controls.Add(radioButton1);
            var radioButton2 = new RadioButton();
            radioButton2.Text = "1.5L Bottle";
            radioButton2.Location = new Point(30, 120);
            messageBox.Controls.Add(radioButton2);
            var radioButton3 = new RadioButton();
            radioButton3.Text = "Six pack";
            radioButton3.Location = new Point(30, 140);
            messageBox.Controls.Add(radioButton3);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(250, 160);
            messageBox.Controls.Add(okButton);
            okButton.Enabled = false;
            
            // Attach event handlers to radio buttons and combo box
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            // Function to check if both a radio button and combo box selection are made
            bool IsSelectionValid()
            {
                return (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) && comboBox.SelectedIndex >= 0;
            }

            // Event handler for radio button selection change
            void RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                okButton.Enabled = IsSelectionValid();
            }

            // Event handler for combo box selection change
            void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                okButton.Enabled = IsSelectionValid();
            }

            // Show the message box
            var result = messageBox.ShowDialog();

            if (result == DialogResult.OK && IsSelectionValid())
            {
                // Retrieve the selected values
                if (radioButton1.Checked)
                    temp.drinkType = 1; // 0.5L
                else if (radioButton2.Checked)
                    temp.drinkType = 2; // 1.5L
                else if (radioButton3.Checked)
                    temp.drinkType = 3; // Six pack

                temp.drinksAmount = comboBox.SelectedIndex + 1;
            }

            return temp;
        }
    }
}