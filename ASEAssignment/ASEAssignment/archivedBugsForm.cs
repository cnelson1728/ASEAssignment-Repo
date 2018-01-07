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
        /// <summary>
        /// Displays all the current bugs in the Archived Bugs Table
        /// </summary>
        private void displayData()
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
                archivedBugsListBox.Items.Add("Fixer Name: " + myDataReader["fixerName"].ToString());
                archivedBugsListBox.Items.Add("Fix Date: " + myDataReader["fixDate"].ToString());
                archivedBugsListBox.Items.Add("Fixer Comment: " + myDataReader["fixerComment"].ToString());
                archivedBugsListBox.Items.Add("");

            }
        }

        public archivedBugsForm()
        {

            InitializeComponent();
            displayData();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            mainMenu MM = new mainMenu();
            MM.ShowDialog();

        }
        

        /// <summary>
        /// Deletes a bug from the Archived Bugs Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBugButton_Click(object sender, EventArgs e)
        {
            displaySourceCode.Text = String.Empty; // Clears the source code of the deleted bug

            try
            {
                String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";


                if (deleteBugID.Text != String.Empty && archivedBugsListBox.Items.Contains("Application ID: " + deleteBugID.Text)) // Deletes if there is a record matching the ID that the user has entered
                {

                    String deleteQuery = "DELETE FROM archivedBugsTable WHERE id=" + deleteBugID.Text;

                    using (SqlConnection mySqlConnection = new SqlConnection(connection))
                    {
                        mySqlConnection.Open();
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, mySqlConnection))
                        {

                            deleteCommand.ExecuteNonQuery();
                            mySqlConnection.Close();
                            MessageBox.Show("Bug deleted successfully", "Success");
                            deleteBugID.Text = String.Empty;

                        }
                    }

                displayData();

                }
                else
                {

                    MessageBox.Show("Please enter a valid Bug ID.", "Alert");

                }                
            }
            catch(Exception exception) // Catches an exception if the user enters a string
            {

                MessageBox.Show("Please enter a valid Bug ID.", "Alert");

            }
        }

        /// <summary>
        /// Displays the source code for the bug ID that the user has entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displaySourceCodeButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (deleteBugID.Text != String.Empty)
                {

                    displaySourceCode.Text = String.Empty;

                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                    String displaySourceCodeCmd = "SELECT * FROM archivedBugsTable WHERE id=" + deleteBugID.Text;
                    SqlCommand command = new SqlCommand(displaySourceCodeCmd, connection);
                    connection.Open();

                    SqlDataReader mySqlDataReader = command.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {

                        displaySourceCode.Text = mySqlDataReader["sourceCode"].ToString();

                    }

                }
                else
                {

                    MessageBox.Show("Please enter a Bug ID to display.", "Alert");

                }

            }
            catch(Exception exception)
            {

                MessageBox.Show("Please enter a valid Bug ID.", "Alert");

            }


        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            loginPage LP = new loginPage();
            LP.ShowDialog();

        }

        private void reOpenBugButton_Click(object sender, EventArgs e)
        {

            String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            String archiveQuery = "INSERT INTO  bugTrackingTable (appName, symptom, cause, classFile, method, codeBlock, sourceCode, lineNumber, codeAuthor, fixerName, fixDate, fixerComment) SELECT appName, symptom, cause, classFile, method, codeBlock, sourceCode, lineNumber, codeAuthor, fixerName, fixDate, fixerComment FROM archivedBugsTable WHERE id=" + deleteBugID.Text;
            String deleteQuery = "DELETE FROM archivedBugsTable WHERE id = " + deleteBugID.Text;

            using (SqlConnection myConnection = new SqlConnection(connection))
            {

                myConnection.Open();
                using (SqlCommand archiveCommand = new SqlCommand(archiveQuery, myConnection))
                {

                    archiveCommand.ExecuteNonQuery(); // Copies all data from the Archived Bugs Table to the Bug Tracking Table

                }
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, myConnection))
                {

                    deleteCommand.ExecuteNonQuery(); // 

                }
            }

            
            MessageBox.Show("Bug Re-Opened Successfully", "Success");
            displayData();
            deleteBugID.Text = String.Empty;
        }
    }
}