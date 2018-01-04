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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
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

                    if (chosenBugDisplayBox.Items.Count == 0)
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
            catch (Exception exception)
            {

                chosenBugIDBox.Text = String.Empty;
                MessageBox.Show("Please enter an integer for Bug ID.");

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBugButton_Click(object sender, EventArgs e)
        {
            if(bugsDisplayBox.Items.Contains("Bug ID: " + chosenBugIDBox.Text))
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void archiveBugsButton_Click(object sender, EventArgs e)
        {
            
            if (chosenBugIDBox.Text != String.Empty && editSourceCodeTextBox.Text != String.Empty && fixerNameTextBox.Text != String.Empty && fixDateTextBox.Text != String.Empty && commentTextBox.Text != String.Empty)
            {
                String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30";

                String commandString = "UPDATE bugTrackingTable SET sourceCode = @sourceCode, fixerName = @fixerName, fixDate = @fixDate, fixerComment = @fixerComment WHERE id = " + chosenBugIDBox.Text;
                updateRecord(editSourceCodeTextBox.Text, fixerNameTextBox.Text, fixDateTextBox.Text, commentTextBox.Text, commandString);

                String archiveQuery = "INSERT INTO archivedBugsTable (appName, symptom, cause, classFile, method, codeBlock, sourceCode, lineNumber, codeAuthor, fixerName, fixDate, fixerComment) SELECT appName, symptom, cause, classFile, method, codeBlock, sourceCode, lineNumber, codeAuthor, fixerName, fixDate, fixerComment FROM bugTrackingTable WHERE id=" + chosenBugIDBox.Text;
                String deleteQuery = "DELETE FROM bugTrackingTable WHERE id = " + chosenBugIDBox.Text;

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displaySourceCode_Click(object sender, EventArgs e)
        {

            string colourizedSourceCode = new CodeColorizer().Colorize(editSourceCodeTextBox.Text, Languages.CSharp);
            
            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            sourceCodeWebBrowser.DocumentText = html;
        
        }
    }
}