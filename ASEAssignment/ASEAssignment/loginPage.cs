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

namespace ASEAssignment
{
    public partial class loginPage : Form
    {
        public loginPage()
        {

            InitializeComponent();

        }

        /// <summary>
        /// Login button
        /// Checks user entered username and password against table data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {

            SqlConnection loginConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\bugTrackingDatabase.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter loginAdapter = new SqlDataAdapter("SELECT count(*) FROM loginTable WHERE username = '" + usernameTextBox.Text + "' AND password = '" + passwordTextBox.Text + "'", loginConnection);
            DataTable dt = new DataTable();
            loginAdapter.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {

                this.Hide();
                mainMenu MM = new mainMenu();
                MM.ShowDialog();

            }
            else
            {

                MessageBox.Show("Invalid Username or Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {

            usernameTextBox.Text = "";
            passwordTextBox.Text = "";

        }

        private void registerAccountButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            registerForm RF = new registerForm();
            RF.ShowDialog();

        }
    }
}
