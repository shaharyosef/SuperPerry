
namespace ProjectSuper
{
    partial class SoftDrinksMenu
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
            this.SpriteButton = new System.Windows.Forms.Button();
            this.CokeButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.SpritePrice = new System.Windows.Forms.Label();
            this.ZeroPrice = new System.Windows.Forms.Label();
            this.ColaPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpriteButton
            // 
            this.SpriteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SpriteButton.Location = new System.Drawing.Point(412, 15);
            this.SpriteButton.Margin = new System.Windows.Forms.Padding(2);
            this.SpriteButton.Name = "SpriteButton";
            this.SpriteButton.Size = new System.Drawing.Size(180, 170);
            this.SpriteButton.TabIndex = 5;
            this.SpriteButton.Text = "Sprite";
            this.SpriteButton.UseVisualStyleBackColor = true;
            this.SpriteButton.Click += new System.EventHandler(this.SpriteButton_Click);
            // 
            // CokeButton
            // 
            this.CokeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CokeButton.Location = new System.Drawing.Point(11, 15);
            this.CokeButton.Margin = new System.Windows.Forms.Padding(2);
            this.CokeButton.Name = "CokeButton";
            this.CokeButton.Size = new System.Drawing.Size(180, 170);
            this.CokeButton.TabIndex = 4;
            this.CokeButton.Text = "Coca Cola";
            this.CokeButton.UseVisualStyleBackColor = true;
            this.CokeButton.Click += new System.EventHandler(this.CokeButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ZeroButton.Location = new System.Drawing.Point(211, 15);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(2);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(180, 170);
            this.ZeroButton.TabIndex = 3;
            this.ZeroButton.Text = "Zero";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // SpritePrice
            // 
            this.SpritePrice.AutoSize = true;
            this.SpritePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SpritePrice.Location = new System.Drawing.Point(407, 188);
            this.SpritePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpritePrice.Name = "SpritePrice";
            this.SpritePrice.Size = new System.Drawing.Size(191, 66);
            this.SpritePrice.TabIndex = 51;
            this.SpritePrice.Text = "Price: 6.9        1.5L\r\nPrice: 3.9        0.5L\r\nPrice: 31.9        6 Pack";
            // 
            // ZeroPrice
            // 
            this.ZeroPrice.AutoSize = true;
            this.ZeroPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ZeroPrice.Location = new System.Drawing.Point(207, 188);
            this.ZeroPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ZeroPrice.Name = "ZeroPrice";
            this.ZeroPrice.Size = new System.Drawing.Size(191, 66);
            this.ZeroPrice.TabIndex = 50;
            this.ZeroPrice.Text = "Price: 7.7        1.5L\r\nPrice: 5.9        0.5L\r\nPrice: 39.9        6 Pack\r\n";
            // 
            // ColaPrice
            // 
            this.ColaPrice.AutoSize = true;
            this.ColaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ColaPrice.Location = new System.Drawing.Point(7, 188);
            this.ColaPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColaPrice.Name = "ColaPrice";
            this.ColaPrice.Size = new System.Drawing.Size(191, 66);
            this.ColaPrice.TabIndex = 49;
            this.ColaPrice.Text = "Price: 7.5        1.5L\r\nPrice: 5.9        0.5L\r\nPrice: 41.1        6 Pack\r\n";
            // 
            // SoftDrinksMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpritePrice);
            this.Controls.Add(this.ZeroPrice);
            this.Controls.Add(this.ColaPrice);
            this.Controls.Add(this.SpriteButton);
            this.Controls.Add(this.CokeButton);
            this.Controls.Add(this.ZeroButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SoftDrinksMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button SpriteButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Label SpritePrice;
        private System.Windows.Forms.Label ZeroPrice;
        private System.Windows.Forms.Label ColaPrice;
        protected internal System.Windows.Forms.Button CokeButton;
    }
}