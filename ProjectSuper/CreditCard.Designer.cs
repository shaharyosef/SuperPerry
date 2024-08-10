
namespace ProjectSuper
{
    partial class CreditCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCard));
            this.CardBox = new System.Windows.Forms.TextBox();
            this.CardNumber = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerName = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Postal = new System.Windows.Forms.Label();
            this.AmntTxt = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CVVBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PostalBox = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.WrongID = new System.Windows.Forms.Label();
            this.WrongPhone = new System.Windows.Forms.Label();
            this.WrongCard = new System.Windows.Forms.Label();
            this.cardPicture = new System.Windows.Forms.PictureBox();
            this.WrongMail = new System.Windows.Forms.Label();
            this.Pay = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardBox
            // 
            this.CardBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CardBox.Location = new System.Drawing.Point(44, 146);
            this.CardBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardBox.Name = "CardBox";
            this.CardBox.Size = new System.Drawing.Size(454, 38);
            this.CardBox.TabIndex = 1;
            this.CardBox.TextChanged += new System.EventHandler(this.CardBox_TextChanged);
            this.CardBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardBox_KeyPress);
            // 
            // CardNumber
            // 
            this.CardNumber.AutoSize = true;
            this.CardNumber.BackColor = System.Drawing.Color.Transparent;
            this.CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CardNumber.Location = new System.Drawing.Point(44, 77);
            this.CardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(454, 53);
            this.CardNumber.TabIndex = 7;
            this.CardNumber.Text = "Credit card number : ";
            // 
            // cvv
            // 
            this.cvv.AutoSize = true;
            this.cvv.BackColor = System.Drawing.Color.Transparent;
            this.cvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cvv.Location = new System.Drawing.Point(44, 227);
            this.cvv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(143, 53);
            this.cvv.TabIndex = 8;
            this.cvv.Text = "CVV :";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.id.Location = new System.Drawing.Point(44, 377);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(94, 53);
            this.id.TabIndex = 9;
            this.id.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(44, 527);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 53);
            this.label2.TabIndex = 10;
            this.label2.Text = "Expired date :";
            // 
            // ownerName
            // 
            this.ownerName.AutoSize = true;
            this.ownerName.BackColor = System.Drawing.Color.Transparent;
            this.ownerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ownerName.Location = new System.Drawing.Point(44, 677);
            this.ownerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(465, 53);
            this.ownerName.TabIndex = 11;
            this.ownerName.Text = "Name of card holder :";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.BackColor = System.Drawing.Color.Transparent;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.City.Location = new System.Drawing.Point(676, 377);
            this.City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(127, 53);
            this.City.TabIndex = 13;
            this.City.Text = "City :";
            // 
            // Postal
            // 
            this.Postal.AutoSize = true;
            this.Postal.BackColor = System.Drawing.Color.Transparent;
            this.Postal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Postal.Location = new System.Drawing.Point(676, 527);
            this.Postal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Postal.Name = "Postal";
            this.Postal.Size = new System.Drawing.Size(290, 53);
            this.Postal.TabIndex = 14;
            this.Postal.Text = "Postal code :";
            // 
            // AmntTxt
            // 
            this.AmntTxt.AutoSize = true;
            this.AmntTxt.BackColor = System.Drawing.Color.Transparent;
            this.AmntTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AmntTxt.Location = new System.Drawing.Point(676, 677);
            this.AmntTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmntTxt.Name = "AmntTxt";
            this.AmntTxt.Size = new System.Drawing.Size(341, 44);
            this.AmntTxt.TabIndex = 15;
            this.AmntTxt.Text = "Amount to charge :";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.BackColor = System.Drawing.Color.Transparent;
            this.Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Mail.Location = new System.Drawing.Point(676, 77);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(163, 53);
            this.Mail.TabIndex = 16;
            this.Mail.Text = "Email :";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Phone.Location = new System.Drawing.Point(676, 227);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(352, 53);
            this.Phone.TabIndex = 17;
            this.Phone.Text = "Phone number :";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AmountLabel.Location = new System.Drawing.Point(1028, 677);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(160, 48);
            this.AmountLabel.TabIndex = 18;
            this.AmountLabel.Text = "Amount";
            // 
            // CVVBox
            // 
            this.CVVBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CVVBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CVVBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CVVBox.Location = new System.Drawing.Point(44, 296);
            this.CVVBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVVBox.Name = "CVVBox";
            this.CVVBox.Size = new System.Drawing.Size(454, 38);
            this.CVVBox.TabIndex = 2;
            this.CVVBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CVVBox_KeyPress);
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IDBox.Location = new System.Drawing.Point(44, 446);
            this.IDBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(454, 38);
            this.IDBox.TabIndex = 3;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            this.IDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDBox_KeyPress);
            // 
            // CityBox
            // 
            this.CityBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CityBox.Location = new System.Drawing.Point(676, 446);
            this.CityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(454, 38);
            this.CityBox.TabIndex = 9;
            this.CityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityBox_KeyPress);
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PhoneBox.Location = new System.Drawing.Point(676, 296);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(454, 38);
            this.PhoneBox.TabIndex = 8;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.EmailBox.Location = new System.Drawing.Point(676, 146);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(454, 38);
            this.EmailBox.TabIndex = 7;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NameBox.Location = new System.Drawing.Point(44, 746);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(454, 38);
            this.NameBox.TabIndex = 6;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // PostalBox
            // 
            this.PostalBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PostalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PostalBox.Location = new System.Drawing.Point(676, 596);
            this.PostalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostalBox.Name = "PostalBox";
            this.PostalBox.Size = new System.Drawing.Size(454, 38);
            this.PostalBox.TabIndex = 10;
            this.PostalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostalBox_KeyPress);
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Month.Location = new System.Drawing.Point(44, 596);
            this.Month.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(150, 39);
            this.Month.TabIndex = 4;
            this.Month.Text = "Month";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.Year.Location = new System.Drawing.Point(250, 596);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(150, 39);
            this.Year.TabIndex = 5;
            this.Year.Text = "Year";
            // 
            // WrongID
            // 
            this.WrongID.AutoSize = true;
            this.WrongID.BackColor = System.Drawing.Color.Transparent;
            this.WrongID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WrongID.ForeColor = System.Drawing.Color.Red;
            this.WrongID.Location = new System.Drawing.Point(48, 496);
            this.WrongID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WrongID.Name = "WrongID";
            this.WrongID.Size = new System.Drawing.Size(335, 29);
            this.WrongID.TabIndex = 28;
            this.WrongID.Text = "You have entered a wrong ID !";
            // 
            // WrongPhone
            // 
            this.WrongPhone.AutoSize = true;
            this.WrongPhone.BackColor = System.Drawing.Color.Transparent;
            this.WrongPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WrongPhone.ForeColor = System.Drawing.Color.Red;
            this.WrongPhone.Location = new System.Drawing.Point(670, 346);
            this.WrongPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WrongPhone.Name = "WrongPhone";
            this.WrongPhone.Size = new System.Drawing.Size(258, 29);
            this.WrongPhone.TabIndex = 29;
            this.WrongPhone.Text = "Wrong phone number !";
            // 
            // WrongCard
            // 
            this.WrongCard.AutoSize = true;
            this.WrongCard.BackColor = System.Drawing.Color.Transparent;
            this.WrongCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WrongCard.ForeColor = System.Drawing.Color.Red;
            this.WrongCard.Location = new System.Drawing.Point(48, 196);
            this.WrongCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WrongCard.Name = "WrongCard";
            this.WrongCard.Size = new System.Drawing.Size(215, 29);
            this.WrongCard.TabIndex = 31;
            this.WrongCard.Text = "Wrong credit card !";
            // 
            // cardPicture
            // 
            this.cardPicture.Location = new System.Drawing.Point(504, 146);
            this.cardPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardPicture.Name = "cardPicture";
            this.cardPicture.Size = new System.Drawing.Size(100, 50);
            this.cardPicture.TabIndex = 30;
            this.cardPicture.TabStop = false;
            // 
            // WrongMail
            // 
            this.WrongMail.AutoSize = true;
            this.WrongMail.BackColor = System.Drawing.Color.Transparent;
            this.WrongMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WrongMail.ForeColor = System.Drawing.Color.Red;
            this.WrongMail.Location = new System.Drawing.Point(670, 196);
            this.WrongMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WrongMail.Name = "WrongMail";
            this.WrongMail.Size = new System.Drawing.Size(240, 29);
            this.WrongMail.TabIndex = 32;
            this.WrongMail.Text = "Wrong mail address !";
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.Transparent;
            this.Pay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pay.BackgroundImage")));
            this.Pay.Location = new System.Drawing.Point(764, 821);
            this.Pay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(150, 96);
            this.Pay.TabIndex = 33;
            this.Pay.TabStop = false;
            this.Pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 821);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 96);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1258, 908);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.WrongMail);
            this.Controls.Add(this.WrongCard);
            this.Controls.Add(this.cardPicture);
            this.Controls.Add(this.WrongPhone);
            this.Controls.Add(this.WrongID);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.PostalBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CVVBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.AmntTxt);
            this.Controls.Add(this.Postal);
            this.Controls.Add(this.City);
            this.Controls.Add(this.ownerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.CardBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1284, 979);
            this.MinimumSize = new System.Drawing.Size(1284, 792);
            this.Name = "CreditCard";
            this.Text = "CreditCard";
            this.Load += new System.EventHandler(this.CreditCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CardBox;
        private System.Windows.Forms.Label CardNumber;
        private System.Windows.Forms.Label cvv;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ownerName;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Postal;
        private System.Windows.Forms.Label AmntTxt;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox CVVBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PostalBox;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.Label WrongID;
        private System.Windows.Forms.Label WrongPhone;
        private System.Windows.Forms.PictureBox cardPicture;
        private System.Windows.Forms.Label WrongCard;
        private System.Windows.Forms.Label WrongMail;
        private System.Windows.Forms.PictureBox Pay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}