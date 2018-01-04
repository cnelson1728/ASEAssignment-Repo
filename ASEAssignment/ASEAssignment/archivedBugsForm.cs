using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignment
{
    public partial class archivedBugsForm : Form
    {


        public archivedBugsForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu MM = new mainMenu();
            MM.ShowDialog();
        }

        private void displayArchivedBugsButton_Click(object sender, EventArgs e)
        {
            archivedBugsListBox.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            String displayQuery = "SELECT * FROM archivedBugsTable";
            SqlCommand command = new SqlCommand(displayQuery, connection);
            connection.Open();
            SqlDataReader myDataReader = command.ExecuteReader();

            while (myDataReader.Read())
            {

                archivedBugsListBox.Items.Add("Application ID: " + myDataReader["ID"].ToString());
                archivedBugsListBox.Items.Add("Application Name: " + myDataReader["appName"].ToString());
                archivedBugsListBox.Items.Add("Bug Description: " + myDataReader["symptom"].ToString());
                archivedBugsListBox.Items.Add("Bug Cause: " + myDataReader["cause"].ToString());
                archivedBugsListBox.Items.Add("Class File: " + myDataReader["classFile"].ToString());
                archivedBugsListBox.Items.Add("Method: " + myDataReader["method"].ToString());
                archivedBugsListBox.Items.Add("Code Block: " + myDataReader["codeBlock"].ToString());
                archivedBugsListBox.Items.Add("Line Number: " + myDataReader["lineNumber"].ToString());
                archivedBugsListBox.Items.Add("Code Author: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("Fixer Name: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("Fix Date: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("Fixer Comment: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("");

            }
        }

        private void deleteBugButton_Click(object sender, EventArgs e)
        {
            String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            String deleteQuery = "DELETE FROM archivedBugsTable WHERE id=" + deleteBugID.Text;            

            using (SqlConnection mySqlConnection = new SqlConnection(connection))
            {
                mySqlConnection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, mySqlConnection))
                {


                    deleteCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Bug deleted successfully");
                    deleteBugID.Text = String.Empty;
                    

                }
            }

            String displayQuery = "SELECT * FROM archivedBugsTable";
            archivedBugsListBox.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connection);
            SqlCommand displayCommand = new SqlCommand(displayQuery, myConnection);
            myConnection.Open();
            SqlDataReader myDataReader = displayCommand.ExecuteReader();

            while (myDataReader.Read())
            {

                archivedBugsListBox.Items.Add("Application ID: " + myDataReader["ID"].ToString());
                archivedBugsListBox.Items.Add("Application Name: " + myDataReader["appName"].ToString());
                archivedBugsListBox.Items.Add("Bug Description: " + myDataReader["symptom"].ToString());
                archivedBugsListBox.Items.Add("Bug Cause: " + myDataReader["cause"].ToString());
                archivedBugsListBox.Items.Add("Class File: " + myDataReader["classFile"].ToString());
                archivedBugsListBox.Items.Add("Method: " + myDataReader["method"].ToString());
                archivedBugsListBox.Items.Add("Code Block: " + myDataReader["codeBlock"].ToString());
                archivedBugsListBox.Items.Add("Line Number: " + myDataReader["lineNumber"].ToString());
                archivedBugsListBox.Items.Add("Code Author: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("Fixer Name: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("Fix Date: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("Fixer Comment: " + myDataReader["codeAuthor"].ToString());
                archivedBugsListBox.Items.Add("");

            }
        }
    }
}