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
    public partial class DairyMenu : UserControl
    {
        public DairyMenu()
        {
            InitializeComponent();
        }
        private void MilkButton_Click(object sender, EventArgs e)
        {
            MilkMenu NextScreen = new MilkMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;

        }
        private void CheeseButton_Click(object sender, EventArgs e)
        {
            CheeseMenu NextScreen = new CheeseMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
        private void IceCreamButton_Click(object sender, EventArgs e)
        {
            IceCreamMenu NextScreen = new IceCreamMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
    }
}
