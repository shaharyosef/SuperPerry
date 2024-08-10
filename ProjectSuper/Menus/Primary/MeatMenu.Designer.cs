
namespace ProjectSuper
{
    partial class MeatMenu
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
            this.BeefButton = new System.Windows.Forms.Button();
            this.Chicken = new System.Windows.Forms.Button();
            this.LambButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BeefButton
            // 
            this.BeefButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BeefButton.Location = new System.Drawing.Point(11, 15);
            this.BeefButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BeefButton.Name = "BeefButton";
            this.BeefButton.Size = new System.Drawing.Size(180, 170);
            this.BeefButton.TabIndex = 0;
            this.BeefButton.Text = "Beef";
            this.BeefButton.UseVisualStyleBackColor = true;
            this.BeefButton.Click += new System.EventHandler(this.BeefButton_Click);
            // 
            // Chicken
            // 
            this.Chicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Chicken.Location = new System.Drawing.Point(412, 15);
            this.Chicken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(180, 170);
            this.Chicken.TabIndex = 1;
            this.Chicken.Text = "Chicken";
            this.Chicken.UseVisualStyleBackColor = true;
            this.Chicken.Click += new System.EventHandler(this.Chicken_Click);
            // 
            // LambButton
            // 
            this.LambButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LambButton.Location = new System.Drawing.Point(211, 15);
            this.LambButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LambButton.Name = "LambButton";
            this.LambButton.Size = new System.Drawing.Size(180, 170);
            this.LambButton.TabIndex = 3;
            this.LambButton.Text = "Lamb";
            this.LambButton.UseVisualStyleBackColor = true;
            this.LambButton.Click += new System.EventHandler(this.LambButton_Click);
            // 
            // MeatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LambButton);
            this.Controls.Add(this.Chicken);
            this.Controls.Add(this.BeefButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MeatMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BeefButton;
        private System.Windows.Forms.Button Chicken;

        private System.Windows.Forms.Button LambButton;
    }
}