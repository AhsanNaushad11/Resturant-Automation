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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminBackButton_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = new MainInterface();
            mainInterface.Show();
            this.Close();
        }

        private void AddRemoveEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AddRemoveMenuLinkedLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CustomerFeedbacksLinkedLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PlaceAdvertisementsLinkedLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
