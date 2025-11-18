using System;
using System.Windows.Forms;

namespace Payroll
{
    public partial class LoginForm : Form
    {
        private string userName;
        private string password;
        Repository repo;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButt_Click(object sender, EventArgs e)
        {

            userName = usernameTB.Text.Trim();
            password = passwordTB.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            //repo = new Repository();
            //string userType = repo.AuthenticateUser(userName, password);

            if (userName == "employee")
            {
                MessageBox.Show("Employee");
                EmployeeForm empForm = new EmployeeForm();
                empForm.Show();
                this.Hide();
            }
            else if (userName == "accountant")
            {
                MessageBox.Show("Accountant");
                AccountantForm accForm = new AccountantForm(userName);
                accForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}