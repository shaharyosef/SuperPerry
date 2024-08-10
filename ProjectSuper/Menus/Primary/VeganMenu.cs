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
    public partial class VeganMenu : UserControl
    {
        public VeganMenu()
        {
            InitializeComponent();
        }
        private void VegetablesButton_Click(object sender, EventArgs e)
        {
            VegtablesMenu NextScreen = new VegtablesMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
        private void FruitsButton_Click(object sender, EventArgs e)
        {
            FruitsMenu NextScreen = new FruitsMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
        private void FrozenButton_Click(object sender, EventArgs e)
        {
            FrozenMenu NextScreen = new FrozenMenu();
            MainScreen.instance.ThrPanel.Controls.Add(NextScreen);
            NextScreen.BringToFront();
            NextScreen.Size = MainScreen.instance.ThrPanel.Size;
        }
    }
}
