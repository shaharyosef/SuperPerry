
namespace ProjectSuper
{
    partial class FrozenMenu
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
            this.Spinach = new System.Windows.Forms.Button();
            this.PeasButton = new System.Windows.Forms.Button();
            this.BroccoliButton = new System.Windows.Forms.Button();
            this.BroccoliPrice = new System.Windows.Forms.Label();
            this.SpinachPrice = new System.Windows.Forms.Label();
            this.PeasPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Spinach
            // 
            this.Spinach.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Spinach.Location = new System.Drawing.Point(211, 15);
            this.Spinach.Margin = new System.Windows.Forms.Padding(2);
            this.Spinach.Name = "Spinach";
            this.Spinach.Size = new System.Drawing.Size(180, 170);
            this.Spinach.TabIndex = 8;
            this.Spinach.Text = "Spinach";
            this.Spinach.UseVisualStyleBackColor = true;
            this.Spinach.Click += new System.EventHandler(this.Spinach_Click);
            // 
            // PeasButton
            // 
            this.PeasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PeasButton.Location = new System.Drawing.Point(11, 16);
            this.PeasButton.Margin = new System.Windows.Forms.Padding(2);
            this.PeasButton.Name = "PeasButton";
            this.PeasButton.Size = new System.Drawing.Size(180, 170);
            this.PeasButton.TabIndex = 7;
            this.PeasButton.Text = "Peas";
            this.PeasButton.UseVisualStyleBackColor = true;
            this.PeasButton.Click += new System.EventHandler(this.PeaseButton_Click);
            // 
            // BroccoliButton
            // 
            this.BroccoliButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BroccoliButton.Location = new System.Drawing.Point(412, 15);
            this.BroccoliButton.Margin = new System.Windows.Forms.Padding(2);
            this.BroccoliButton.Name = "BroccoliButton";
            this.BroccoliButton.Size = new System.Drawing.Size(180, 170);
            this.BroccoliButton.TabIndex = 6;
            this.BroccoliButton.Text = "Broccoli";
            this.BroccoliButton.UseVisualStyleBackColor = true;
            this.BroccoliButton.Click += new System.EventHandler(this.BroccoliButton_Click);
            // 
            // BroccoliPrice
            // 
            this.BroccoliPrice.AutoSize = true;
            this.BroccoliPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BroccoliPrice.Location = new System.Drawing.Point(407, 188);
            this.BroccoliPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BroccoliPrice.Name = "BroccoliPrice";
            this.BroccoliPrice.Size = new System.Drawing.Size(174, 22);
            this.BroccoliPrice.TabIndex = 39;
            this.BroccoliPrice.Text = "Price per 1 Kg:  15.9";
            // 
            // SpinachPrice
            // 
            this.SpinachPrice.AutoSize = true;
            this.SpinachPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SpinachPrice.Location = new System.Drawing.Point(207, 188);
            this.SpinachPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpinachPrice.Name = "SpinachPrice";
            this.SpinachPrice.Size = new System.Drawing.Size(174, 22);
            this.SpinachPrice.TabIndex = 38;
            this.SpinachPrice.Text = "Price per 1 Kg:  19.9";
            // 
            // PeasPrice
            // 
            this.PeasPrice.AutoSize = true;
            this.PeasPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PeasPrice.Location = new System.Drawing.Point(7, 188);
            this.PeasPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PeasPrice.Name = "PeasPrice";
            this.PeasPrice.Size = new System.Drawing.Size(174, 22);
            this.PeasPrice.TabIndex = 37;
            this.PeasPrice.Text = "Price per 1 Kg:  13.9";
            // 
            // FrozenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BroccoliPrice);
            this.Controls.Add(this.SpinachPrice);
            this.Controls.Add(this.PeasPrice);
            this.Controls.Add(this.Spinach);
            this.Controls.Add(this.PeasButton);
            this.Controls.Add(this.BroccoliButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrozenMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Spinach;

        private System.Windows.Forms.Button PeasButton;
        private System.Windows.Forms.Button BroccoliButton;
        private System.Windows.Forms.Label BroccoliPrice;
        private System.Windows.Forms.Label SpinachPrice;
        private System.Windows.Forms.Label PeasPrice;
    }
}