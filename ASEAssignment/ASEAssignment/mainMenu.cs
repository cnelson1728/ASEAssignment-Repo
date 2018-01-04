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

        private void blackBoxTesterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            blackBoxTesterForm BBTF = new blackBoxTesterForm();
            BBTF.ShowDialog();
        }

        private void whiteBoxTesterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            whiteBoxTesterForm WBTF = new whiteBoxTesterForm();
            WBTF.ShowDialog();
        }

        private void developerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            developerForm DF = new developerForm();
            DF.ShowDialog();
        }

        private void archivedBugsButton_Click(object sender, EventArgs e)
        {
           this.Hide();
           archivedBugsForm ABF = new archivedBugsForm();
           ABF.ShowDialog();
        }
    }
}