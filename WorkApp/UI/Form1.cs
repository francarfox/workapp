using Bunifu.Framework.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            username.Text = Session.sharedInstance.company.name;

            Icon = Properties.Resources.workapp;
            menu3.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            homeMenu1.BringToFront();
            option_Click(sender, e);
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            workersMenu1.BringToFront();
            option_Click(sender, e);
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            settingsMenu1.BringToFront();
            option_Click(sender, e);
        }

        private void option_Click(object sender, EventArgs e)
        {
            menu1.selected = false;
            menu2.selected = false;
            menu3.selected = false;

            ((ns1.BunifuFlatButton)sender).selected = true;
        }

    }
}
