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
    }
}
