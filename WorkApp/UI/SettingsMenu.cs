using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkApp.UI
{
    public partial class SettingsMenu : UserControl
    {
        public SettingsMenu()
        {
            InitializeComponent();

            int percent = (int)Properties.Settings.Default["Percent"];

            slider1.Value = percent;
            circleProgressbar1.Value = percent;
        }

        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            circleProgressbar1.Value = slider1.Value;

            Properties.Settings.Default["Percent"] = slider1.Value;
            Properties.Settings.Default.Save();
        }
    }
}
