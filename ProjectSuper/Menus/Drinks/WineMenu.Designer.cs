
namespace ProjectSuper
{
    partial class WineMenu
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
            this.CavaButton = new System.Windows.Forms.Button();
            this.PinoButton = new System.Windows.Forms.Button();
            this.MerlotButton = new System.Windows.Forms.Button();
            this.MerlotPrice = new System.Windows.Forms.Label();
            this.CavaPrice = new System.Windows.Forms.Label();
            this.PinoPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CavaButton
            // 
            this.CavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CavaButton.Location = new System.Drawing.Point(211, 15);
            this.CavaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CavaButton.Name = "CavaButton";
            this.CavaButton.Size = new System.Drawing.Size(180, 170);
            this.CavaButton.TabIndex = 11;
            this.CavaButton.Text = "Cava";
            this.CavaButton.UseVisualStyleBackColor = true;
            this.CavaButton.Click += new System.EventHandler(this.CavaButton_Click);
            // 
            // PinoButton
            // 
            this.PinoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PinoButton.Location = new System.Drawing.Point(11, 16);
            this.PinoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PinoButton.Name = "PinoButton";
            this.PinoButton.Size = new System.Drawing.Size(180, 170);
            this.PinoButton.TabIndex = 9;
            this.PinoButton.Text = "Pino Noir";
            this.PinoButton.UseVisualStyleBackColor = true;
            this.PinoButton.Click += new System.EventHandler(this.PinoButton_Click);
            // 
            // MerlotButton
            // 
            this.MerlotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MerlotButton.Location = new System.Drawing.Point(412, 15);
            this.MerlotButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MerlotButton.Name = "MerlotButton";
            this.MerlotButton.Size = new System.Drawing.Size(180, 170);
            this.MerlotButton.TabIndex = 8;
            this.MerlotButton.Text = "Merlot";
            this.MerlotButton.UseVisualStyleBackColor = true;
            this.MerlotButton.Click += new System.EventHandler(this.MerlotButton_Click);
            // 
            // MerlotPrice
            // 
            this.MerlotPrice.AutoSize = true;
            this.MerlotPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MerlotPrice.Location = new System.Drawing.Point(407, 188);
            this.MerlotPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MerlotPrice.Name = "MerlotPrice";
            this.MerlotPrice.Size = new System.Drawing.Size(96, 22);
            this.MerlotPrice.TabIndex = 51;
            this.MerlotPrice.Text = "Price: 39.9";
            // 
            // CavaPrice
            // 
            this.CavaPrice.AutoSize = true;
            this.CavaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CavaPrice.Location = new System.Drawing.Point(207, 188);
            this.CavaPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CavaPrice.Name = "CavaPrice";
            this.CavaPrice.Size = new System.Drawing.Size(101, 22);
            this.CavaPrice.TabIndex = 50;
            this.CavaPrice.Text = "Price:  42.9";
            // 
            // PinoPrice
            // 
            this.PinoPrice.AutoSize = true;
            this.PinoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PinoPrice.Location = new System.Drawing.Point(7, 188);
            this.PinoPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PinoPrice.Name = "PinoPrice";
            this.PinoPrice.Size = new System.Drawing.Size(101, 22);
            this.PinoPrice.TabIndex = 49;
            this.PinoPrice.Text = "Price:  54.9";
            // 
            // WineMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MerlotPrice);
            this.Controls.Add(this.CavaPrice);
            this.Controls.Add(this.PinoPrice);
            this.Controls.Add(this.CavaButton);
            this.Controls.Add(this.PinoButton);
            this.Controls.Add(this.MerlotButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WineMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CavaButton;
        private System.Windows.Forms.Button PinoButton;
        private System.Windows.Forms.Button MerlotButton;
        private System.Windows.Forms.Label MerlotPrice;
        private System.Windows.Forms.Label CavaPrice;
        private System.Windows.Forms.Label PinoPrice;
    }
}