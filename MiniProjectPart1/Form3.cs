using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectPart1
{
    public partial class Form3 : Form
    {
        public bool IsAdmin { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (username.Contains("admin") && password.Contains("admin"))
            {
                IsAdmin = true;
                DialogResult = DialogResult.OK;
                Form2 steve = new Form2(true);
                steve.Show();
                steve.EnableAdminButton(true); // Enable adminButton for admin
            }
            else if (username.Contains("user") && password.Contains("user"))
            {
                IsAdmin = false;
                DialogResult = DialogResult.OK;
                Form2 steve = new Form2(true);
                steve.Show();
                steve.EnableAdminButton(false); // Disable adminButton for non-admin users
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
