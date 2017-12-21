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
    public partial class whiteBoxTesterForm : Form
    {
        public whiteBoxTesterForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu MM = new mainMenu();
            MM.ShowDialog();
        }

        private void updateBugButton_Click(object sender, EventArgs e)
        {
            string updateQuery = "";
        }

        private void displayBugsButton_Click(object sender, EventArgs e)
        {
            bugListBox.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\c3418895\Documents\bugTrackingDatabase.mdf; Integrated Security = True; Connect Timeout = 30; MultipleActiveResultSets = true");
            String displayQuery = "SELECT * FROM bugTrackingTable";
            SqlCommand command = new SqlCommand(displayQuery, connection);
            connection.Open();
            SqlDataReader myDataReader = command.ExecuteReader();

            while (myDataReader.Read())
            {

                bugListBox.Items.Add(myDataReader["ID"].ToString());
                bugListBox.Items.Add(myDataReader["appName"].ToString());
                bugListBox.Items.Add(myDataReader["symptom"].ToString());
                bugListBox.Items.Add("");

            }
        }

        private void clearBugsButton_Click(object sender, EventArgs e)
        {
            bugListBox.Items.Clear();
        }

        private void clearBugButton_Click(object sender, EventArgs e)
        {
            appNameTextBox.Text = String.Empty;
            bugDescriptionTextBox.Text = String.Empty;
            bugCauseTextBox.Text = String.Empty;
            classFileTextBox.Text = String.Empty;
            methodTextBox.Text = String.Empty;
            codeBlockTextBox.Text = String.Empty;
            lineNumberTextBox.Text = String.Empty;
        }
    }
}
