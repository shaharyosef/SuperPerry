using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectSuper
{
    [Serializable]
    class Milk : Dairy
    {
        //  Product:
        //      string name
        //      double price
        //      double amount
        //      int serialNum
        //  Dairy
        //      string fat

        public Milk(string name, double price, string fat) : base(name, price, fat)
        {
        }
        public override string getQuantity()
        {
            return this._amnt.ToString() + " L";
        }
        public override string amountChangeMsg()
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
                return (comboBox.SelectedIndex + 1).ToString() + " L";
            }
            return "Error";
        }
    }
}