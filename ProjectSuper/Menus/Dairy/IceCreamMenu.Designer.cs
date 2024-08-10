
namespace ProjectSuper
{
    partial class IceCreamMenu
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
            this.StrawberryButton = new System.Windows.Forms.Button();
            this.ChocolateButton = new System.Windows.Forms.Button();
            this.VanillaButton = new System.Windows.Forms.Button();
            this.StrawberryPrice = new System.Windows.Forms.Label();
            this.VanillaPrice = new System.Windows.Forms.Label();
            this.ChocoPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StrawberryButton
            // 
            this.StrawberryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.StrawberryButton.Location = new System.Drawing.Point(412, 15);
            this.StrawberryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StrawberryButton.Name = "StrawberryButton";
            this.StrawberryButton.Size = new System.Drawing.Size(180, 170);
            this.StrawberryButton.TabIndex = 5;
            this.StrawberryButton.Text = "Strawberry";
            this.StrawberryButton.UseVisualStyleBackColor = true;
            this.StrawberryButton.Click += new System.EventHandler(this.StrawberryButton_Click);
            // 
            // ChocolateButton
            // 
            this.ChocolateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ChocolateButton.Location = new System.Drawing.Point(11, 15);
            this.ChocolateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChocolateButton.Name = "ChocolateButton";
            this.ChocolateButton.Size = new System.Drawing.Size(180, 170);
            this.ChocolateButton.TabIndex = 4;
            this.ChocolateButton.Text = "Chocolate";
            this.ChocolateButton.UseVisualStyleBackColor = true;
            this.ChocolateButton.Click += new System.EventHandler(this.ChocolateButton_Click);
            // 
            // VanillaButton
            // 
            this.VanillaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VanillaButton.Location = new System.Drawing.Point(211, 15);
            this.VanillaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VanillaButton.Name = "VanillaButton";
            this.VanillaButton.Size = new System.Drawing.Size(180, 170);
            this.VanillaButton.TabIndex = 3;
            this.VanillaButton.Text = "Vanilla";
            this.VanillaButton.UseVisualStyleBackColor = true;
            this.VanillaButton.Click += new System.EventHandler(this.VanillaButton_Click);
            // 
            // StrawberryPrice
            // 
            this.StrawberryPrice.AutoSize = true;
            this.StrawberryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.StrawberryPrice.Location = new System.Drawing.Point(407, 188);
            this.StrawberryPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrawberryPrice.Name = "StrawberryPrice";
            this.StrawberryPrice.Size = new System.Drawing.Size(96, 22);
            this.StrawberryPrice.TabIndex = 37;
            this.StrawberryPrice.Text = "Price: 24.9";
            // 
            // VanillaPrice
            // 
            this.VanillaPrice.AutoSize = true;
            this.VanillaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VanillaPrice.Location = new System.Drawing.Point(207, 188);
            this.VanillaPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VanillaPrice.Name = "VanillaPrice";
            this.VanillaPrice.Size = new System.Drawing.Size(101, 22);
            this.VanillaPrice.TabIndex = 36;
            this.VanillaPrice.Text = "Price:  19.9";
            // 
            // ChocoPrice
            // 
            this.ChocoPrice.AutoSize = true;
            this.ChocoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ChocoPrice.Location = new System.Drawing.Point(7, 188);
            this.ChocoPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChocoPrice.Name = "ChocoPrice";
            this.ChocoPrice.Size = new System.Drawing.Size(101, 22);
            this.ChocoPrice.TabIndex = 35;
            this.ChocoPrice.Text = "Price:  22.9";
            // 
            // IceCreamMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StrawberryPrice);
            this.Controls.Add(this.VanillaPrice);
            this.Controls.Add(this.ChocoPrice);
            this.Controls.Add(this.StrawberryButton);
            this.Controls.Add(this.ChocolateButton);
            this.Controls.Add(this.VanillaButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IceCreamMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button StrawberryButton;
        private System.Windows.Forms.Button ChocolateButton;
        private System.Windows.Forms.Button VanillaButton;
        private System.Windows.Forms.Label StrawberryPrice;
        private System.Windows.Forms.Label VanillaPrice;
        private System.Windows.Forms.Label ChocoPrice;
    }
}