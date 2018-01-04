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
    public partial class developerForm : Form
    {
        public developerForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu MM = new mainMenu();
            MM.ShowDialog();
        }

        private void displayBugsButton_Click(object sender, EventArgs e)
        {
            bugsDisplayBox.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            String displayQuery = "SELECT * FROM bugTrackingTable";
            SqlCommand command = new SqlCommand(displayQuery, connection);
            connection.Open();
            SqlDataReader myDataReader = command.ExecuteReader();

            while (myDataReader.Read())
            {

                bugsDisplayBox.Items.Add("Bug ID: " + myDataReader["ID"].ToString());
                bugsDisplayBox.Items.Add("Application Name: " + myDataReader["appName"].ToString());
                bugsDisplayBox.Items.Add("Bug Description: " + myDataReader["symptom"].ToString());
                bugsDisplayBox.Items.Add("");

            }
        }

        private void clearBugsButton_Click(object sender, EventArgs e)
        {
            bugsDisplayBox.Items.Clear();
        }

        private void clearBugButton_Click(object sender, EventArgs e)
        {
            chosenBugDisplayBox.Items.Clear();
            chosenBugIDBox.Text = String.Empty;
        }

        private void displayBugButton_Click(object sender, EventArgs e)
        {
            if (chosenBugIDBox.Text != String.Empty)
            {

                chosenBugDisplayBox.Items.Clear();

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                String pullBugCmd = "SELECT * FROM bugTrackingTable WHERE id=" + chosenBugIDBox.Text;
                SqlCommand command = new SqlCommand(pullBugCmd, connection);

                connection.Open();

                SqlDataReader mySqlDataReader = command.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    chosenBugDisplayBox.Items.Add("Archived Bug ID: " + mySqlDataReader["ID"].ToString());
                    chosenBugDisplayBox.Items.Add("Application Name: " + mySqlDataReader["appName"].ToString());
                    chosenBugDisplayBox.Items.Add("Bug Description: " + mySqlDataReader["symptom"].ToString());
                    chosenBugDisplayBox.Items.Add("Bug Cause: " + mySqlDataReader["cause"].ToString());
                    chosenBugDisplayBox.Items.Add("Class File: " + mySqlDataReader["classFile"].ToString());
                    chosenBugDisplayBox.Items.Add("Method: " + mySqlDataReader["method"].ToString());
                    chosenBugDisplayBox.Items.Add("Code Block: " + mySqlDataReader["codeBlock"].ToString());
                    chosenBugDisplayBox.Items.Add("Line Number: " + mySqlDataReader["lineNumber"].ToString());
                    chosenBugDisplayBox.Items.Add("Code Author: " + mySqlDataReader["codeAuthor"].ToString());
                    chosenBugDisplayBox.Items.Add("");

                }
            }else
            {

                MessageBox.Show("Please enter a Bug ID.");

            }
        }

        private void deleteBugButton_Click(object sender, EventArgs e)
        {
            String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            String deleteQuery = "DELETE FROM bugTrackingTable WHERE id=" + chosenBugIDBox.Text;

            using(SqlConnection myConnection = new SqlConnection(connection))
            {
                using(SqlCommand command = new SqlCommand(deleteQuery, myConnection))
                {

                    myConnection.Open();
                    command.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Bug deleted successfully");
                    chosenBugDisplayBox.Items.Clear();
                    chosenBugIDBox.Text = String.Empty;

                }
            }
        }

        public void updateRecord(String fixerName, String fixDate, String fixerComment, String commandString)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@fixerName", fixerName);
            command.Parameters.AddWithValue("@fixDate", fixDate);
            command.Parameters.AddWithValue("@fixerComment", fixerComment);
            command.ExecuteNonQuery();

        }

        private void archiveBugsButton_Click(object sender, EventArgs e)
        {
            String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            String commandString = "UPDATE bugTrackingTable SET fixerName = @fixerName, fixDate = @fixDate, fixerComment = @fixerComment WHERE id = " + fixedBugIDTextBox.Text;
            updateRecord(fixerNameTextBox.Text, fixDateTextBox.Text, commentTextBox.Text, commandString);

            String archiveQuery = "INSERT INTO archivedBugsTable (appName, symptom, cause, classFile, method, codeBlock, lineNumber, codeAuthor, fixerName, fixDate, fixerComment) SELECT appName, symptom, cause, classFile, method, codeBlock, lineNumber, codeAuthor, fixerName, fixDate, fixerComment FROM bugTrackingTable WHERE id=" + fixedBugIDTextBox.Text;
            String deleteQuery = "DELETE FROM bugTrackingTable WHERE id = " + fixedBugIDTextBox.Text;   
            
            using (SqlConnection myConnection = new SqlConnection(connection))
            {
                myConnection.Open();
                using (SqlCommand archiveCommand = new SqlCommand(archiveQuery, myConnection))
                {

                    archiveCommand.ExecuteNonQuery();

                }
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, myConnection))
                {

                    deleteCommand.ExecuteNonQuery();

                }
            }

            fixedBugIDTextBox.Text = String.Empty;
            fixerNameTextBox.Text = String.Empty;
            fixDateTextBox.Text = String.Empty;
            commentTextBox.Text = String.Empty;
            chosenBugDisplayBox.Items.Clear();

            MessageBox.Show("Bug archived successfully.");
        }
    }
}