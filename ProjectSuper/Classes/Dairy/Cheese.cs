using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectSuper
{
    [Serializable]
    public class Cheese : Dairy 
    {
        //  Product:
        //      string name
        //      double price
        //      double amount 
        //      int serialNum
        //  Dairy:
        //      string fat

        public Cheese(string name, double price, string fat) : base(name, price, fat)
        {
        }
        public override string getQuantity()
        {
            return this._amnt.ToString("0.00") + " Kg";
        }
        public override string amountChangeMsg()
        {
            var message = "Please enter a new amount in grams in the text box below:";

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Weight change";
            messageBox.Height = 200;
            messageBox.Width = 550;
            messageBox.TopMost = true;

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.Width = 500;
            messageLabel.Location = new Point(10, 40);
            messageBox.Controls.Add(messageLabel);

            // Add another label to the message box
            var gramLabel = new Label();
            gramLabel.AutoSize = false;
            gramLabel.Text = " g";
            gramLabel.Font = new Font("Arial", 14);
            gramLabel.Location = new Point(210, 100);
            gramLabel.Width = 50;
            messageBox.Controls.Add(gramLabel);

            // Add a text box to the messege box
            var textBox = new TextBox();
            textBox.Location = new Point(110, 100);
            messageBox.Controls.Add(textBox);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(280, 100);
            messageBox.Controls.Add(okButton);

            // Show the message box
            messageBox.ShowDialog();

            if (int.TryParse(textBox.Text, out int _))
            {
                double amnt = double.Parse(textBox.Text);
                if (amnt > 99)
                {
                    return (amnt / 1000).ToString() + " Kg";
                }
                else
                {
                    MessageBox.Show("Sorry, we can't sell under 100g!\nPlease try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return "Error";
        }
        public override double QuantitySetForProduct()
        {
            var message = "Please enter an amount in grams in the text box below:";

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Weight choose";
            messageBox.Height = 200;
            messageBox.Width = 500;
            messageBox.TopMost = true;

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.Width = 500;
            messageLabel.Location = new Point(10, 40);
            messageBox.Controls.Add(messageLabel);

            // Add another label to the message box
            var gramLabel = new Label();
            gramLabel.AutoSize = false;
            gramLabel.Text = " g";
            gramLabel.Font = new Font("Arial", 14);
            gramLabel.Location = new Point(210, 100);
            gramLabel.Width = 50;
            messageBox.Controls.Add(gramLabel);

            // Add a text box to the messege box
            var textBox = new TextBox();
            textBox.Location = new Point(110, 100);
            messageBox.Controls.Add(textBox);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(280, 100);
            messageBox.Controls.Add(okButton);

            // Show the message box
            messageBox.ShowDialog();

            if (int.TryParse(textBox.Text, out int _))
            {
                double amnt = double.Parse(textBox.Text);
                if (amnt > 99)
                {
                    return (amnt / 1000);
                }
                else
                {
                    MessageBox.Show("Sorry, we can't sell under 100g!\nPlease try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return -1;
        }
    }
}