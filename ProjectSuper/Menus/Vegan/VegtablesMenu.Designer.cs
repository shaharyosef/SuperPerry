
namespace ProjectSuper
{
    partial class VegtablesMenu
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
            this.OnionButton = new System.Windows.Forms.Button();
            this.TomatoButton = new System.Windows.Forms.Button();
            this.CucumberButton = new System.Windows.Forms.Button();
            this.LemonPrice = new System.Windows.Forms.Label();
            this.OrangePrice = new System.Windows.Forms.Label();
            this.WatermelonPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OnionButton
            // 
            this.OnionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.OnionButton.Location = new System.Drawing.Point(412, 15);
            this.OnionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OnionButton.Name = "OnionButton";
            this.OnionButton.Size = new System.Drawing.Size(180, 170);
            this.OnionButton.TabIndex = 5;
            this.OnionButton.Text = "Onion";
            this.OnionButton.UseVisualStyleBackColor = true;
            this.OnionButton.Click += new System.EventHandler(this.OnionButton_Click);
            // 
            // TomatoButton
            // 
            this.TomatoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TomatoButton.Location = new System.Drawing.Point(11, 15);
            this.TomatoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TomatoButton.Name = "TomatoButton";
            this.TomatoButton.Size = new System.Drawing.Size(180, 170);
            this.TomatoButton.TabIndex = 4;
            this.TomatoButton.Text = "Tomato";
            this.TomatoButton.UseVisualStyleBackColor = true;
            this.TomatoButton.Click += new System.EventHandler(this.TomatoButton_Click);
            // 
            // CucumberButton
            // 
            this.CucumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CucumberButton.Location = new System.Drawing.Point(211, 15);
            this.CucumberButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CucumberButton.Name = "CucumberButton";
            this.CucumberButton.Size = new System.Drawing.Size(180, 170);
            this.CucumberButton.TabIndex = 3;
            this.CucumberButton.Text = "Cucumber";
            this.CucumberButton.UseVisualStyleBackColor = true;
            this.CucumberButton.Click += new System.EventHandler(this.CucumberButton_Click);
            // 
            // LemonPrice
            // 
            this.LemonPrice.AutoSize = true;
            this.LemonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LemonPrice.Location = new System.Drawing.Point(407, 188);
            this.LemonPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LemonPrice.Name = "LemonPrice";
            this.LemonPrice.Size = new System.Drawing.Size(86, 22);
            this.LemonPrice.TabIndex = 57;
            this.LemonPrice.Text = "Price: 2.9";
            // 
            // OrangePrice
            // 
            this.OrangePrice.AutoSize = true;
            this.OrangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.OrangePrice.Location = new System.Drawing.Point(207, 188);
            this.OrangePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrangePrice.Name = "OrangePrice";
            this.OrangePrice.Size = new System.Drawing.Size(86, 22);
            this.OrangePrice.TabIndex = 56;
            this.OrangePrice.Text = "Price: 4.9";
            // 
            // WatermelonPrice
            // 
            this.WatermelonPrice.AutoSize = true;
            this.WatermelonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WatermelonPrice.Location = new System.Drawing.Point(7, 188);
            this.WatermelonPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WatermelonPrice.Name = "WatermelonPrice";
            this.WatermelonPrice.Size = new System.Drawing.Size(91, 22);
            this.WatermelonPrice.TabIndex = 55;
            this.WatermelonPrice.Text = "Price:  3.9";
            // 
            // VegtablesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LemonPrice);
            this.Controls.Add(this.OrangePrice);
            this.Controls.Add(this.WatermelonPrice);
            this.Controls.Add(this.OnionButton);
            this.Controls.Add(this.TomatoButton);
            this.Controls.Add(this.CucumberButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VegtablesMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnionButton;
        private System.Windows.Forms.Button TomatoButton;
        private System.Windows.Forms.Button CucumberButton;
        private System.Windows.Forms.Label LemonPrice;
        private System.Windows.Forms.Label OrangePrice;
        private System.Windows.Forms.Label WatermelonPrice;
    }
}