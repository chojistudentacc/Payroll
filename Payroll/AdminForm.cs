using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll.Models;

namespace Payroll
{
    public partial class AdminForm : Form
    {
        LoginForm login;
        string userName;
        Repository repo;

        public AdminForm(LoginForm login, string userName)
        {
            InitializeComponent();
            repo = new Repository();
            this.login = login;
            this.userName = userName;
            InitializeSomething();
        }

        private void InitializeSomething()
        {
            welcomeLabel.Text = "Welcome, " + repo.getAdminID(userName);
            roleComboBox.Items.Add("Employee");
            roleComboBox.Items.Add("Human Resources");
            roleComboBox.Items.Add("Accountant");
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

        private void fillDataGridView()
        {
            if (roleComboBox.Text.Equals("Employee"))
            {
                userDataGridView.DataSource = repo.GetAllEmployee();
            }
            else if (roleComboBox.Text.Equals("Accountant"))
            {
                userDataGridView.DataSource = repo.GetAllAccountant();
            }

        }

        private void addEmpButt_Click(object sender, EventArgs e)
        {
            userPanelDataGrid.Visible = false;
            userPanelAdd.Visible = true;
            positionComboBox.Items.Add("Employee");
            positionComboBox.Items.Add("Accountant");
            positionComboBox.Items.Add("Human Resources");
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void generatePassButt_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
            "Previous password data will be permanently lost",
            "Are you sure?",
            MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                Random rand = new Random();
                string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                string random =
                letters[rand.Next(letters.Length)].ToString() +
                rand.Next(0, 10000).ToString("D3");

                passLabel.Text = random;
                passLabel.Visible = true;
                passLabel.Visible = true;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void generateCredetials_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            string randomUser = "user" + rand.Next(0, 1000000).ToString("D6");
            string randomPass = "pass" + rand.Next(0, 1000000).ToString("D6");

            userNameTB.Text = randomUser;
            passTB.Text = randomPass;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == activeRadioButt && activeRadioButt.Checked)
            {
                inactiveRadioButt.Checked = false;
            }
            else if (sender == inactiveRadioButt && inactiveRadioButt.Checked)
            {
                activeRadioButt.Checked = false;
            }
        }

        private void clearButt_Click(object sender, EventArgs e)
        {
            clearCre();
        }

        private void clearCre()
        {
            lastNameTB.Text = "";
            firstNameTB.Text = "";
            middleNameTB.Text = "";
            addressTB.Text = "";
            contactNoTB.Text = "";
            emailTB.Text = "";
            userNameTB.Text = "";
            passTB.Text = "";
            positionComboBox.Text = "";
            activeRadioButt.Checked = false;
            inactiveRadioButt.Checked = false;
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            if (lastNameTB.Text != "" &&
                firstNameTB.Text != "" &&
                middleNameTB.Text != "" &&
                addressTB.Text != "" &&
                contactNoTB.Text != "" &&
                emailTB.Text != "" &&
                userNameTB.Text != "" &&
                passTB.Text != "" &&
                positionComboBox.Text != "" &&
                (activeRadioButt.Checked || inactiveRadioButt.Checked))
            {
                if (positionComboBox.Text.Equals("Employee"))
                {
                    Employee emp = new Employee();
                    emp.LastName = lastNameTB.Text;
                    emp.FirstName = firstNameTB.Text;
                    emp.MiddleName = middleNameTB.Text;
                    emp.Address = addressTB.Text;
                    emp.ContactNum = long.Parse(contactNoTB.Text);
                    emp.Email = emailTB.Text;
                    emp.UserName = userNameTB.Text;
                    emp.Password = passTB.Text;
                    emp.Status = activeRadioButt.Checked ? "Active" : "Inactive";
                    repo.AddEmployee(emp);

                    clearCre();
                    userPanelDataGrid.Visible = true;
                    userPanelAdd.Visible = false;
                    fillDataGridView();
                }
                else if (positionComboBox.Text.Equals("Accountant"))
                {
                    Accountant acc = new Accountant();
                    acc.LastName = lastNameTB.Text;
                    acc.FirstName = firstNameTB.Text;
                    acc.MiddleName = middleNameTB.Text;
                    acc.Address = addressTB.Text;
                    acc.ContactNum = long.Parse(contactNoTB.Text);
                    acc.Email = emailTB.Text;
                    acc.UserName = userNameTB.Text;
                    acc.Password = passTB.Text;
                    acc.Status = activeRadioButt.Checked ? "Active" : "Inactive";
                    repo.AddAccountant(acc);

                    clearCre();
                    userPanelDataGrid.Visible = true;
                    userPanelAdd.Visible = false;
                    fillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields and select a status.");
            }
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            clearCre();
            userPanelDataGrid.Visible = true;
            userPanelAdd.Visible = false;
            fillDataGridView();
        }
    }
}
