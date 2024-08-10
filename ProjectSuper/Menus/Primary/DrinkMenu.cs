using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSuper
{
    public partial class DrinkMenu : UserControl
    {
        public DrinkMenu()
        {
            InitializeComponent();
            if (!MainScreen._isAdult && MainScreen._askedForAdult)
            {
                AlcoholicButton.Hide();
                WineButton.Hide();
            }
        }
        private void AlcoholicButton_Click(object sender, EventArgs e)
        {
            if (!MainScreen._isAdult)
                MainScreen._isAdult = MainScreen.instance.adulthoodCheck(MainScreen.instance.ageMsg());

            if (MainScreen._isAdult)
            {
                AlcoholicMenu NextScreen = new AlcoholicMenu();
                MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
                NextScreen.BringToFront();
                NextScreen.Size = MainScreen.instance.ThrPanel.Size;
            }
            else
            {
                MessageBox.Show("Sorry, you cant see this window you are under aged", "Under age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlcoholicButton.Hide();
                WineButton.Hide();
            }
        }
        private void SoftDrinksButton_Click(object sender, EventArgs e)
        {
            SoftDrinksMenu NextScreen = new SoftDrinksMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
        private void WineButton_Click(object sender, EventArgs e)
        {
            if (!MainScreen._isAdult)
                MainScreen._isAdult = MainScreen.instance.adulthoodCheck(MainScreen.instance.ageMsg());

            if (MainScreen._isAdult)
            {
                WineMenu NextScreen = new WineMenu();
                MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
                NextScreen.BringToFront();
                NextScreen.Size = MainScreen.instance.ThrPanel.Size;
            }
            else
            {
                MessageBox.Show("Sorry, you cant see this window you are under aged", "Under age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AlcoholicButton.Hide();
                WineButton.Hide();
            }
        }
    
    }
}
