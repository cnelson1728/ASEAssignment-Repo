using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEAssignment
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes uesr to Black Box Tester Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blackBoxTesterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            blackBoxTesterForm BBTF = new blackBoxTesterForm();
            BBTF.ShowDialog();
        }

        /// <summary>
        /// Takes user to White Box Tester Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void whiteBoxTesterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            whiteBoxTesterForm WBTF = new whiteBoxTesterForm();
            WBTF.ShowDialog();
        }

        /// <summary>
        /// Takes user to Developer Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void developerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            developerForm DF = new developerForm();
            DF.ShowDialog();
        }

        /// <summary>
        /// Takes user to Archived Bugs Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void archivedBugsButton_Click(object sender, EventArgs e)
        {
           this.Hide();
           archivedBugsForm ABF = new archivedBugsForm();
           ABF.ShowDialog();
        }
    }
}