namespace Payroll
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            sidePanel = new Panel();
            welcomeLabel = new Label();
            reportButt = new Button();
            logButt = new Button();
            departmentButt = new Button();
            userButt = new Button();
            dashboardButt = new Button();
            dashPanel = new Panel();
            userPanel = new Panel();
            label1 = new Label();
            userPanelAdd = new Panel();
            cancelButt = new Button();
            clearButt = new Button();
            saveButt = new Button();
            inactiveRadioButt = new RadioButton();
            activeRadioButt = new RadioButton();
            statusLabel = new Label();
            positionComboBox = new ComboBox();
            positionLabel = new Label();
            passTB = new TextBox();
            userNameTB = new TextBox();
            passLabel = new Label();
            userNameLabel = new Label();
            generateCredetialsButt = new Button();
            addressTB = new TextBox();
            emailTB = new TextBox();
            addressLabel = new Label();
            emailLabel = new Label();
            contactNoTB = new TextBox();
            middleNameTB = new TextBox();
            contactNoLabel = new Label();
            middleNameLabel = new Label();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            userPanel3 = new Panel();
            userPanelDataGrid = new Panel();
            addEmpButt = new Button();
            userPanel2 = new Panel();
            roleComboBox = new ComboBox();
            userPanel1 = new Panel();
            userDataGridView = new DataGridView();
            sidePanel.SuspendLayout();
            userPanel.SuspendLayout();
            userPanelAdd.SuspendLayout();
            userPanelDataGrid.SuspendLayout();
            userPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(51, 55, 64);
            sidePanel.BackgroundImage = Properties.Resources.PanelBG;
            sidePanel.BackgroundImageLayout = ImageLayout.Stretch;
            sidePanel.Controls.Add(welcomeLabel);
            sidePanel.Controls.Add(reportButt);
            sidePanel.Controls.Add(logButt);
            sidePanel.Controls.Add(departmentButt);
            sidePanel.Controls.Add(userButt);
            sidePanel.Controls.Add(dashboardButt);
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(273, 782);
            sidePanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(12, 75);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(115, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, ";
            // 
            // reportButt
            // 
            reportButt.BackColor = Color.FromArgb(163, 47, 54);
            reportButt.FlatAppearance.BorderSize = 0;
            reportButt.FlatAppearance.MouseDownBackColor = Color.Black;
            reportButt.FlatAppearance.MouseOverBackColor = Color.Black;
            reportButt.FlatStyle = FlatStyle.Flat;
            reportButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            reportButt.ForeColor = Color.White;
            reportButt.Location = new Point(0, 473);
            reportButt.Name = "reportButt";
            reportButt.Size = new Size(273, 74);
            reportButt.TabIndex = 9;
            reportButt.Text = "Reports";
            reportButt.UseVisualStyleBackColor = false;
            // 
            // logButt
            // 
            logButt.BackColor = Color.FromArgb(163, 47, 54);
            logButt.FlatAppearance.BorderSize = 0;
            logButt.FlatAppearance.MouseDownBackColor = Color.Black;
            logButt.FlatAppearance.MouseOverBackColor = Color.Black;
            logButt.FlatStyle = FlatStyle.Flat;
            logButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logButt.ForeColor = Color.White;
            logButt.Location = new Point(0, 402);
            logButt.Name = "logButt";
            logButt.Size = new Size(273, 74);
            logButt.TabIndex = 8;
            logButt.Text = "Logs";
            logButt.UseVisualStyleBackColor = false;
            // 
            // departmentButt
            // 
            departmentButt.BackColor = Color.FromArgb(163, 47, 54);
            departmentButt.FlatAppearance.BorderSize = 0;
            departmentButt.FlatAppearance.MouseDownBackColor = Color.Black;
            departmentButt.FlatAppearance.MouseOverBackColor = Color.Black;
            departmentButt.FlatStyle = FlatStyle.Flat;
            departmentButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            departmentButt.ForeColor = Color.White;
            departmentButt.Location = new Point(0, 330);
            departmentButt.Name = "departmentButt";
            departmentButt.Size = new Size(273, 74);
            departmentButt.TabIndex = 7;
            departmentButt.Text = "Departments";
            departmentButt.UseVisualStyleBackColor = false;
            // 
            // userButt
            // 
            userButt.BackColor = Color.FromArgb(163, 47, 54);
            userButt.FlatAppearance.BorderSize = 0;
            userButt.FlatAppearance.MouseDownBackColor = Color.Black;
            userButt.FlatAppearance.MouseOverBackColor = Color.Black;
            userButt.FlatStyle = FlatStyle.Flat;
            userButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            userButt.ForeColor = Color.White;
            userButt.Location = new Point(0, 256);
            userButt.Name = "userButt";
            userButt.Size = new Size(273, 74);
            userButt.TabIndex = 6;
            userButt.Text = "User Management";
            userButt.UseVisualStyleBackColor = false;
            userButt.Click += userButt_Click;
            // 
            // dashboardButt
            // 
            dashboardButt.BackColor = Color.FromArgb(163, 47, 54);
            dashboardButt.FlatAppearance.BorderSize = 0;
            dashboardButt.FlatAppearance.MouseDownBackColor = Color.Black;
            dashboardButt.FlatAppearance.MouseOverBackColor = Color.Black;
            dashboardButt.FlatStyle = FlatStyle.Flat;
            dashboardButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dashboardButt.ForeColor = Color.White;
            dashboardButt.Location = new Point(0, 182);
            dashboardButt.Name = "dashboardButt";
            dashboardButt.Size = new Size(273, 74);
            dashboardButt.TabIndex = 5;
            dashboardButt.Text = "Dashboard";
            dashboardButt.UseVisualStyleBackColor = false;
            dashboardButt.Click += dashboardButt_Click;
            // 
            // dashPanel
            // 
            dashPanel.BackColor = Color.FromArgb(224, 224, 224);
            dashPanel.Location = new Point(273, 0);
            dashPanel.Name = "dashPanel";
            dashPanel.Size = new Size(1116, 784);
            dashPanel.TabIndex = 1;
            dashPanel.Visible = false;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.FromArgb(255, 244, 220);
            userPanel.Controls.Add(label1);
            userPanel.Controls.Add(userPanelAdd);
            userPanel.Controls.Add(userPanelDataGrid);
            userPanel.Location = new Point(273, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(1116, 784);
            userPanel.TabIndex = 2;
            userPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "userPanel";
            // 
            // userPanelAdd
            // 
            userPanelAdd.BackColor = Color.White;
            userPanelAdd.Controls.Add(cancelButt);
            userPanelAdd.Controls.Add(clearButt);
            userPanelAdd.Controls.Add(saveButt);
            userPanelAdd.Controls.Add(inactiveRadioButt);
            userPanelAdd.Controls.Add(activeRadioButt);
            userPanelAdd.Controls.Add(statusLabel);
            userPanelAdd.Controls.Add(positionComboBox);
            userPanelAdd.Controls.Add(positionLabel);
            userPanelAdd.Controls.Add(passTB);
            userPanelAdd.Controls.Add(userNameTB);
            userPanelAdd.Controls.Add(passLabel);
            userPanelAdd.Controls.Add(userNameLabel);
            userPanelAdd.Controls.Add(generateCredetialsButt);
            userPanelAdd.Controls.Add(addressTB);
            userPanelAdd.Controls.Add(emailTB);
            userPanelAdd.Controls.Add(addressLabel);
            userPanelAdd.Controls.Add(emailLabel);
            userPanelAdd.Controls.Add(contactNoTB);
            userPanelAdd.Controls.Add(middleNameTB);
            userPanelAdd.Controls.Add(contactNoLabel);
            userPanelAdd.Controls.Add(middleNameLabel);
            userPanelAdd.Controls.Add(firstNameTB);
            userPanelAdd.Controls.Add(lastNameTB);
            userPanelAdd.Controls.Add(firstNameLabel);
            userPanelAdd.Controls.Add(lastNameLabel);
            userPanelAdd.Controls.Add(userPanel3);
            userPanelAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            userPanelAdd.Location = new Point(12, 38);
            userPanelAdd.Name = "userPanelAdd";
            userPanelAdd.Size = new Size(1092, 718);
            userPanelAdd.TabIndex = 2;
            userPanelAdd.Visible = false;
            // 
            // cancelButt
            // 
            cancelButt.BackColor = Color.FromArgb(146, 45, 51);
            cancelButt.FlatStyle = FlatStyle.Flat;
            cancelButt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButt.ForeColor = Color.White;
            cancelButt.Location = new Point(743, 567);
            cancelButt.Name = "cancelButt";
            cancelButt.Size = new Size(261, 55);
            cancelButt.TabIndex = 29;
            cancelButt.Text = "Cancel";
            cancelButt.UseVisualStyleBackColor = false;
            cancelButt.Click += cancelButt_Click;
            // 
            // clearButt
            // 
            clearButt.BackColor = Color.FromArgb(146, 45, 51);
            clearButt.FlatStyle = FlatStyle.Flat;
            clearButt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButt.ForeColor = Color.White;
            clearButt.Location = new Point(418, 567);
            clearButt.Name = "clearButt";
            clearButt.Size = new Size(261, 55);
            clearButt.TabIndex = 28;
            clearButt.Text = "Clear";
            clearButt.UseVisualStyleBackColor = false;
            clearButt.Click += clearButt_Click;
            // 
            // saveButt
            // 
            saveButt.BackColor = Color.FromArgb(146, 45, 51);
            saveButt.FlatStyle = FlatStyle.Flat;
            saveButt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButt.ForeColor = Color.White;
            saveButt.Location = new Point(85, 567);
            saveButt.Name = "saveButt";
            saveButt.Size = new Size(261, 55);
            saveButt.TabIndex = 27;
            saveButt.Text = "Save";
            saveButt.UseVisualStyleBackColor = false;
            saveButt.Click += saveButt_Click;
            // 
            // inactiveRadioButt
            // 
            inactiveRadioButt.AutoSize = true;
            inactiveRadioButt.Location = new Point(258, 425);
            inactiveRadioButt.Name = "inactiveRadioButt";
            inactiveRadioButt.Size = new Size(98, 29);
            inactiveRadioButt.TabIndex = 26;
            inactiveRadioButt.TabStop = true;
            inactiveRadioButt.Text = "Inactive";
            inactiveRadioButt.UseVisualStyleBackColor = true;
            inactiveRadioButt.CheckedChanged += radioButton_CheckedChanged;
            // 
            // activeRadioButt
            // 
            activeRadioButt.AutoSize = true;
            activeRadioButt.Location = new Point(168, 425);
            activeRadioButt.Name = "activeRadioButt";
            activeRadioButt.Size = new Size(84, 29);
            activeRadioButt.TabIndex = 25;
            activeRadioButt.TabStop = true;
            activeRadioButt.Text = "Active";
            activeRadioButt.UseVisualStyleBackColor = true;
            activeRadioButt.CheckedChanged += radioButton_CheckedChanged;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            statusLabel.Location = new Point(73, 427);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(69, 25);
            statusLabel.TabIndex = 24;
            statusLabel.Text = "Status:";
            // 
            // positionComboBox
            // 
            positionComboBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Location = new Point(168, 364);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(320, 33);
            positionComboBox.TabIndex = 23;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            positionLabel.Location = new Point(57, 367);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(85, 25);
            positionLabel.TabIndex = 22;
            positionLabel.Text = "Position:";
            // 
            // passTB
            // 
            passTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            passTB.Location = new Point(733, 259);
            passTB.Name = "passTB";
            passTB.Size = new Size(271, 33);
            passTB.TabIndex = 21;
            // 
            // userNameTB
            // 
            userNameTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            userNameTB.Location = new Point(733, 208);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(271, 33);
            userNameTB.TabIndex = 20;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            passLabel.Location = new Point(594, 262);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(96, 25);
            passLabel.TabIndex = 19;
            passLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            userNameLabel.Location = new Point(594, 211);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(112, 25);
            userNameLabel.TabIndex = 18;
            userNameLabel.Text = "User Name:";
            // 
            // generateCredetialsButt
            // 
            generateCredetialsButt.BackColor = Color.FromArgb(146, 45, 51);
            generateCredetialsButt.FlatStyle = FlatStyle.Flat;
            generateCredetialsButt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateCredetialsButt.ForeColor = Color.White;
            generateCredetialsButt.Location = new Point(800, 311);
            generateCredetialsButt.Name = "generateCredetialsButt";
            generateCredetialsButt.Size = new Size(204, 36);
            generateCredetialsButt.TabIndex = 17;
            generateCredetialsButt.Text = "Generate Random Credentials";
            generateCredetialsButt.UseVisualStyleBackColor = false;
            generateCredetialsButt.Click += generateCredetials_Click;
            // 
            // addressTB
            // 
            addressTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            addressTB.Location = new Point(733, 154);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(271, 33);
            addressTB.TabIndex = 14;
            // 
            // emailTB
            // 
            emailTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            emailTB.Location = new Point(733, 103);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(271, 33);
            emailTB.TabIndex = 13;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            addressLabel.Location = new Point(594, 162);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(85, 25);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            emailLabel.Location = new Point(594, 111);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(64, 25);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // contactNoTB
            // 
            contactNoTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            contactNoTB.Location = new Point(217, 259);
            contactNoTB.Name = "contactNoTB";
            contactNoTB.Size = new Size(271, 33);
            contactNoTB.TabIndex = 10;
            // 
            // middleNameTB
            // 
            middleNameTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            middleNameTB.Location = new Point(217, 208);
            middleNameTB.Name = "middleNameTB";
            middleNameTB.Size = new Size(271, 33);
            middleNameTB.TabIndex = 9;
            // 
            // contactNoLabel
            // 
            contactNoLabel.AutoSize = true;
            contactNoLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            contactNoLabel.Location = new Point(57, 262);
            contactNoLabel.Name = "contactNoLabel";
            contactNoLabel.Size = new Size(115, 25);
            contactNoLabel.TabIndex = 8;
            contactNoLabel.Text = "Contact No:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            middleNameLabel.Location = new Point(57, 211);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(134, 25);
            middleNameLabel.TabIndex = 7;
            middleNameLabel.Text = "Middle Name:";
            // 
            // firstNameTB
            // 
            firstNameTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            firstNameTB.Location = new Point(217, 159);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(271, 33);
            firstNameTB.TabIndex = 6;
            // 
            // lastNameTB
            // 
            lastNameTB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lastNameTB.Location = new Point(217, 108);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(271, 33);
            lastNameTB.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            firstNameLabel.Location = new Point(57, 162);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(111, 25);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lastNameLabel.Location = new Point(57, 111);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(108, 25);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // userPanel3
            // 
            userPanel3.BackgroundImage = Properties.Resources.PanelBG;
            userPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            userPanel3.Location = new Point(0, 0);
            userPanel3.Name = "userPanel3";
            userPanel3.Size = new Size(1092, 67);
            userPanel3.TabIndex = 2;
            // 
            // userPanelDataGrid
            // 
            userPanelDataGrid.BackColor = Color.White;
            userPanelDataGrid.Controls.Add(addEmpButt);
            userPanelDataGrid.Controls.Add(userPanel2);
            userPanelDataGrid.Controls.Add(userPanel1);
            userPanelDataGrid.Controls.Add(userDataGridView);
            userPanelDataGrid.Location = new Point(12, 38);
            userPanelDataGrid.Name = "userPanelDataGrid";
            userPanelDataGrid.Size = new Size(1092, 721);
            userPanelDataGrid.TabIndex = 1;
            // 
            // addEmpButt
            // 
            addEmpButt.BackColor = Color.FromArgb(146, 45, 51);
            addEmpButt.FlatStyle = FlatStyle.Flat;
            addEmpButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addEmpButt.ForeColor = Color.White;
            addEmpButt.Location = new Point(21, 111);
            addEmpButt.Name = "addEmpButt";
            addEmpButt.Size = new Size(202, 50);
            addEmpButt.TabIndex = 3;
            addEmpButt.Text = "Add Employee";
            addEmpButt.UseVisualStyleBackColor = false;
            addEmpButt.Click += addEmpButt_Click;
            // 
            // userPanel2
            // 
            userPanel2.BackgroundImage = Properties.Resources.PanelBG;
            userPanel2.BackgroundImageLayout = ImageLayout.Center;
            userPanel2.Controls.Add(roleComboBox);
            userPanel2.Location = new Point(450, 93);
            userPanel2.Name = "userPanel2";
            userPanel2.Size = new Size(619, 77);
            userPanel2.TabIndex = 2;
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleComboBox.Location = new Point(384, 21);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(220, 38);
            roleComboBox.TabIndex = 0;
            roleComboBox.Tag = "";
            roleComboBox.SelectionChangeCommitted += roleComboBox_SelectedIndexChanged;
            // 
            // userPanel1
            // 
            userPanel1.BackgroundImage = Properties.Resources.PanelBG;
            userPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            userPanel1.Location = new Point(0, 0);
            userPanel1.Name = "userPanel1";
            userPanel1.Size = new Size(1092, 67);
            userPanel1.TabIndex = 1;
            // 
            // userDataGridView
            // 
            userDataGridView.AllowUserToAddRows = false;
            userDataGridView.AllowUserToDeleteRows = false;
            userDataGridView.AllowUserToResizeColumns = false;
            userDataGridView.AllowUserToResizeRows = false;
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            userDataGridView.BackgroundColor = Color.FromArgb(146, 45, 51);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(146, 45, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(179, 79, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 209, 211);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(146, 45, 51);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(179, 79, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 209, 211);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            userDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            userDataGridView.EnableHeadersVisualStyles = false;
            userDataGridView.GridColor = Color.White;
            userDataGridView.Location = new Point(0, 190);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(146, 45, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(179, 79, 84);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 209, 211);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            userDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            userDataGridView.RowHeadersVisible = false;
            userDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            userDataGridView.Size = new Size(1092, 371);
            userDataGridView.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 34);
            ClientSize = new Size(1389, 782);
            Controls.Add(sidePanel);
            Controls.Add(userPanel);
            Controls.Add(dashPanel);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            FormClosed += AdminForm_FormClosed;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            userPanelAdd.ResumeLayout(false);
            userPanelAdd.PerformLayout();
            userPanelDataGrid.ResumeLayout(false);
            userPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button userButt;
        private Button dashboardButt;
        private Button departmentButt;
        private Panel dashPanel;
        private Panel userPanel;
        private Button logButt;
        private Button reportButt;
        private Label welcomeLabel;
        private Label label1;
        private Panel userPanelDataGrid;
        private DataGridView userDataGridView;
        private Panel userPanel2;
        private Panel userPanel1;
        private ComboBox roleComboBox;
        private Button addEmpButt;
        private Panel userPanelAdd;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Panel userPanel3;
        private TextBox passwordTB;
        private TextBox addressTB;
        private TextBox emailTB;
        private Label addressLabel;
        private Label emailLabel;
        private TextBox contactNoTB;
        private TextBox middleNameTB;
        private Label contactNoLabel;
        private Label middleNameLabel;
        private Button generateCredetialsButt;
        private TextBox passTB;
        private TextBox userNameTB;
        private Label passLabel;
        private Label userNameLabel;
        private ComboBox positionComboBox;
        private Label positionLabel;
        private RadioButton inactiveRadioButt;
        private RadioButton activeRadioButt;
        private Label statusLabel;
        private Button cancelButt;
        private Button clearButt;
        private Button saveButt;
    }
}