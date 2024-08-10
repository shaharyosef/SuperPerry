using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class Welcome : Form
    {
        private int timerCount = 0;
        private const int maxTimerCount = 15;
        private static Form newform = null;
        public Welcome()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"WelcomePage.png");
            FinalCountDown = new Timer();
            FinalCountDown.Interval = 1000; // Set the timer interval to 1 second
            FinalCountDown.Tick += FinalCountDown_Tick; // Attach the event handler
            FinalCountDown.Start();
        }
        private void showMain()
        {
            //  Check if main screen already shown
            if (newform == null || newform.IsDisposed)
            {
                newform = new MainScreen();
            }
            newform.Show();
            this.Hide();
        }
        private void FinalCountDown_Tick(object sender, EventArgs e)
        {
            timerCount++;
            if (timerCount >= maxTimerCount)
            {
                FinalCountDown.Stop(); // Stop the timer
                showMain(); // Call the showMain method
            }
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            showMain();
        }
    }
}
