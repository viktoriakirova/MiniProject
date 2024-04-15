using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectPart1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
      
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string check = PasswordCheckTextBox.Text;
            string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[?!@#$%_&*])[A-Za-z0-9?!@#$%_&*]{8,}$";
            if (password != check)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("Invalid password. Password should be at least 8 characters long with at least one capital letter, one lowercase letter, one digit, and one special character.");
                return;
            }
            string salt = DateTime.Now.ToString();
            string hashedPassword = hashPassword($"{password}{salt}");
            string connectionString = @"Data Source=LAB108PC12\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True";
            string hashPassword(string password)
            {
                SHA256 hashAlgorithm = SHA256.Create();
                var bytes = Encoding.Default.GetBytes(password);
                var hash = hashAlgorithm.ComputeHash(bytes);
                return Convert.ToBase64String(hash);

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO users (username, dateandtime, pwd) VALUES (@Username, @DateandTime, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@DateandTime", salt);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.");
                    }
                }
            }


        

        

    }
}

