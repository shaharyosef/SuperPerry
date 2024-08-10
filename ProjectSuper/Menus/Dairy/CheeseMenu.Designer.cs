
namespace ProjectSuper
{
    partial class CheeseMenu
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
            this.GoatButton = new System.Windows.Forms.Button();
            this.CheddarButton = new System.Windows.Forms.Button();
            this.GoudaButton = new System.Windows.Forms.Button();
            this.CheddarPrice = new System.Windows.Forms.Label();
            this.GoudaPrice = new System.Windows.Forms.Label();
            this.GoatPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoatButton
            // 
            this.GoatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GoatButton.Location = new System.Drawing.Point(412, 15);
            this.GoatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoatButton.Name = "GoatButton";
            this.GoatButton.Size = new System.Drawing.Size(180, 170);
            this.GoatButton.TabIndex = 5;
            this.GoatButton.Text = "Goat";
            this.GoatButton.UseVisualStyleBackColor = true;
            this.GoatButton.Click += new System.EventHandler(this.GoatButton_Click);
            // 
            // CheddarButton
            // 
            this.CheddarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CheddarButton.Location = new System.Drawing.Point(11, 15);
            this.CheddarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheddarButton.Name = "CheddarButton";
            this.CheddarButton.Size = new System.Drawing.Size(180, 170);
            this.CheddarButton.TabIndex = 4;
            this.CheddarButton.Text = "Cheddar";
            this.CheddarButton.UseVisualStyleBackColor = true;
            this.CheddarButton.Click += new System.EventHandler(this.CheddarButton_Click);
            // 
            // GoudaButton
            // 
            this.GoudaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GoudaButton.Location = new System.Drawing.Point(211, 15);
            this.GoudaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoudaButton.Name = "GoudaButton";
            this.GoudaButton.Size = new System.Drawing.Size(180, 170);
            this.GoudaButton.TabIndex = 3;
            this.GoudaButton.Text = "Gouda";
            this.GoudaButton.UseVisualStyleBackColor = true;
            this.GoudaButton.Click += new System.EventHandler(this.GoudaButton_Click);
            // 
            // CheddarPrice
            // 
            this.CheddarPrice.AutoSize = true;
            this.CheddarPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CheddarPrice.Location = new System.Drawing.Point(7, 188);
            this.CheddarPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheddarPrice.Name = "CheddarPrice";
            this.CheddarPrice.Size = new System.Drawing.Size(184, 22);
            this.CheddarPrice.TabIndex = 6;
            this.CheddarPrice.Text = "Price per 1 Kg:  114.9";
            // 
            // GoudaPrice
            // 
            this.GoudaPrice.AutoSize = true;
            this.GoudaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GoudaPrice.Location = new System.Drawing.Point(207, 188);
            this.GoudaPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoudaPrice.Name = "GoudaPrice";
            this.GoudaPrice.Size = new System.Drawing.Size(184, 22);
            this.GoudaPrice.TabIndex = 8;
            this.GoudaPrice.Text = "Price per 1 Kg:  129.9";
            // 
            // GoatPrice
            // 
            this.GoatPrice.AutoSize = true;
            this.GoatPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GoatPrice.Location = new System.Drawing.Point(407, 188);
            this.GoatPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoatPrice.Name = "GoatPrice";
            this.GoatPrice.Size = new System.Drawing.Size(184, 22);
            this.GoatPrice.TabIndex = 10;
            this.GoatPrice.Text = "Price per 1 Kg:  119.9";
            // 
            // CheeseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GoatPrice);
            this.Controls.Add(this.GoudaPrice);
            this.Controls.Add(this.CheddarPrice);
            this.Controls.Add(this.GoatButton);
            this.Controls.Add(this.CheddarButton);
            this.Controls.Add(this.GoudaButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheeseMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button GoatButton;
        private System.Windows.Forms.Button CheddarButton;
        private System.Windows.Forms.Button GoudaButton;
        private System.Windows.Forms.Label CheddarPrice;
        private System.Windows.Forms.Label GoudaPrice;
        private System.Windows.Forms.Label GoatPrice;
    }
}