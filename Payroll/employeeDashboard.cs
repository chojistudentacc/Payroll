using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class employeeDashboard : Form
    {
        public employeeDashboard()
        {
            InitializeComponent();
            currentDateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void employeeDashboard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void currentDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
