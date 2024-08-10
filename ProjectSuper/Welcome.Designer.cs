
namespace ProjectSuper
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.FinalCountDown = new System.Windows.Forms.Timer(this.components);
            this.Continue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).BeginInit();
            this.SuspendLayout();
            // 
            // FinalCountDown
            // 
            this.FinalCountDown.Enabled = true;
            this.FinalCountDown.Interval = 1000;
            this.FinalCountDown.Tick += new System.EventHandler(this.FinalCountDown_Tick);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Location = new System.Drawing.Point(678, 108);
            this.Continue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(192, 123);
            this.Continue.TabIndex = 1;
            this.Continue.TabStop = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1220, 740);
            this.Controls.Add(this.Continue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FinalCountDown;
        private System.Windows.Forms.PictureBox Continue;
    }
}