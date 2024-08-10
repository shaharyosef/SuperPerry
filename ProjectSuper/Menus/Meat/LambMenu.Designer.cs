
namespace ProjectSuper
{
    partial class LambMenu
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
            this.ShoulderButton = new System.Windows.Forms.Button();
            this.RibsButton = new System.Windows.Forms.Button();
            this.LegPrice = new System.Windows.Forms.Label();
            this.RibsPrice = new System.Windows.Forms.Label();
            this.ShoulderPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LegButton
            // 
            this.LegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LegButton.Location = new System.Drawing.Point(412, 15);
            this.LegButton.Margin = new System.Windows.Forms.Padding(2);
            this.LegButton.Name = "LegButton";
            this.LegButton.Size = new System.Drawing.Size(180, 170);
            this.LegButton.TabIndex = 6;
            this.LegButton.Tag = "3";
            this.LegButton.Text = "Leg";
            this.LegButton.UseVisualStyleBackColor = true;
            this.LegButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseDown);
            this.LegButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseMove);
            this.LegButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseUp);
            // 
            // ShoulderButton
            // 
            this.ShoulderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ShoulderButton.Location = new System.Drawing.Point(11, 16);
            this.ShoulderButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShoulderButton.Name = "ShoulderButton";
            this.ShoulderButton.Size = new System.Drawing.Size(180, 170);
            this.ShoulderButton.TabIndex = 5;
            this.ShoulderButton.Tag = "1";
            this.ShoulderButton.Text = "Shoulder";
            this.ShoulderButton.UseVisualStyleBackColor = true;
            this.ShoulderButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseDown);
            this.ShoulderButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseMove);
            this.ShoulderButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseUp);
            // 
            // RibsButton
            // 
            this.RibsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RibsButton.Location = new System.Drawing.Point(211, 15);
            this.RibsButton.Margin = new System.Windows.Forms.Padding(2);
            this.RibsButton.Name = "RibsButton";
            this.RibsButton.Size = new System.Drawing.Size(180, 170);
            this.RibsButton.TabIndex = 4;
            this.RibsButton.Tag = "2";
            this.RibsButton.Text = "Ribs";
            this.RibsButton.UseVisualStyleBackColor = true;
            this.RibsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseDown);
            this.RibsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseMove);
            this.RibsButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseUp);
            // 
            // LegPrice
            // 
            this.LegPrice.AutoSize = true;
            this.LegPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LegPrice.Location = new System.Drawing.Point(407, 188);
            this.LegPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LegPrice.Name = "LegPrice";
            this.LegPrice.Size = new System.Drawing.Size(184, 22);
            this.LegPrice.TabIndex = 44;
            this.LegPrice.Text = "Price per 1 Kg:  139.9";
            // 
            // RibsPrice
            // 
            this.RibsPrice.AutoSize = true;
            this.RibsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RibsPrice.Location = new System.Drawing.Point(207, 188);
            this.RibsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RibsPrice.Name = "RibsPrice";
            this.RibsPrice.Size = new System.Drawing.Size(184, 22);
            this.RibsPrice.TabIndex = 43;
            this.RibsPrice.Text = "Price per 1 Kg:  199.9";
            // 
            // ShoulderPrice
            // 
            this.ShoulderPrice.AutoSize = true;
            this.ShoulderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ShoulderPrice.Location = new System.Drawing.Point(7, 188);
            this.ShoulderPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShoulderPrice.Name = "ShoulderPrice";
            this.ShoulderPrice.Size = new System.Drawing.Size(174, 22);
            this.ShoulderPrice.TabIndex = 42;
            this.ShoulderPrice.Text = "Price per 1 Kg:  99.9";
            // 
            // LambMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LegPrice);
            this.Controls.Add(this.RibsPrice);
            this.Controls.Add(this.ShoulderPrice);
            this.Controls.Add(this.LegButton);
            this.Controls.Add(this.ShoulderButton);
            this.Controls.Add(this.RibsButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LambMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button LegButton;
        private System.Windows.Forms.Button ShoulderButton;
        private System.Windows.Forms.Button RibsButton;
        private System.Windows.Forms.Label LegPrice;
        private System.Windows.Forms.Label RibsPrice;
        private System.Windows.Forms.Label ShoulderPrice;
    }
}