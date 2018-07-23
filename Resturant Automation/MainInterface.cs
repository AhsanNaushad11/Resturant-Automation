using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Automation
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void AdvertisementsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signin = new SignInForm();
            signin.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            LogoPanel.Hide();
            AdvertisementsPanel.Hide();
            BottomPanel.Hide();
        }

        private void CallWaiterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please hold on, waiter is coming. :)");
        }

        private void MainInterfaceSidePicBoxSmall_Click(object sender, EventArgs e)
        {

        }

        private void MainInterfaceSidePicBoxLarge_Click(object sender, EventArgs e)
        {

        }

        private void MainInterfacePicBoxLarge_Click(object sender, EventArgs e)
        {

        }
    }
}
