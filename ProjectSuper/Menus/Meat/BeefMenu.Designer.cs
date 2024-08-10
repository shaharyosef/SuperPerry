
namespace ProjectSuper
{
    partial class BeefMenu
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
            this.RibsButton = new System.Windows.Forms.Button();
            this.SteakButton = new System.Windows.Forms.Button();
            this.TBoneButton = new System.Windows.Forms.Button();
            this.RibsPrice = new System.Windows.Forms.Label();
            this.TBonePrice = new System.Windows.Forms.Label();
            this.SteakPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RibsButton
            // 
            this.RibsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RibsButton.Location = new System.Drawing.Point(412, 15);
            this.RibsButton.Margin = new System.Windows.Forms.Padding(2);
            this.RibsButton.Name = "RibsButton";
            this.RibsButton.Size = new System.Drawing.Size(180, 170);
            this.RibsButton.TabIndex = 5;
            this.RibsButton.Tag = "3";
            this.RibsButton.Text = "Ribs";
            this.RibsButton.UseVisualStyleBackColor = true;
            this.RibsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseDown);
            this.RibsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseMove);
            this.RibsButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseUp);
            // 
            // SteakButton
            // 
            this.SteakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SteakButton.Location = new System.Drawing.Point(11, 15);
            this.SteakButton.Margin = new System.Windows.Forms.Padding(2);
            this.SteakButton.Name = "SteakButton";
            this.SteakButton.Size = new System.Drawing.Size(180, 170);
            this.SteakButton.TabIndex = 4;
            this.SteakButton.Tag = "1";
            this.SteakButton.Text = "Steak";
            this.SteakButton.UseVisualStyleBackColor = true;
            this.SteakButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseDown);
            this.SteakButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseMove);
            this.SteakButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseUp);
            // 
            // TBoneButton
            // 
            this.TBoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TBoneButton.Location = new System.Drawing.Point(211, 15);
            this.TBoneButton.Margin = new System.Windows.Forms.Padding(2);
            this.TBoneButton.Name = "TBoneButton";
            this.TBoneButton.Size = new System.Drawing.Size(180, 170);
            this.TBoneButton.TabIndex = 3;
            this.TBoneButton.Tag = "2";
            this.TBoneButton.Text = "T-Bone";
            this.TBoneButton.UseVisualStyleBackColor = true;
            this.TBoneButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseDown);
            this.TBoneButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseMove);
            this.TBoneButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Generic_MouseUp);
            // 
            // RibsPrice
            // 
            this.RibsPrice.AutoSize = true;
            this.RibsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RibsPrice.Location = new System.Drawing.Point(407, 188);
            this.RibsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RibsPrice.Name = "RibsPrice";
            this.RibsPrice.Size = new System.Drawing.Size(184, 22);
            this.RibsPrice.TabIndex = 34;
            this.RibsPrice.Text = "Price per 1 Kg:  169.9";
            // 
            // TBonePrice
            // 
            this.TBonePrice.AutoSize = true;
            this.TBonePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TBonePrice.Location = new System.Drawing.Point(207, 188);
            this.TBonePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TBonePrice.Name = "TBonePrice";
            this.TBonePrice.Size = new System.Drawing.Size(184, 22);
            this.TBonePrice.TabIndex = 33;
            this.TBonePrice.Text = "Price per 1 Kg:  149.9";
            // 
            // SteakPrice
            // 
            this.SteakPrice.AutoSize = true;
            this.SteakPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SteakPrice.Location = new System.Drawing.Point(7, 188);
            this.SteakPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SteakPrice.Name = "SteakPrice";
            this.SteakPrice.Size = new System.Drawing.Size(184, 22);
            this.SteakPrice.TabIndex = 32;
            this.SteakPrice.Text = "Price per 1 Kg:  119.9";
            // 
            // BeefMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RibsPrice);
            this.Controls.Add(this.TBonePrice);
            this.Controls.Add(this.SteakPrice);
            this.Controls.Add(this.RibsButton);
            this.Controls.Add(this.SteakButton);
            this.Controls.Add(this.TBoneButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BeefMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RibsButton;
        private System.Windows.Forms.Button SteakButton;
        private System.Windows.Forms.Button TBoneButton;
        private System.Windows.Forms.Label RibsPrice;
        private System.Windows.Forms.Label TBonePrice;
        private System.Windows.Forms.Label SteakPrice;
    }
}