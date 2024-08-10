using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using NAudio.Wave;


namespace ProjectSuper
{
    [Serializable]
    public partial class MainScreen : Form
    {
        public static List<Person> personList = new List<Person>();
        public static List<Product> productsList = new List<Product>();
        public static bool _askedForAdult = false;
        public static bool _isAdult = false;
        public static int _serial = 1;
        public static double _totalPrice = 0;
        public static bool _isMute = false;
        public static bool _change = false;
        public static int changeIndex = 0;
        public static bool _isLoaded = false;
        public static string _phoneLoaded = null;
        public const string saveByPersonPath = @"PersonsSaves.mdl";
        public static MainScreen instance;
        WaveOutEvent waveOut = new WaveOutEvent();
        AudioFileReader audioFile = new AudioFileReader(@"Dance.wav");
        public static MeatDept MeatScreen;
        public static DairyDept DairyScreen;
        public static VeganDept VeganScreen;
        public static DrinksDept DrinksScreen;

        public MainScreen()
        {
            InitializeComponent();
            instance = this;
            UpdateTotalPriceLabel();
            setWindows();
        }

        [Serializable]
        public struct Person
        {
            public List<Product> products;
            public bool asked, isadult;
            public int serial;
            public double totalPrice;
            public string phoneNum;
        }
        public void addListViewItem(Product product)
        {
            string name = product._name;
            string amount = product.getQuantity();  //  Poly
            double amnt = strToDouble(amount);
            //  Checks if amount is right
            if (amnt > 0)
            {
                string strPrice = product._price.ToString("0.00") + " ₪";
                string serial;
                //  Handle if user want to change item
                if (_change)
                {
                    ListViewItem item = listViewShow.FocusedItem;
                    serial = item.SubItems[3].Text;
                    string price = item.SubItems[1].Text;   //  Price
                    double currPrice = strToDouble(price);
                    _totalPrice -= currPrice;
                    _serial -= 1;
                }
                else
                {
                    // No change needed
                    serial = product._serialNum.ToString();
                }
                string special = product.getSpecialVariable();  //  Poly
                string[] listNames = { name, strPrice, amount, serial, special };
                var newItem = new ListViewItem(listNames);
                if (_change)
                {
                    //  Actually changing item
                    listViewShow.Items.RemoveAt(changeIndex);
                    listViewShow.Items.Insert(changeIndex, newItem);
                    _change = false;
                }
                else
                {
                    //  No change needed
                   instance.listViewShow.Items.Add(newItem);
                }
                makeKachingSound();
                UpdateTotalPriceLabel();
            }
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            //  Set sizes for the screen
            this.Width = 960;
            this.Height = 550;
            this.MaximumSize = this.MinimumSize = this.Size;

            //  Deserialize persons who already registered with carts
            if (File.Exists(saveByPersonPath))
            {
                FileInfo fileInfo = new FileInfo(saveByPersonPath);
                if (fileInfo.Length == 0)
                {
                    //Empty file
                    MessageBox.Show("The save file is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (FileStream fileStream = new FileStream(saveByPersonPath, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        personList = (List<Person>)binaryFormatter.Deserialize(fileStream);
                    }
                }
            }
            setImages();
            playSound();
        }
        private void setImages()
        {
            //  Sets the images to the picture boxes
            Mute.Image = Image.FromFile(@"unMute.png");
            Replace.Image = Image.FromFile(@"Replace.png");
            Delete.Image = Image.FromFile(@"Delete.png");
            Save.Image = Image.FromFile(@"Save.png");
            LoadBtn.Image = Image.FromFile(@"Load.png");
            Clear.Image = Image.FromFile(@"Clear.png");
            Payment.Image = Image.FromFile(@"Cart.png");
        }
        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private double strToDouble(string str)
        {
            //  Convert string to double number
            double currAmount;
            if (!double.TryParse(str, out currAmount))
            {
                int spaceIndex = str.IndexOf(" ");
                if (spaceIndex != -1)
                {
                    str = str.Substring(0, spaceIndex);
                    currAmount = double.Parse(str);
                }
            }
            return currAmount;
        }
        public void UpdateTotalPriceLabel()
        {
            TotPrice.Text = $"{MainScreen._totalPrice:F2} ₪";
        }
        public void makeKachingSound()
        {
            SoundPlayer kaching = new SoundPlayer(@"Kaching.wav");
            if (!_isMute)
            {
                try
                {
                    kaching.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while playing the sound: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    kaching.Dispose();
                }
            }
        }
        public void makeDeleteSound()
        {
            SoundPlayer Trash = new SoundPlayer(@"DeleteSound.wav");
            if (!_isMute)
            {
                try
                {
                    Trash.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while playing the sound: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Trash.Dispose();
                }
            }
        }
        private void playSound()
        {
            // Hook the PlaybackStopped event to implement looping
            waveOut.PlaybackStopped += (sender, args) =>
            {
                // Reset the position of the audio file to the beginning
                audioFile.Position = 0;
                // Start playing again
                waveOut.Play();
            };
            // Initial playback
            waveOut.Init(audioFile);
            audioFile.Volume = 0.3f;
            waveOut.Play();
        }
        public void clearCart()
        {
            //  Clears list and listView
            productsList.Clear();
            listViewShow.Items.Clear();
            //  Sets serial to 1 and price to 0
            _serial = 1;
            _totalPrice = 0;
            //  Sets bool dataMembers to false
            _isAdult = false;
            _askedForAdult = false;
            _isLoaded = false;
            //  Resets the phone from load button
            _phoneLoaded = null;
            UpdateTotalPriceLabel();
            makeDeleteSound();
            //  Reset window
            VeganScreen.Hide();
            MeatScreen.Hide();
            DairyScreen.Hide();
            DrinksScreen.Hide();
        }
        private bool AlcoholCheck()
        {
            string[] names = { "Pino Noir", "Cava", "Merlot", "Carta Blanca Rum", "Corona", "Black Label Scotch" };
            foreach (ListViewItem item in listViewShow.Items)
            {
                //  Checks for alcohol in cart
                string name = item.SubItems[0].Text;
                if (names.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }
        public DateTime ageMsg()
        {
            // Checks age of user in order to allow alcohol purchase
            var message = "Here there are few alocholic drinks,\nPlease enter your date of birth to confirm you are 18";
            var messageBox = new Form();
            messageBox.Text = "Adult 18+";
            messageBox.Size = new Size(450, 350);

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.Width = 380;
            messageLabel.Height = 80;
            messageLabel.Location = new Point(20, 20);
            messageBox.Controls.Add(messageLabel);

            // Add a month calendar to the message box
            var textBox = new MonthCalendar();
            textBox.Location = new Point(40, 100);
            textBox.MaxSelectionCount = 1;
            textBox.TodayDate = DateTime.Now; // Set the time for today
            messageBox.Controls.Add(textBox);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(300, 170);
            messageBox.Controls.Add(okButton);

            while (true)
            {
                // Show the message box until a valid date is chosen
                var result = messageBox.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var selectedDate = textBox.SelectionStart;

                    if (selectedDate > DateTime.Now)
                    {
                        MessageBox.Show("Can't choose a future day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    return selectedDate;
                }
                else
                {
                    return DateTime.Now; // Return today's date when the user closes the window without choosing a date
                }
            }
        }
        public bool adulthoodCheck(DateTime dateTime)
        {
            MainScreen._askedForAdult = true;
            DateTime today = DateTime.Today;

            int years = today.Year - dateTime.Year;
            if (years > 18) // Born before 2005
            {
                //  good to go
                return true;
            }
            // Born in 2005
            else if (years == 18)
            {
                // Born in this month on 2005
                if ((today.Month - dateTime.Month) == 0)
                {
                    //  Born today on 2005
                    if ((today.Day - dateTime.Day) == 0)
                    {
                        MessageBox.Show("Happy B-Day !", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.None);
                        return true;
                    }
                    else   // Month of 18, check if passed 18 or not
                        return today.Day > dateTime.Day;
                }
                else   // Year of 18 , check if passed 18 or not
                    return today.Month > dateTime.Month;
            }
            else
                return false;
        }
        public string getPhoneNumber(bool save)
        {
            string msg;
            //  Save is boolean to know if save or load
            //  true - save
            //  false - load
            if (save)
                msg = "In order to save specific cart\nPlease enter your phone number";
            else
                msg = "In order to load specific cart\nPlease enter your phone number";

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Phone number";
            messageBox.Size = new Size(350, 200);
            messageBox.DesktopLocation = new Point(500, 500);
            messageBox.Location = new Point(500, 500);

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = msg;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.Width = 380;
            messageLabel.Height = 80;
            messageLabel.Location = new Point(20, 20);
            messageBox.Controls.Add(messageLabel);

            // Add a text box to the message box
            var textBox = new TextBox();
            textBox.Location = new Point(50, 100);
            textBox.Width = 100;
            textBox.MaxLength = 10;
            messageBox.Controls.Add(textBox);

            // Define the event handler for textbox key press
            textBox.KeyPress += TextBox_KeyPress;
            void TextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(180, 100);
            messageBox.Controls.Add(okButton);

            var result = messageBox.ShowDialog();

            //  Check for israeli cellPhone number
            if (textBox.Text.Length == 10 && textBox.Text.Substring(0, 2) == "05")
            {
                return textBox.Text;
            }
            return "Error";
        }
        public Person newPerson(string phoneNum)
        {
            //  Creates new person with all the needed details, included cart
            Person newPerson;
            newPerson.isadult = _isAdult;
            newPerson.serial = _serial;
            newPerson.totalPrice = _totalPrice;
            newPerson.products = productsList;
            newPerson.asked = _askedForAdult;
            newPerson.phoneNum = phoneNum;
            return newPerson;
        }
        public int ChangeItem()
        {
            int what = 0;
            var message = "Please choose what you want to do:";

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Want To Change";
            messageBox.Height = 200;
            messageBox.Width = 350;
            messageBox.TopMost = true;

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.Font = new Font("Arial", 12);
            messageLabel.Width = 300;
            messageLabel.Location = new Point(30, 40);
            messageBox.Controls.Add(messageLabel);

            // Add radio buttons for change amount or item button to the message box
            var AmountButton = new RadioButton();
            AmountButton.Text = "Amount change";
            AmountButton.Location = new Point(50, 80);
            messageBox.Controls.Add(AmountButton);
            
            var ItemButton = new RadioButton();
            ItemButton.Text = "Item change";
            ItemButton.Location = new Point(190, 80);
            messageBox.Controls.Add(ItemButton);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(250, 120);
            messageBox.Controls.Add(okButton);
            okButton.Enabled = false;

            // Attach event handlers to radio buttons
            AmountButton.CheckedChanged += RadioButton_CheckedChanged;
            ItemButton.CheckedChanged += RadioButton_CheckedChanged;

            // Function to check if a radio button is checked
            bool IsSelectionValid()
            {
                return (AmountButton.Checked || ItemButton.Checked);
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
                if (AmountButton.Checked)
                {
                    what = 1;
                }
                else if (ItemButton.Checked)
                {
                    what = -1;
                    _change = true;
                }
            }
            return what;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            //  Empty list
            if (productsList.Count == 0 || listViewShow.Items.Count == 0)
            {
                MessageBox.Show("Your shopping cart is empty!\nThere is nothing to save..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //  Get phone number - true for save
                string phone = getPhoneNumber(true);
                //  If phone number isnt right
                if (phone == "Error")
                    MessageBox.Show("Your phone number is incorrect!\nCan't save cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //  Save information of current user by his phone number
                    //  Check if the person already exists
                    bool isExist = false;
                    string msg;
                    for (int i = 0; i < personList.Count; ++i)
                    {
                        if (personList[i].phoneNum == phone)
                        {
                            //  Found in the memory, updates person's properties
                            isExist = true;
                            Person p = newPerson(phone);
                            personList[i] = p;
                            msg = "Cart saved successfully for phone number: " + phone;
                            MessageBox.Show(msg, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (!isExist)
                    {
                        //  Not found, creates new person and add it to the list
                        personList.Add(newPerson(phone));
                        msg = "Welcome: " + phone + "\nCart Saved successfully";
                        MessageBox.Show(msg, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //  Serialize updated person list
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(saveByPersonPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        formatter.Serialize(stream, personList);
                    }
                }
            }
        }
        private void Load_Click(object sender, EventArgs e)
        {
            //  Get phone number - false for load
            string phone = getPhoneNumber(false);
            bool isFound = false;
            //  If phone number isnt right
            if (phone == "Error")
                MessageBox.Show("Your phone number is incorrect!\nCan't load any cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //  Clears cart
                this.clearCart();
                if (File.Exists(saveByPersonPath))
                {
                    FileInfo fileInfo = new FileInfo(saveByPersonPath);
                    if (fileInfo.Length == 0)
                    {
                        //  Empty file
                        MessageBox.Show("The save file is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //  Deserialize persons who already registered with carts
                        using (FileStream fileStream = new FileStream(saveByPersonPath, FileMode.Open))
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            personList = (List<Person>)binaryFormatter.Deserialize(fileStream);
                            //  Check if the person already exists
                            foreach (Person person in personList)
                            {
                                //  Search if the phone enterd alreaddt registered
                                if (person.phoneNum == phone)
                                {
                                    //  Found in the memory, extracts person's properties
                                    isFound = true;
                                    _isLoaded = true;
                                    _phoneLoaded = phone;
                                    _serial = person.serial;
                                    _askedForAdult = person.asked;
                                    _isAdult = person.isadult;
                                    _totalPrice = person.totalPrice;
                                    productsList = person.products;
                                    //  Extracts person's cart
                                    foreach (Product product in productsList)
                                    {
                                        addListViewItem(product);
                                    }
                                    // Update the label for new price with new amount
                                    UpdateTotalPriceLabel();
                                    break;
                                }
                            }
                            if (!isFound)
                            {
                                //  Person not found in memory
                                MessageBox.Show("Your phone number isnt saved!\nOpens new cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    //  There is no such file
                    MessageBox.Show("Save file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            clearCart();
        }
        private void Mute_Click(object sender, EventArgs e)
        {
            //  Change bool value
            _isMute = !_isMute;
            if (_isMute)
            {
                //  Mute and change image
                audioFile.Volume = 0;
                Mute.Image = Image.FromFile(@"Mute.png");
            }
            else
            {
                //  unMute and change image
                audioFile.Volume = 0.3f;
                Mute.Image = Image.FromFile(@"unMute.png");
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            // Iterate over each item in the ListView control
            foreach (ListViewItem item in listViewShow.Items)
            {
                // Check if the current item is selected
                if (item.Selected)
                {
                // Iterate over each Product object in the productsList collection
                    foreach (Product product in productsList)
                    {
                        // Compare the serial number of the selected item with the serial number of the current product
                        if (item.SubItems[3].Text.Equals(product._serialNum.ToString()))
                        {
                            //  Substruct the price of the item we delete
                            _totalPrice -= product._price;
                            makeDeleteSound();
                            //  Delete item
                            listViewShow.Items.Remove(item);
                            productsList.Remove(product);
                            //  Check for emptyness
                            if (listViewShow.Items.Count == 0)
                            {
                                //  If cart is empty, set price to zero
                                _totalPrice = 0;
                            }
                            UpdateTotalPriceLabel();
                            break;
                        }
                    }
                }
            }
        }
        private void Replace_Click(object sender, EventArgs e)
        {
            // Iterate over each item in the ListView control
            foreach (ListViewItem item in listViewShow.Items)
            {
                // Check if the current item is selected
                if (item.Selected)
                {
                    // Iterate over each Product object in the productsList collection
                    foreach (Product product in productsList)
                    {
                        // Compare the serial number of the selected item with the serial number of the current product
                        if (item.SubItems[3].Text.Equals(product._serialNum.ToString()))
                        {
                            switch (ChangeItem())
                            {
                                case 1:
                                    //  Gets new amount
                                    string newAmount = product.amountChangeMsg();
                                    if (newAmount != "Error")
                                    {
                                        //  Change amount
                                        string price = item.SubItems[1].Text;   //  Price
                                        double currPrice = strToDouble(price);
                                        _totalPrice -= currPrice;
                                        string str = item.SubItems[2].Text; //  Amount
                                        double currAmount = strToDouble(str);
                                        currPrice /= currAmount;    //  Price per unit

                                        item.SubItems[2].Text = newAmount;
                                        currAmount = strToDouble(newAmount);

                                        currPrice *= currAmount;    //  New price with new amount
                                        _totalPrice += currPrice;

                                        //  Updates new amount and price
                                        product._price = currPrice;
                                        product._amnt = currAmount;

                                        item.SubItems[1].Text = currPrice.ToString("0.00") + " ₪";
                                    }
                                    break;
                                case 0:
                                    break;
                                case -1:
                                    //  Change item
                                    changeIndex = item.Index;
                                    chagnechangechange();
                                    break;
                            }
                        }
                    }
                    // Update the label for new price with new amount
                    UpdateTotalPriceLabel();
                }
            }
        }
        public void chagnechangechange()
        {
            var message = "Please choose department from the list below :";

            // Create the message box
            var messageBox = new Form();
            messageBox.Text = "Amount choose";
            messageBox.Height = 150;
            messageBox.Width = 350;
            messageBox.TopMost = true;

            // Add a label to the message box
            var messageLabel = new Label();
            messageLabel.AutoSize = false;
            messageLabel.Text = message;
            messageLabel.Font = new Font("Arial", 14);
            messageLabel.Width = 350;
            messageLabel.Location = new Point(10, 10);
            messageBox.Controls.Add(messageLabel);

            // Add a combo box to the message box
            var comboBox = new ComboBox();
            comboBox.Items.AddRange(new object[] { "Meat", "Dairy", "Vegan", "Drinks" });
            comboBox.Location = new Point(30, 60);
            messageBox.Controls.Add(comboBox);

            // Add an OK button to the message box
            var okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(200, 56);
            messageBox.Controls.Add(okButton);

            // Show the message box
            var result = messageBox.ShowDialog();

            if (comboBox.SelectedIndex >= 0 && result == DialogResult.OK)
            {
                switch(comboBox.SelectedItem)
                {
                    case "Meat":
                        MeatScreen.Show();
                        DairyScreen.Hide();
                        VeganScreen.Hide();
                        DrinksScreen.Hide();
                        break;
                    case "Dairy":
                        DairyScreen.Show();
                        MeatScreen.Hide();
                        VeganScreen.Hide();
                        DrinksScreen.Hide();
                        break;
                    case "Vegan":
                        VeganScreen.Show();
                        MeatScreen.Hide();
                        DairyScreen.Hide();
                        DrinksScreen.Hide();
                        break;
                    case "Drinks":
                        DrinksScreen.Show();
                        MeatScreen.Hide();
                        DairyScreen.Hide();
                        VeganScreen.Hide();
                        break;
                }
            }
        }
        private void Payment_Click(object sender, EventArgs e)
        {
            string msg;
            bool flag;
            //  Empty list
            if (productsList.Count == 0 || listViewShow.Items.Count == 0)
            {
                msg = "Your shopping cart is empty!";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //  Not empty and have alcohol
            else if (AlcoholCheck())
            {
                //  Checking for is adult:
                //  Already checked earlier
                if (_askedForAdult)
                    if (_isAdult)
                    {
                        //  Adult
                        flag = true;
                    }
                    else
                    {
                        //  Under aged
                        flag = false;
                    }
                else
                {   //  In case we dont know yet
                    msg = "Your shopping cart has alcohol in it,\nAre you sure you over 18?";
                    MessageBox.Show(msg, "Are you under age?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    flag = adulthoodCheck(ageMsg());
                }
                if (flag)
                {
                    // We understood that user is adult
                    CreditCard creditCardForm = new CreditCard();
                    creditCardForm.ShowDialog();
                }
                else
                {
                    // Under aged
                    msg = "Sorry but your shopping cart has alcohol in it,\nPlease come again with your parents";
                    MessageBox.Show(msg, "Are you under age?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //  Irrelevant if user is under age or not
                CreditCard creditCardForm = new CreditCard();
                creditCardForm.ShowDialog();
            }
        }
        private void MeatButton_Click(object sender, EventArgs e)
        {
            //  Shows relevant form and hides others
            MeatScreen.BringToFront();
            MeatScreen.Size = ThrPanel.Size;
            MeatScreen.Show();
            DairyScreen.Hide();
            VeganScreen.Hide();
            DrinksScreen.Hide();
        }
        private void DairyButton_Click(object sender, EventArgs e)
        {
            //  Shows relevant form and hides others
            DairyScreen.BringToFront();
            DairyScreen.Size = ThrPanel.Size;
            DairyScreen.Show();
            MeatScreen.Hide();
            VeganScreen.Hide();
            DrinksScreen.Hide();
        }
        private void VeganButton_Click(object sender, EventArgs e)
        {
            //  Shows relevant form and hides others
            VeganScreen.BringToFront();
            VeganScreen.Size = ThrPanel.Size;
            VeganScreen.Show();
            MeatScreen.Hide();
            DairyScreen.Hide();
            DrinksScreen.Hide();
        }
        private void DrinksButton_Click(object sender, EventArgs e)
        {
            if (!_isAdult&&!_askedForAdult)
            {
                //  Need to ask for age
                _isAdult = adulthoodCheck(ageMsg());
            }

            if (!_isAdult)
            {
                //  Under aged
                MessageBox.Show("You are under aged,only soft drinks will be shown", "Under age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DrinksDept.instance.PinoNoir.Hide();
                DrinksDept.instance.PinoNoir.Hide();
                DrinksDept.instance.Cava.Hide();
                DrinksDept.instance.Merlot.Hide();
                DrinksDept.instance.Beer.Hide();
                DrinksDept.instance.Whiskey.Hide();
                DrinksDept.instance.Rum.Hide();
            }
            else
            {
                DrinksDept.instance.PinoNoir.Show();
                DrinksDept.instance.PinoNoir.Show();
                DrinksDept.instance.Cava.Show();
                DrinksDept.instance.Merlot.Show();
                DrinksDept.instance.Beer.Show();
                DrinksDept.instance.Whiskey.Show();
                DrinksDept.instance.Rum.Show();
            }
            
            //  Shows relevant form and hides others
            DrinksScreen.BringToFront();
            DrinksScreen.Size = ThrPanel.Size;
            DrinksScreen.Show();
            MeatScreen.Hide();
            DairyScreen.Hide();
            VeganScreen.Hide();
        }
        private void setWindows()
        {
            //  Creates the sub menus and hides them till use
            MeatScreen = new MeatDept();
            DairyScreen = new DairyDept();
            VeganScreen = new VeganDept();
            DrinksScreen = new DrinksDept();

            ThrPanel.Controls.Add(MeatScreen);
            ThrPanel.Controls.Add(DairyScreen);
            ThrPanel.Controls.Add(VeganScreen);
            ThrPanel.Controls.Add(DrinksScreen);

            MeatScreen.Hide();
            DairyScreen.Hide();
            VeganScreen.Hide();
            DrinksScreen.Hide();
        }
    }
}