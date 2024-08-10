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
    public partial class MeatMenu : UserControl
    {
        public MeatMenu()
        {
            InitializeComponent();
        }
        private void BeefButton_Click(object sender, EventArgs e)
        {
            BeefMenu NextScreen = new BeefMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
        private void Chicken_Click(object sender, EventArgs e)
        {
            ChickenMenu NextScreen = new ChickenMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
        private void LambButton_Click(object sender, EventArgs e)
        {
            LambMenu NextScreen = new LambMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
    }
}
