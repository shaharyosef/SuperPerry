
namespace ProjectSuper
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MeatButton = new System.Windows.Forms.Button();
            this.DairyButton = new System.Windows.Forms.Button();
            this.VeganButton = new System.Windows.Forms.Button();
            this.DrinksButton = new System.Windows.Forms.Button();
            this.FirPanel = new System.Windows.Forms.Panel();
            this.Payment = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.PictureBox();
            this.Replace = new System.Windows.Forms.PictureBox();
            this.Mute = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.PictureBox();
            this.LoadBtn = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.PictureBox();
            this.ShoppingLabel = new System.Windows.Forms.PictureBox();
            this.TotPrice = new System.Windows.Forms.Label();
            this.listViewShow = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemAmnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassVariable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThrPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FirPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Replace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // MeatButton
            // 
            this.MeatButton.BackColor = System.Drawing.Color.Transparent;
            this.MeatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MeatButton.BackgroundImage")));
            this.MeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MeatButton.Location = new System.Drawing.Point(2, 4);
            this.MeatButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MeatButton.Name = "MeatButton";
            this.MeatButton.Size = new System.Drawing.Size(300, 231);
            this.MeatButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.MeatButton, "Meat Department");
            this.MeatButton.UseVisualStyleBackColor = false;
            this.MeatButton.Click += new System.EventHandler(this.MeatButton_Click);
            // 
            // DairyButton
            // 
            this.DairyButton.BackColor = System.Drawing.Color.Transparent;
            this.DairyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DairyButton.BackgroundImage")));
            this.DairyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DairyButton.Location = new System.Drawing.Point(304, 4);
            this.DairyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DairyButton.Name = "DairyButton";
            this.DairyButton.Size = new System.Drawing.Size(300, 231);
            this.DairyButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.DairyButton, "Dairy Department");
            this.DairyButton.UseVisualStyleBackColor = false;
            this.DairyButton.Click += new System.EventHandler(this.DairyButton_Click);
            // 
            // VeganButton
            // 
            this.VeganButton.BackColor = System.Drawing.Color.Transparent;
            this.VeganButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VeganButton.BackgroundImage")));
            this.VeganButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VeganButton.Location = new System.Drawing.Point(610, 4);
            this.VeganButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VeganButton.Name = "VeganButton";
            this.VeganButton.Size = new System.Drawing.Size(300, 231);
            this.VeganButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.VeganButton, "Vegan Department");
            this.VeganButton.UseVisualStyleBackColor = false;
            this.VeganButton.Click += new System.EventHandler(this.VeganButton_Click);
            // 
            // DrinksButton
            // 
            this.DrinksButton.BackColor = System.Drawing.Color.Transparent;
            this.DrinksButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrinksButton.BackgroundImage")));
            this.DrinksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DrinksButton.Location = new System.Drawing.Point(916, 4);
            this.DrinksButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrinksButton.Name = "DrinksButton";
            this.DrinksButton.Size = new System.Drawing.Size(300, 231);
            this.DrinksButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.DrinksButton, "Drinks Department");
            this.DrinksButton.UseVisualStyleBackColor = false;
            this.DrinksButton.Click += new System.EventHandler(this.DrinksButton_Click);
            // 
            // FirPanel
            // 
            this.FirPanel.BackColor = System.Drawing.Color.Transparent;
            this.FirPanel.Controls.Add(this.Payment);
            this.FirPanel.Controls.Add(this.Delete);
            this.FirPanel.Controls.Add(this.Replace);
            this.FirPanel.Controls.Add(this.Mute);
            this.FirPanel.Controls.Add(this.Clear);
            this.FirPanel.Controls.Add(this.LoadBtn);
            this.FirPanel.Controls.Add(this.Save);
            this.FirPanel.Controls.Add(this.ShoppingLabel);
            this.FirPanel.Controls.Add(this.TotPrice);
            this.FirPanel.Controls.Add(this.listViewShow);
            this.FirPanel.Location = new System.Drawing.Point(1220, 0);
            this.FirPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirPanel.Name = "FirPanel";
            this.FirPanel.Size = new System.Drawing.Size(900, 981);
            this.FirPanel.TabIndex = 6;
            // 
            // Payment
            // 
            this.Payment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Payment.BackgroundImage")));
            this.Payment.Location = new System.Drawing.Point(350, 885);
            this.Payment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(150, 96);
            this.Payment.TabIndex = 20;
            this.Payment.TabStop = false;
            this.toolTip1.SetToolTip(this.Payment, "Click here in order to proceed to checkout");
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.Location = new System.Drawing.Point(170, 885);
            this.Delete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(150, 96);
            this.Delete.TabIndex = 19;
            this.Delete.TabStop = false;
            this.toolTip1.SetToolTip(this.Delete, "Click here in order to remove item from the cart");
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Replace
            // 
            this.Replace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Replace.BackgroundImage")));
            this.Replace.Location = new System.Drawing.Point(0, 885);
            this.Replace.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(150, 96);
            this.Replace.TabIndex = 18;
            this.Replace.TabStop = false;
            this.toolTip1.SetToolTip(this.Replace, "Click here in order to change amount or product");
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // Mute
            // 
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.Location = new System.Drawing.Point(710, 10);
            this.Mute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(150, 96);
            this.Mute.TabIndex = 17;
            this.Mute.TabStop = false;
            this.toolTip1.SetToolTip(this.Mute, "Click here in order to mute or unmute sounds");
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Clear
            // 
            this.Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear.BackgroundImage")));
            this.Clear.Location = new System.Drawing.Point(550, 10);
            this.Clear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(150, 96);
            this.Clear.TabIndex = 16;
            this.Clear.TabStop = false;
            this.toolTip1.SetToolTip(this.Clear, "Click here in order to clear current cart");
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadBtn.BackgroundImage")));
            this.LoadBtn.Location = new System.Drawing.Point(390, 10);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(150, 96);
            this.LoadBtn.TabIndex = 15;
            this.LoadBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.LoadBtn, "Click here in order to load saved cart");
            this.LoadBtn.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.Location = new System.Drawing.Point(230, 10);
            this.Save.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 96);
            this.Save.TabIndex = 14;
            this.Save.TabStop = false;
            this.toolTip1.SetToolTip(this.Save, "Click here in order to save specific cart");
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ShoppingLabel
            // 
            this.ShoppingLabel.Image = ((System.Drawing.Image)(resources.GetObject("ShoppingLabel.Image")));
            this.ShoppingLabel.Location = new System.Drawing.Point(6, 10);
            this.ShoppingLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ShoppingLabel.Name = "ShoppingLabel";
            this.ShoppingLabel.Size = new System.Drawing.Size(200, 96);
            this.ShoppingLabel.TabIndex = 13;
            this.ShoppingLabel.TabStop = false;
            // 
            // TotPrice
            // 
            this.TotPrice.AutoSize = true;
            this.TotPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TotPrice.Location = new System.Drawing.Point(556, 887);
            this.TotPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotPrice.Name = "TotPrice";
            this.TotPrice.Size = new System.Drawing.Size(2, 65);
            this.TotPrice.TabIndex = 6;
            // 
            // listViewShow
            // 
            this.listViewShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewShow.BackgroundImage")));
            this.listViewShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemPrice,
            this.ItemAmnt,
            this.ItemSN,
            this.ClassVariable});
            this.listViewShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.listViewShow.FullRowSelect = true;
            this.listViewShow.HideSelection = false;
            this.listViewShow.Location = new System.Drawing.Point(0, 115);
            this.listViewShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewShow.MultiSelect = false;
            this.listViewShow.Name = "listViewShow";
            this.listViewShow.ShowItemToolTips = true;
            this.listViewShow.Size = new System.Drawing.Size(894, 766);
            this.listViewShow.TabIndex = 0;
            this.listViewShow.UseCompatibleStateImageBehavior = false;
            this.listViewShow.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 130;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Price";
            this.ItemPrice.Width = 80;
            // 
            // ItemAmnt
            // 
            this.ItemAmnt.Text = "Amnt";
            this.ItemAmnt.Width = 70;
            // 
            // ItemSN
            // 
            this.ItemSN.Text = "No.";
            this.ItemSN.Width = 40;
            // 
            // ClassVariable
            // 
            this.ClassVariable.Text = "Class";
            this.ClassVariable.Width = 130;
            // 
            // ThrPanel
            // 
            this.ThrPanel.BackColor = System.Drawing.Color.Transparent;
            this.ThrPanel.Location = new System.Drawing.Point(0, 240);
            this.ThrPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThrPanel.Name = "ThrPanel";
            this.ThrPanel.Size = new System.Drawing.Size(1220, 740);
            this.ThrPanel.TabIndex = 8;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2126, 983);
            this.Controls.Add(this.DrinksButton);
            this.Controls.Add(this.FirPanel);
            this.Controls.Add(this.VeganButton);
            this.Controls.Add(this.DairyButton);
            this.Controls.Add(this.MeatButton);
            this.Controls.Add(this.ThrPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainScreen";
            this.Text = "Super Perry, lowest prices!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.FirPanel.ResumeLayout(false);
            this.FirPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Replace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MeatButton;
        private System.Windows.Forms.Button DairyButton;
        private System.Windows.Forms.Button VeganButton;
        private System.Windows.Forms.Button DrinksButton;

        private System.Windows.Forms.Panel FirPanel;
        public System.Windows.Forms.Panel ThrPanel;
        public System.Windows.Forms.ListView listViewShow;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.ColumnHeader ItemAmnt;
        public System.Windows.Forms.ColumnHeader ItemSN;
        private System.Windows.Forms.Button CheckOut;
        public System.Windows.Forms.Label TotPrice;
        private System.Windows.Forms.ColumnHeader ClassVariable;
        private System.Windows.Forms.PictureBox ShoppingLabel;
        private System.Windows.Forms.PictureBox Save;
        private System.Windows.Forms.PictureBox LoadBtn;
        private System.Windows.Forms.PictureBox Mute;
        private System.Windows.Forms.PictureBox Clear;
        private System.Windows.Forms.PictureBox Delete;
        private System.Windows.Forms.PictureBox Replace;
        private System.Windows.Forms.PictureBox Payment;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

