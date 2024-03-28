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
            if (username.Contains("*") && password.Contains("*"))
            {
                IsAdmin = true;
                DialogResult = DialogResult.OK;
                Form2 steve = new Form2(true);
                steve.Show();
            }
            else
            {
                IsAdmin = false;
                DialogResult = DialogResult.OK;
                Form2 steve = new Form2(false);
                steve.Show();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
