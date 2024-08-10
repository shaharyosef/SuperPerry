
namespace ProjectSuper
{
    partial class MilkMenu
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
            this.AlmondMilkButton = new System.Windows.Forms.Button();
            this.GoatMilkButton = new System.Windows.Forms.Button();
            this.CowMilkButton = new System.Windows.Forms.Button();
            this.AlmodPrice = new System.Windows.Forms.Label();
            this.CowPrice = new System.Windows.Forms.Label();
            this.GoatPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlmondMilkButton
            // 
            this.AlmondMilkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AlmondMilkButton.Location = new System.Drawing.Point(412, 15);
            this.AlmondMilkButton.Margin = new System.Windows.Forms.Padding(2);
            this.AlmondMilkButton.Name = "AlmondMilkButton";
            this.AlmondMilkButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AlmondMilkButton.Size = new System.Drawing.Size(180, 170);
            this.AlmondMilkButton.TabIndex = 5;
            this.AlmondMilkButton.Text = "Almond";
            this.AlmondMilkButton.UseVisualStyleBackColor = true;
            this.AlmondMilkButton.Click += new System.EventHandler(this.AlmondMilkButton_Click);
            // 
            // GoatMilkButton
            // 
            this.GoatMilkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GoatMilkButton.Location = new System.Drawing.Point(11, 15);
            this.GoatMilkButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoatMilkButton.Name = "GoatMilkButton";
            this.GoatMilkButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GoatMilkButton.Size = new System.Drawing.Size(180, 170);
            this.GoatMilkButton.TabIndex = 4;
            this.GoatMilkButton.Text = "Goat Milk";
            this.GoatMilkButton.UseVisualStyleBackColor = true;
            this.GoatMilkButton.Click += new System.EventHandler(this.GoatMilkButton_Click);
            // 
            // CowMilkButton
            // 
            this.CowMilkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CowMilkButton.Location = new System.Drawing.Point(211, 15);
            this.CowMilkButton.Margin = new System.Windows.Forms.Padding(2);
            this.CowMilkButton.Name = "CowMilkButton";
            this.CowMilkButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CowMilkButton.Size = new System.Drawing.Size(180, 170);
            this.CowMilkButton.TabIndex = 3;
            this.CowMilkButton.Text = "Cow Milk";
            this.CowMilkButton.UseVisualStyleBackColor = true;
            this.CowMilkButton.Click += new System.EventHandler(this.CowMilkButton_Click);
            // 
            // AlmodPrice
            // 
            this.AlmodPrice.AutoSize = true;
            this.AlmodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AlmodPrice.Location = new System.Drawing.Point(407, 188);
            this.AlmodPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlmodPrice.Name = "AlmodPrice";
            this.AlmodPrice.Size = new System.Drawing.Size(96, 22);
            this.AlmodPrice.TabIndex = 40;
            this.AlmodPrice.Text = "Price: 14.9";
            // 
            // CowPrice
            // 
            this.CowPrice.AutoSize = true;
            this.CowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CowPrice.Location = new System.Drawing.Point(207, 188);
            this.CowPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CowPrice.Name = "CowPrice";
            this.CowPrice.Size = new System.Drawing.Size(91, 22);
            this.CowPrice.TabIndex = 39;
            this.CowPrice.Text = "Price:  7.9";
            // 
            // GoatPrice
            // 
            this.GoatPrice.AutoSize = true;
            this.GoatPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GoatPrice.Location = new System.Drawing.Point(7, 188);
            this.GoatPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoatPrice.Name = "GoatPrice";
            this.GoatPrice.Size = new System.Drawing.Size(101, 22);
            this.GoatPrice.TabIndex = 38;
            this.GoatPrice.Text = "Price:  12.9";
            // 
            // MilkMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AlmodPrice);
            this.Controls.Add(this.CowPrice);
            this.Controls.Add(this.GoatPrice);
            this.Controls.Add(this.AlmondMilkButton);
            this.Controls.Add(this.GoatMilkButton);
            this.Controls.Add(this.CowMilkButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MilkMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button AlmondMilkButton;
        private System.Windows.Forms.Button GoatMilkButton;
        private System.Windows.Forms.Button CowMilkButton;
        private System.Windows.Forms.Label AlmodPrice;
        private System.Windows.Forms.Label CowPrice;
        private System.Windows.Forms.Label GoatPrice;
    }
}