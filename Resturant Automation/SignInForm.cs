using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Resturant_Automation
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            MessageLabel.Hide();
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            String SQLConnectionValue;
            SQLConnectionValue = @"Data Source = student-pc, 1433; Network Library = DBMSSOCN; Initial Catalog = Restaurant System; User ID = sa; Password = ahsan";
            try
            {
                SqlConnection sqlcon = new SqlConnection(SQLConnectionValue);
                SqlCommand AdminSignIn;
                SqlDataReader ReadingFromAdminSignIn;
                AdminSignIn = new SqlCommand("SELECT * FROM Administrators WHERE Email=@email and Password=@password", sqlcon);
                sqlcon.Open();
                AdminSignIn.Parameters.AddWithValue("@email", IDTextBox.Text);
                AdminSignIn.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                ReadingFromAdminSignIn = AdminSignIn.ExecuteReader();
                if (IDTextBox.Text == null || PasswordTextBox.Text == null)
                {
                    MessageLabel.Show();
                }
                else if (ReadingFromAdminSignIn.HasRows == true)
                {
                    AdminPanel adminpanel = new AdminPanel();
                    MainInterface.ActiveForm.Disposed += new EventHandler(closeMainInterface);
                    this.Close();
                    adminpanel.Show();
                }
                else MessageBox.Show("Incorrect credentials!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void closeMainInterface(object sender, EventArgs e)
        {
            MainInterface.ActiveForm.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = default(char);
            }
            else PasswordTextBox.PasswordChar = '•';
        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}