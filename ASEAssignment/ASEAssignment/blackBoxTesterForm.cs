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
        public void insertRecord(String appName, String symptom, String cause, String commandString)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\c3418895\Documents\bugTrackingDatabase.mdf;Integrated Security = True; Connect Timeout = 30; MultipleActiveResultSets=true");
            connection.Open();            
            SqlCommand command = new SqlCommand(commandString, connection);
            command.Parameters.AddWithValue("@appName", appName);
            command.Parameters.AddWithValue("@symptom", symptom);
            command.Parameters.AddWithValue("@cause", cause);
            command.ExecuteNonQuery();
            //command.Parameters.AddWithValue("@classFile", classFile);
           // command.Parameters.AddWithValue("@method", method);
           // command.Parameters.AddWithValue("@codeBlock", codeBlock);
           // command.Parameters.AddWithValue("@lineNumber", lineNumber);
            
        }
   
        private void bugSubmitButton_Click(object sender, EventArgs e)
        {
            string commandString = "INSERT INTO bugTrackingTable (appName, symptom, cause) Values (@appName, @symptom, @cause)";
            insertRecord(appNameTextBox.Text, symptomTextBox.Text, causeOfBugTextBox.Text, commandString);

        }
    }
}