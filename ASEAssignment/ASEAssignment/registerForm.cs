using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignment
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        public void registerUser(String username, String password, String commandString)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (registerUsernameTextBox.Text != String.Empty && registerPasswordTextBox.Text != String.Empty)
            {

                String commandString = "INSERT INTO loginTable (username, password) Values(@username, @password)";
                registerUser(registerUsernameTextBox.Text, registerPasswordTextBox.Text, commandString);
                MessageBox.Show("Account created successfully");
                registerUsernameTextBox.Text = "";
                registerPasswordTextBox.Text = "";

            }
            else
            {

                MessageBox.Show("Please fill out all fields.");

            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            loginPage LP = new loginPage();
            LP.ShowDialog();

        }
    }
}
