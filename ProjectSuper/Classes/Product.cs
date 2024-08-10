using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectSuper
{
    [Serializable]
    public class Product {
        public int _serialNum { get; set; }
        public double _price { get; set; }
        public double _amnt { get; set; }
        public string _name { get; set; }

        public Product(string name, double price)
        {
            this._name = name;
            this._amnt = QuantitySetForProduct();
            if (this._amnt > 0)
            {
                this._price = price * _amnt;
                MainScreen._totalPrice += this._price;
                MainScreen.instance.UpdateTotalPriceLabel();
                this._serialNum += MainScreen._serial++;
            }
        }
        public virtual string getQuantity()
        {
            return this._amnt.ToString();
        }
        public virtual string getSpecialVariable()
        {
            return "Nothing";
        }
        public virtual string amountChangeMsg()
        {
            var message = "Please pick a new amount from the list below:";

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Amount change";
            messageBox.Height = 200;
            messageBox.TopMost = true;

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.Width = 250;
            messageLabel.Location = new Point(30, 20);
            messageBox.Controls.Add(messageLabel);

            // Add a combo box to the message box
            var comboBox = new ComboBox();
            comboBox.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            comboBox.Location = new Point(30, 80);
            messageBox.Controls.Add(comboBox);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(200, 80);
            messageBox.Controls.Add(okButton);

            // Show the message box
            var result = messageBox.ShowDialog();

            if (comboBox.SelectedIndex >= 0 && result == DialogResult.OK)
            {
                return (comboBox.SelectedIndex + 1).ToString();
            }
            return "Error";
        }
        public virtual double QuantitySetForProduct()
        {
            var message = "Please pick an amount from the list below:";

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Amount choose";
            messageBox.Height = 200;
            messageBox.Width = 450;

            messageBox.TopMost = true;

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.Width = 450;
            messageLabel.Location = new Point(30, 20);
            messageBox.Controls.Add(messageLabel);

            // Add a combo box to the message box
            var comboBox = new ComboBox();
            comboBox.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            comboBox.Location = new Point(30, 80);
            messageBox.Controls.Add(comboBox);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(200, 80);
            messageBox.Controls.Add(okButton);

            // Show the message box
            var result = messageBox.ShowDialog();

            if (comboBox.SelectedIndex >= 0 && result == DialogResult.OK)
            {
                return comboBox.SelectedIndex + 1;
            }
            return -1;
        }
    }
}
