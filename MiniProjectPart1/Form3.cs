
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
                Form2 Form2 = new Form2(true);
                Form2.Show();
                Form2.EnableAdminButton(true); // Enable adminButton for admin
            }
            else if (username.Contains("user") && password.Contains("user"))
            {
                IsAdmin = false;
                DialogResult = DialogResult.OK;
                Form2 Form2 = new Form2(true);
                Form2.Show();
                Form2.EnableAdminButton(false); // Disable adminButton for non-admin users
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

    }
}
