using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ProjectSuper
{
    public partial class CreditCard : Form
    {
        public CreditCard()
        {
            InitializeComponent();
            //  Set amount label to the amount of current cart
            AmountLabel.Text = $"{MainScreen._totalPrice:F2} ₪";
            this.BackgroundImage = Image.FromFile(@"PaymentWallpaper.png");
            //  If the cart was loaded, sets phone number automatically
            if (MainScreen._isLoaded)
            {
                PhoneBox.Text = MainScreen._phoneLoaded;
                PhoneBox.Enabled = false;
            }
            setMaxLen();
            hideLabels();
        }
        private void setMaxLen()
        {
            //  Set max length of all text boxes
            CardBox.MaxLength = 18;
            CVVBox.MaxLength = 3;
            IDBox.MaxLength = 9;
            PhoneBox.MaxLength = 10;
        }
        private void hideLabels()
        {
            //  Default hiding all wrong labels
            WrongID.Visible = false;
            WrongPhone.Visible = false;
            WrongCard.Visible = false;
            WrongMail.Visible = false;
        }
        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            //  Event to check ID number
            CheckIdNumber(IDBox.Text, WrongID);
        }
        private void CheckIdNumber(string id, Label label)
        {
            //  Checks for leegal ID number
            id = id.Trim();
            //  ID is less than 9 numbers, or have characters in it
            if (id.Length > 9 || !int.TryParse(id, out _))
            {
                //  Show wrong label
                label.Visible = true;
                return;
            }

            //  ID check algorithm
            id = id.Length < 9 ? ("00000000" + id).Substring(id.Length) : id;
            var sum = 0;

            for (var i = 0; i < id.Length; i++)
            {
                var digit = int.Parse(id[i].ToString());
                var weight = (i % 2) + 1;
                var step = digit * weight;
                sum += step > 9 ? step - 9 : step;
            }

            if (sum % 10 == 0)
            {
                label.Visible = false;
            }
            else
            {
                label.Visible = true;
            }
        }
        private void CheckPhoneNumber(string num, Label label)
        {
            //  Checks for israeli cellPhone number
            if (num.Length < 2 || num[0] != '0' || num[1] != '5' || num.Length < 10)
            {
                label.Visible = true;
                return;
            }
            else
                label.Visible = false;
        }
        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            //  Event to check cellPhone number
            CheckPhoneNumber(PhoneBox.Text, WrongPhone);
        }
        private void CardBox_TextChanged(object sender, EventArgs e)
        {
            string text = CardBox.Text;
            //  Sets images
            Image visa, Master, Amex, Diners;
            visa = Image.FromFile(@"Visa.png");
            Master = Image.FromFile(@"Master.png");
            Amex = Image.FromFile(@"Amex.png");
            Diners = Image.FromFile(@"Diners.png");

            //  Is visa
            if (text.Length >= 4 && (text.Substring(0, 4) == "4580"))
            {
                CardBox.MaxLength = 16;
                cardPicture.Image = visa;
                WrongCard.Visible = false;
            }
            //  Is Mastercard
            else if (text.Length >= 2 && ((text.Substring(0, 2) == "51") ||
                (text.Substring(0, 2) == "52") || (text.Substring(0, 2) == "53") ||
                (text.Substring(0, 2) == "54") || (text.Substring(0, 2) == "55")))
            {
                CardBox.MaxLength = 16;
                cardPicture.Image = Master;
                WrongCard.Visible = false;
            }
            //  Is Diners
            else if (text.Length >= 2 && ((text.Substring(0, 2) == "30") ||
                (text.Substring(0, 2) == "36") || (text.Substring(0, 2) == "38")))
            {
                CardBox.MaxLength = 14;
                cardPicture.Image = Diners;
                WrongCard.Visible = false;
            }
            //  Is Amex
            else if (text.Length >= 2 && ((text.Substring(0, 2) == "37")
                || (text.Substring(0, 2) == "27")))
            {
                CardBox.MaxLength = 15;
                cardPicture.Image = Amex;
                WrongCard.Visible = false;
            }
            else
            {   
                //  Any other wrong number
                //  Clears the image
                cardPicture.Image = null; 
                if (text.Length > 8)
                    WrongCard.Visible = true;
            }
        }
        private void CardBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Event to allow user enter only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CVVBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Event to allow user enter only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void IDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Event to allow user enter only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Event to allow user enter only letters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Event to allow user enter only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Event to allow user enter only letters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PostalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Event to allow user enter only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CreditCard_Load(object sender, EventArgs e)
        {
            //  Sets window sizes
            this.Width = 1303;
            this.Height = 1038;
        }
        private bool emptyBoxes()
        {
            if (CardBox.TextLength > 0 && CVVBox.TextLength > 0 && IDBox.TextLength > 0
                && NameBox.TextLength > 0 && EmailBox.TextLength > 0 && PhoneBox.TextLength > 0
                && CityBox.TextLength > 0 && PostalBox.TextLength > 0 && Month.SelectedIndex >= 0
                && Year.SelectedIndex >= 0)
                return false;
            return true;
        }
        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            WrongMail.Visible = !IsValidEmail(EmailBox.Text);
        }
        private bool IsValidEmail(string email)
        {
            //  Check valisity to E-Mail
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
        private void payMsg()
        {
            var message = "Payment successful,\nYour order will arrive in 2-4 business days"; // The message to display
                                                                                              // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Payment successful";
            messageBox.Size = new Size(400, 200);

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Width = 380; // Set the width to 380 pixels
            messageLabel.Height = 50; // Set the height to 50 pixels
            messageLabel.Location = new Point(10, 40);
            messageBox.Controls.Add(messageLabel);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(165, 100);
            messageBox.Controls.Add(okButton);

            // Show the message box
            messageBox.ShowDialog();
        }
        private void pay_Click(object sender, EventArgs e)
        {
            string msg;
            bool isEmpty = emptyBoxes();
            if (!isEmpty)
            {
                payMsg();
                MainScreen.instance.clearCart();
                this.Close();
            }
            else
            {
                msg = "Not all of the fields are fully filled,\nOr theyr'e not filled correctly.";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 

 
