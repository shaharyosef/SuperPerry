
namespace ProjectSuper
{
    partial class FruitsMenu
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
            this.LemonButton = new System.Windows.Forms.Button();
            this.WaterMelonButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.LemonPrice = new System.Windows.Forms.Label();
            this.OrangePrice = new System.Windows.Forms.Label();
            this.WatermelonPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LemonButton
            // 
            this.LemonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LemonButton.Location = new System.Drawing.Point(412, 15);
            this.LemonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LemonButton.Name = "LemonButton";
            this.LemonButton.Size = new System.Drawing.Size(180, 170);
            this.LemonButton.TabIndex = 5;
            this.LemonButton.Text = "Lemon";
            this.LemonButton.UseVisualStyleBackColor = true;
            this.LemonButton.Click += new System.EventHandler(this.LemonButton_Click);
            // 
            // WaterMelonButton
            // 
            this.WaterMelonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WaterMelonButton.Location = new System.Drawing.Point(11, 15);
            this.WaterMelonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WaterMelonButton.Name = "WaterMelonButton";
            this.WaterMelonButton.Size = new System.Drawing.Size(180, 170);
            this.WaterMelonButton.TabIndex = 4;
            this.WaterMelonButton.Text = "Watermelon";
            this.WaterMelonButton.UseVisualStyleBackColor = true;
            this.WaterMelonButton.Click += new System.EventHandler(this.WaterMelonButton_Click);
            // 
            // OrangeButton
            // 
            this.OrangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.OrangeButton.Location = new System.Drawing.Point(211, 15);
            this.OrangeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(180, 170);
            this.OrangeButton.TabIndex = 3;
            this.OrangeButton.Text = "Orange";
            this.OrangeButton.UseVisualStyleBackColor = true;
            this.OrangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // LemonPrice
            // 
            this.LemonPrice.AutoSize = true;
            this.LemonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LemonPrice.Location = new System.Drawing.Point(407, 188);
            this.LemonPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LemonPrice.Name = "LemonPrice";
            this.LemonPrice.Size = new System.Drawing.Size(86, 22);
            this.LemonPrice.TabIndex = 54;
            this.LemonPrice.Text = "Price: 4.9";
            // 
            // OrangePrice
            // 
            this.OrangePrice.AutoSize = true;
            this.OrangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.OrangePrice.Location = new System.Drawing.Point(207, 188);
            this.OrangePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrangePrice.Name = "OrangePrice";
            this.OrangePrice.Size = new System.Drawing.Size(91, 22);
            this.OrangePrice.TabIndex = 53;
            this.OrangePrice.Text = "Price:  6.9";
            // 
            // WatermelonPrice
            // 
            this.WatermelonPrice.AutoSize = true;
            this.WatermelonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WatermelonPrice.Location = new System.Drawing.Point(7, 188);
            this.WatermelonPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WatermelonPrice.Name = "WatermelonPrice";
            this.WatermelonPrice.Size = new System.Drawing.Size(91, 22);
            this.WatermelonPrice.TabIndex = 52;
            this.WatermelonPrice.Text = "Price:  9.9";
            // 
            // FruitsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LemonPrice);
            this.Controls.Add(this.OrangePrice);
            this.Controls.Add(this.WatermelonPrice);
            this.Controls.Add(this.LemonButton);
            this.Controls.Add(this.WaterMelonButton);
            this.Controls.Add(this.OrangeButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FruitsMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button LemonButton;
        private System.Windows.Forms.Button WaterMelonButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Label LemonPrice;
        private System.Windows.Forms.Label OrangePrice;
        private System.Windows.Forms.Label WatermelonPrice;
    }
}