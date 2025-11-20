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
    public partial class AdminForm : Form
    {
        LoginForm login;

        public AdminForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Visible = true;
        }

        private void hideallPanels()
        {
            dashPanel.Visible = false;
            userPanel.Visible = false;
        }

        private void dashboardButt_Click(object sender, EventArgs e)
        {
            hideallPanels();
            dashPanel.Visible = true;
        }

        private void userButt_Click(object sender, EventArgs e)
        {
            hideallPanels();
            userPanel.Visible = true;
        }

    }
}
