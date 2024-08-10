
namespace ProjectSuper
{
    partial class DrinkMenu
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
            this.AlcoholicButton = new System.Windows.Forms.Button();
            this.NonAlcoholicButton = new System.Windows.Forms.Button();
            this.WineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlcoholicButton
            // 
            this.AlcoholicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AlcoholicButton.Location = new System.Drawing.Point(11, 15);
            this.AlcoholicButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlcoholicButton.Name = "AlcoholicButton";
            this.AlcoholicButton.Size = new System.Drawing.Size(180, 170);
            this.AlcoholicButton.TabIndex = 5;
            this.AlcoholicButton.Text = "Alcoholic";
            this.AlcoholicButton.UseVisualStyleBackColor = true;
            this.AlcoholicButton.Click += new System.EventHandler(this.AlcoholicButton_Click);
            // 
            // NonAlcoholicButton
            // 
            this.NonAlcoholicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NonAlcoholicButton.Location = new System.Drawing.Point(412, 15);
            this.NonAlcoholicButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NonAlcoholicButton.Name = "NonAlcoholicButton";
            this.NonAlcoholicButton.Size = new System.Drawing.Size(180, 170);
            this.NonAlcoholicButton.TabIndex = 4;
            this.NonAlcoholicButton.Text = "Soft drinks";
            this.NonAlcoholicButton.UseVisualStyleBackColor = true;
            this.NonAlcoholicButton.Click += new System.EventHandler(this.SoftDrinksButton_Click);
            // 
            // WineButton
            // 
            this.WineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WineButton.Location = new System.Drawing.Point(211, 15);
            this.WineButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WineButton.Name = "WineButton";
            this.WineButton.Size = new System.Drawing.Size(180, 170);
            this.WineButton.TabIndex = 7;
            this.WineButton.Text = "Wine";
            this.WineButton.UseVisualStyleBackColor = true;
            this.WineButton.Click += new System.EventHandler(this.WineButton_Click);
            // 
            // DrinkMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WineButton);
            this.Controls.Add(this.AlcoholicButton);
            this.Controls.Add(this.NonAlcoholicButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DrinkMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AlcoholicButton;
        private System.Windows.Forms.Button NonAlcoholicButton;

        private System.Windows.Forms.Button WineButton;
    }
}