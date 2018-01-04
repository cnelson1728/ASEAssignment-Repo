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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="classFile"></param>
        /// <param name="method"></param>
        /// <param name="codeBlock"></param>
        /// <param name="sourceCode"></param>
        /// <param name="lineNumber"></param>
        /// <param name="codeAuthor"></param>
        /// <param name="commandString"></param>
        public void updateRecord(String classFile, String method, String codeBlock, String sourceCode, int lineNumber, String codeAuthor, String commandString)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@classFile", classFile);
            command.Parameters.AddWithValue("@method", method);
            command.Parameters.AddWithValue("@codeBlock", codeBlock);
            command.Parameters.AddWithValue("@sourceCode", sourceCode);
            command.Parameters.AddWithValue("@lineNumber", lineNumber);
            command.Parameters.AddWithValue("@codeAuthor", codeAuthor);
            command.ExecuteNonQuery();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateBugButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(appNameTextBox.Text != String.Empty && bugDescriptionTextBox.Text != String.Empty && bugCauseTextBox.Text != String.Empty && classFileTextBox.Text != String.Empty && methodTextBox.Text != String.Empty && codeBlockTextBox.Text != String.Empty && sourceCodeTextBox.Text != String.Empty && lineNumberTextBox.Text != String. Empty && codeAuthorTextBox.Text != String.Empty)
                {
                    string commandString = "UPDATE bugTrackingTable SET classFile = @classFile,  method = @method, codeBlock = @codeBlock, sourceCode = @sourceCode, lineNumber = @lineNumber, codeAuthor = @codeAuthor WHERE id=" + bugIDtextBox.Text;
                    updateRecord(classFileTextBox.Text, methodTextBox.Text, codeBlockTextBox.Text, sourceCodeTextBox.Text, Int32.Parse(lineNumberTextBox.Text), codeAuthorTextBox.Text, commandString);

                    bugIDtextBox.Text = String.Empty;
                    appNameTextBox.Text = String.Empty;
                    bugDescriptionTextBox.Text = String.Empty;
                    bugCauseTextBox.Text = String.Empty;
                    classFileTextBox.Text = String.Empty;
                    methodTextBox.Text = String.Empty;
                    codeBlockTextBox.Text = String.Empty;
                    sourceCodeTextBox.Text = String.Empty;
                    lineNumberTextBox.Text = String.Empty;
                    codeAuthorTextBox.Text = String.Empty;

                    MessageBox.Show("Bug updated successfully.");

                }
                else
                {

                    MessageBox.Show("Please fill out all fields.");

                }

            }
            catch (FormatException intExpected)
            {

                lineNumberTextBox.Text = String.Empty;
                MessageBox.Show("Please enter an integer for Line Number.");

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayBugsButton_Click(object sender, EventArgs e)
        {
            bugListBox.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            String displayQuery = "SELECT * FROM bugTrackingTable";
            SqlCommand command = new SqlCommand(displayQuery, connection);
            connection.Open();
            SqlDataReader myDataReader = command.ExecuteReader();

            while (myDataReader.Read())
            {

                bugListBox.Items.Add("Bug ID: " + myDataReader["ID"].ToString());
                bugListBox.Items.Add("Application Name: " + myDataReader["appName"].ToString());
                bugListBox.Items.Add("Bug Description: " + myDataReader["symptom"].ToString());
                bugListBox.Items.Add("");

            }
        }

        private void clearBugsButton_Click(object sender, EventArgs e)
        {
            bugListBox.Items.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBugButton_Click(object sender, EventArgs e)
        {
            bugIDtextBox.Text = String.Empty;
            appNameTextBox.Text = String.Empty;
            bugDescriptionTextBox.Text = String.Empty;
            bugCauseTextBox.Text = String.Empty;
            classFileTextBox.Text = String.Empty;
            methodTextBox.Text = String.Empty;
            codeBlockTextBox.Text = String.Empty;
            lineNumberTextBox.Text = String.Empty;
            codeAuthorTextBox.Text = String.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pullBugButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bugIDtextBox.Text != String.Empty)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                    String pullBugCmd = "SELECT * FROM bugTrackingTable WHERE id=" + bugIDtextBox.Text;
                    SqlCommand command = new SqlCommand(pullBugCmd, connection);

                    connection.Open();

                    SqlDataReader mySqlDataReader = command.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {

                        appNameTextBox.Text = (mySqlDataReader["appName"].ToString());
                        bugDescriptionTextBox.Text = (mySqlDataReader["symptom"].ToString());
                        bugCauseTextBox.Text = (mySqlDataReader["cause"].ToString());
                        classFileTextBox.Text = (mySqlDataReader["classFile"].ToString());
                        methodTextBox.Text = (mySqlDataReader["method"].ToString());
                        codeBlockTextBox.Text = (mySqlDataReader["codeBlock"].ToString());
                        lineNumberTextBox.Text = (mySqlDataReader["lineNumber"].ToString());
                        codeAuthorTextBox.Text = (mySqlDataReader["codeAuthor"].ToString());


                    }
                    if(appNameTextBox.Text == String.Empty)
                    {

                        MessageBox.Show("No matching records. Please enter a valid Bug ID.");
                        bugIDtextBox.Text = String.Empty;

                    }
                }
                else
                {

                    MessageBox.Show("Please enter a Bug ID.");

                }
            }
            catch(Exception exception)
            {

                bugIDtextBox.Text = String.Empty;
                MessageBox.Show("Please enter an integer for Bug ID.");

            }
            
        }
    }
}
