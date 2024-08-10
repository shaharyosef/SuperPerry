
namespace ProjectSuper
{
    partial class VeganMenu
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
            this.VegetablesButton = new System.Windows.Forms.Button();
            this.FruitsButton = new System.Windows.Forms.Button();
            this.FrozenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VegetablesButton
            // 
            this.VegetablesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VegetablesButton.Location = new System.Drawing.Point(12, 15);
            this.VegetablesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VegetablesButton.Name = "VegetablesButton";
            this.VegetablesButton.Size = new System.Drawing.Size(180, 170);
            this.VegetablesButton.TabIndex = 3;
            this.VegetablesButton.Text = "Vegetables";
            this.VegetablesButton.UseVisualStyleBackColor = true;
            this.VegetablesButton.Click += new System.EventHandler(this.VegetablesButton_Click);
            // 
            // FruitsButton
            // 
            this.FruitsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FruitsButton.Location = new System.Drawing.Point(412, 15);
            this.FruitsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FruitsButton.Name = "FruitsButton";
            this.FruitsButton.Size = new System.Drawing.Size(180, 170);
            this.FruitsButton.TabIndex = 2;
            this.FruitsButton.Text = "Fruits";
            this.FruitsButton.UseVisualStyleBackColor = true;
            this.FruitsButton.Click += new System.EventHandler(this.FruitsButton_Click);
            // 
            // FrozenButton
            // 
            this.FrozenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FrozenButton.Location = new System.Drawing.Point(211, 15);
            this.FrozenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FrozenButton.Name = "FrozenButton";
            this.FrozenButton.Size = new System.Drawing.Size(180, 170);
            this.FrozenButton.TabIndex = 4;
            this.FrozenButton.Text = "Frozen";
            this.FrozenButton.UseVisualStyleBackColor = true;
            this.FrozenButton.Click += new System.EventHandler(this.FrozenButton_Click);
            // 
            // VeganMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FrozenButton);
            this.Controls.Add(this.VegetablesButton);
            this.Controls.Add(this.FruitsButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VeganMenu";
            this.Size = new System.Drawing.Size(612, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VegetablesButton;
        private System.Windows.Forms.Button FruitsButton;

        private System.Windows.Forms.Button FrozenButton;
    }
}