using ColorCode;
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

        /// <summary>
        /// Method to display the current bugs in the Bug Tracking Table
        /// </summary>
        private void displayBugs()
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
                bugsDisplayBox.Items.Add("");

            }

        }

        public developerForm()
        {

            InitializeComponent();
            displayBugs();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            mainMenu MM = new mainMenu();
            MM.ShowDialog();

        }

        private void clearBugsButton_Click(object sender, EventArgs e)
        {

            bugsDisplayBox.Items.Clear();

        }

        private void clearBugButton_Click(object sender, EventArgs e)
        {

            chosenBugDisplayBox.Items.Clear();
            chosenBugIDBox.Text = "";
            editSourceCodeTextBox.Text = "";
            sourceCodeWebBrowser.DocumentText = "";
            fixerNameTextBox.Text = "";
            fixDateTextBox.Text = "";
            commentTextBox.Text = "";

        }

        /// <summary>
        /// Displays information from the specific bug that the developer entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayBugButton_Click(object sender, EventArgs e)
        {
            try
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
                        editSourceCodeTextBox.Text = mySqlDataReader["sourceCode"].ToString();

                    }

                    if (chosenBugDisplayBox.Items.Count == 0) // If the list box contains no data the user has entered a bug ID that doesn't match a record in the table
                    {

                        MessageBox.Show("No matching records. Please enter a valid Bug ID.");
                        chosenBugIDBox.Text = String.Empty;

                    }
                }
                else
                {

                    MessageBox.Show("Please enter a Bug ID.");

                }
            }
            catch (Exception exception) // Catches an exception for if the user enters a string and not an Integer
            {

                chosenBugIDBox.Text = String.Empty;
                MessageBox.Show("Please enter an integer for Bug ID.");

            }

        }

        /// <summary>
        /// Deletes the bug entered by the developer
        /// Used if the developer wants to delete a bug from the bug tracking table without fixing
        /// Could be used if a bug submitted is not applicable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBugButton_Click(object sender, EventArgs e)
        {
            if (bugsDisplayBox.Items.Contains("Bug ID: " + chosenBugIDBox.Text)) // Deletes if the bug ID entered matches a bug ID in the display box i.e. if it exists in the table
            {

                String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";

                String deleteQuery = "DELETE FROM bugTrackingTable WHERE id=" + chosenBugIDBox.Text;

                using (SqlConnection myConnection = new SqlConnection(connection))
                {
                    using (SqlCommand command = new SqlCommand(deleteQuery, myConnection))
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
            else
            {

                MessageBox.Show("Please enter a valid Bug ID to delete.");
                chosenBugIDBox.Text = String.Empty;

            }
        }

        /// <summary>
        /// Method to update a record
        /// Updates the record that has been fixed by the developer with the source code of the bug, the fixer's name, the fix date, and a comment from the fixer
        /// </summary>
        /// <param name="sourceCode"></param>
        /// <param name="fixerName"></param>
        /// <param name="fixDate"></param>
        /// <param name="fixerComment"></param>
        /// <param name="commandString"></param>
        public void updateRecord(String sourceCode, String fixerName, String fixDate, String fixerComment, String commandString)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@sourceCode", sourceCode);
            command.Parameters.AddWithValue("@fixerName", fixerName);
            command.Parameters.AddWithValue("@fixDate", fixDate);
            command.Parameters.AddWithValue("@fixerComment", fixerComment);
            command.ExecuteNonQuery();
            
        }

        /// <summary>
        /// Button to archive the bug entered by the developer
        /// Runs if all applicable data field are entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void archiveBugsButton_Click(object sender, EventArgs e)
        {

            if (chosenBugIDBox.Text != String.Empty && editSourceCodeTextBox.Text != String.Empty && fixerNameTextBox.Text != String.Empty && fixDateTextBox.Text != String.Empty && commentTextBox.Text != String.Empty)
            {

                String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";

                String commandString = "UPDATE bugTrackingTable SET sourceCode = @sourceCode, fixerName = @fixerName, fixDate = @fixDate, fixerComment = @fixerComment WHERE id = " + chosenBugIDBox.Text;
                updateRecord(editSourceCodeTextBox.Text, fixerNameTextBox.Text, fixDateTextBox.Text, commentTextBox.Text, commandString); // Updates the Bug Tracking table with source code, fixer name, fix date and fixer comment

                String archiveQuery = "INSERT INTO archivedBugsTable (appName, symptom, cause, classFile, method, codeBlock, sourceCode, lineNumber, codeAuthor, fixerName, fixDate, fixerComment) SELECT appName, symptom, cause, classFile, method, codeBlock, sourceCode, lineNumber, codeAuthor, fixerName, fixDate, fixerComment FROM bugTrackingTable WHERE id=" + chosenBugIDBox.Text;
                String deleteQuery = "DELETE FROM bugTrackingTable WHERE id = " + chosenBugIDBox.Text;

                using (SqlConnection myConnection = new SqlConnection(connection))
                {

                    myConnection.Open();
                    using (SqlCommand archiveCommand = new SqlCommand(archiveQuery, myConnection))
                    {

                        archiveCommand.ExecuteNonQuery(); // Copies all data from the Bug Tracking Table to the Archived Bugs Table

                    }
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, myConnection))
                    {

                        deleteCommand.ExecuteNonQuery(); // Deletes the data copied from the Bug Tracking Table

                    }
                }

                chosenBugIDBox.Text = String.Empty;
                fixerNameTextBox.Text = String.Empty;
                fixDateTextBox.Text = String.Empty;
                commentTextBox.Text = String.Empty;
                editSourceCodeTextBox.Text = String.Empty;
                chosenBugDisplayBox.Items.Clear();
                sourceCodeWebBrowser.DocumentText = "";

                MessageBox.Show("Bug archived successfully.");

            }
            else
            {

                MessageBox.Show("Please fill out all fields.");

            }
        }

        /// <summary>
        /// Displays the source code formatted correctly to the developer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displaySourceCode_Click(object sender, EventArgs e)
        {

            string colourizedSourceCode = new CodeColorizer().Colorize(editSourceCodeTextBox.Text, Languages.CSharp);

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourizedSourceCode + "</body></html>"); // String to store colour coded code
            sourceCodeWebBrowser.DocumentText = html;

        }

        private void viewArchivedBugsButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            archivedBugsForm ABF = new archivedBugsForm();
            ABF.ShowDialog();

        }
    }

}