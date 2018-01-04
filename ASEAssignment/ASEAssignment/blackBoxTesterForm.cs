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
    public partial class blackBoxTesterForm : Form
    {
        public blackBoxTesterForm()
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
        /// <param name="appName"></param>
        /// <param name="symptom"></param>
        /// <param name="cause"></param>
        /// <param name="commandString"></param>
        public void insertRecord(String appName, String symptom, String cause, String commandString)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\bugTrackingDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();            
            SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@appName", appName);
            command.Parameters.AddWithValue("@symptom", symptom);
            command.Parameters.AddWithValue("@cause", cause);
            command.ExecuteNonQuery();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bugSubmitButton_Click(object sender, EventArgs e)
        {
            if (appNameTextBox.Text != String.Empty && causeOfBugTextBox.Text != String.Empty && symptomTextBox.Text != String.Empty)
            {

                string commandString = "INSERT INTO bugTrackingTable (appName, symptom, cause) Values (@appName, @symptom, @cause)";
                insertRecord(appNameTextBox.Text, symptomTextBox.Text, causeOfBugTextBox.Text, commandString);
                appNameTextBox.Text = String.Empty;
                causeOfBugTextBox.Text = String.Empty;
                symptomTextBox.Text = String.Empty;
                MessageBox.Show("Bug submitted successfully.");

            }
            else
            {

                MessageBox.Show("Please fill out all fields.");

            }
        }
    }
}