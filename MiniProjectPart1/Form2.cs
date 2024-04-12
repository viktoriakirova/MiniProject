
using System.Data.SqlClient;

namespace MiniProjectPart1
{
    public partial class Form2 : Form
    {
        private bool isAdmin;
        public Form2(bool isAdmin)
        {
            InitializeComponent();
            PopulateCountriesComboBox();
            PopulateTownsComboBox();
            if (!isAdmin)
            {
                adminButton.Enabled = false;
                adminButton.Visible = false;
            }
        }

        public void EnableAdminButton (bool admin)
        {
            if (admin)
            {
                adminButton.Enabled = true;
                adminButton.Visible = true;
            }
            else
            {
                adminButton.Enabled = false;   
                adminButton.Visible = false;
            }
        }
        private void PopulateCountriesComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAB108PC11\SQLEXPRESS;Initial Catalog=db;Integrated Security=True"))
                {
                    string query = "SELECT country FROM Countries";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxCountries.Items.Add(reader["country"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving countries from the database: " + ex.Message);
            }
        }

        private void PopulateTownsComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAB108PC11\SQLEXPRESS;Initial Catalog=db;Integrated Security=True"))
                {
                    string query = "SELECT town FROM Towns";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxTowns.Items.Add(reader["town"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving towns from the database: " + ex.Message);
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {

            Form1 loginForm = new Form1();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Open Form1 when login is successful
                Form1 form1 = new Form1();
                form1.Show();

                // Enable admin button if the user is an admin

            }
        }
    }
}

