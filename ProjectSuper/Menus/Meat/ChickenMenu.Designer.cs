
namespace ProjectSuper
{
    partial class ChickenMenu
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
            this.LegButton = new System.Windows.Forms.Button();
            this.WingsButton = new System.Windows.Forms.Button();
            this.BreastButton = new System.Windows.Forms.Button();
            this.RibsPrice = new System.Windows.Forms.Label();
            this.TBonePrice = new System.Windows.Forms.Label();
            this.WingsPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LegButton
            // 
            this.LegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LegButton.Location = new System.Drawing.Point(412, 15);
            this.LegButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LegButton.Name = "LegButton";
            this.LegButton.Size = new System.Drawing.Size(180, 170);
            this.LegButton.TabIndex = 5;
            this.LegButton.Text = "Leg";
            this.LegButton.UseVisualStyleBackColor = true;
            this.LegButton.Click += new System.EventHandler(this.LegButton_Click);
            // 
            // WingsButton
            // 
            this.WingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WingsButton.Location = new System.Drawing.Point(11, 15);
            this.WingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WingsButton.Name = "WingsButton";
            this.WingsButton.Size = new System.Drawing.Size(180, 170);
            this.WingsButton.TabIndex = 4;
            this.WingsButton.Text = "Wings";
            this.WingsButton.UseVisualStyleBackColor = true;
            this.WingsButton.Click += new System.EventHandler(this.WingsButton_Click);
            // 
            // BreastButton
            // 
            this.BreastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BreastButton.Location = new System.Drawing.Point(211, 15);
            this.BreastButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BreastButton.Name = "BreastButton";
            this.BreastButton.Size = new System.Drawing.Size(180, 170);
            this.BreastButton.TabIndex = 3;
            this.BreastButton.Text = "Breast";
            this.BreastButton.UseVisualStyleBackColor = true;
            this.BreastButton.Click += new System.EventHandler(this.BreastButton_Click);
            // 
            // RibsPrice
            // 
            this.RibsPrice.AutoSize = true;
            this.RibsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RibsPrice.Location = new System.Drawing.Point(407, 188);
            this.RibsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RibsPrice.Name = "RibsPrice";
            this.RibsPrice.Size = new System.Drawing.Size(174, 22);
            this.RibsPrice.TabIndex = 39;
            this.RibsPrice.Text = "Price per 1 Kg:  39.9";
            // 
            // TBonePrice
            // 
            this.TBonePrice.AutoSize = true;
            this.TBonePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TBonePrice.Location = new System.Drawing.Point(207, 188);
            this.TBonePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TBonePrice.Name = "TBonePrice";
            this.TBonePrice.Size = new System.Drawing.Size(174, 22);
            this.TBonePrice.TabIndex = 38;
            this.TBonePrice.Text = "Price per 1 Kg:  54.9";
            // 
            // WingsPrice
            // 
            this.WingsPrice.AutoSize = true;
            this.WingsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WingsPrice.Location = new System.Drawing.Point(7, 188);
            this.WingsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WingsPrice.Name = "WingsPrice";
            this.WingsPrice.Size = new System.Drawing.Size(174, 22);
            this.WingsPrice.TabIndex = 37;
            this.WingsPrice.Text = "Price per 1 Kg:  29.9";
            // 
            // ChickenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RibsPrice);
            this.Controls.Add(this.TBonePrice);
            this.Controls.Add(this.WingsPrice);
            this.Controls.Add(this.LegButton);
            this.Controls.Add(this.WingsButton);
            this.Controls.Add(this.BreastButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChickenMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button LegButton;
        private System.Windows.Forms.Button WingsButton;
        private System.Windows.Forms.Button BreastButton;
        private System.Windows.Forms.Label RibsPrice;
        private System.Windows.Forms.Label TBonePrice;
        private System.Windows.Forms.Label WingsPrice;
    }
}