
namespace ProjectSuper
{
    partial class DairyMenu
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
            this.IceCreamButton = new System.Windows.Forms.Button();
            this.MilkButton = new System.Windows.Forms.Button();
            this.CheeseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IceCreamButton
            // 
            this.IceCreamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IceCreamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IceCreamButton.Location = new System.Drawing.Point(11, 15);
            this.IceCreamButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IceCreamButton.Name = "IceCreamButton";
            this.IceCreamButton.Size = new System.Drawing.Size(180, 170);
            this.IceCreamButton.TabIndex = 1;
            this.IceCreamButton.Text = "Ice Cream";
            this.IceCreamButton.UseVisualStyleBackColor = true;
            this.IceCreamButton.Click += new System.EventHandler(this.IceCreamButton_Click);
            // 
            // MilkButton
            // 
            this.MilkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MilkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MilkButton.Location = new System.Drawing.Point(211, 15);
            this.MilkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MilkButton.Name = "MilkButton";
            this.MilkButton.Size = new System.Drawing.Size(180, 170);
            this.MilkButton.TabIndex = 0;
            this.MilkButton.Text = "Milk";
            this.MilkButton.UseVisualStyleBackColor = true;
            this.MilkButton.Click += new System.EventHandler(this.MilkButton_Click);
            // 
            // CheeseButton
            // 
            this.CheeseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheeseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CheeseButton.Location = new System.Drawing.Point(412, 15);
            this.CheeseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheeseButton.Name = "CheeseButton";
            this.CheeseButton.Size = new System.Drawing.Size(180, 170);
            this.CheeseButton.TabIndex = 2;
            this.CheeseButton.Text = "Cheese";
            this.CheeseButton.UseVisualStyleBackColor = true;
            this.CheeseButton.Click += new System.EventHandler(this.CheeseButton_Click);
            // 
            // DairyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.CheeseButton);
            this.Controls.Add(this.IceCreamButton);
            this.Controls.Add(this.MilkButton);
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DairyMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IceCreamButton;
        private System.Windows.Forms.Button MilkButton;
        private System.Windows.Forms.Button CheeseButton;

    }
}