
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text;
using System.Security.Cryptography;

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
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC11\SQLEXPRESS;Initial Catalog=db;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @username", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string righthash = (string)dt.Rows[0]["pwd"];
                        string salt = (string)dt.Rows[0]["dateandtime"];
                        string userhash = hashPassword($"{password}{salt}");
                        if (righthash == userhash)
                        {
                            IsAdmin = false;
                            DialogResult = DialogResult.OK;
                            Form2 steve = new Form2(false);
                            steve.Show();
                        }
                        else
                        {
                            MessageBox.Show("wrong password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found");
                    }
                    con.Close();
                }

            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Form4 steve = new Form4();
            steve.Show();
        }
        string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
