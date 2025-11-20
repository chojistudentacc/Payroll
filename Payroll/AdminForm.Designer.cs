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
            sidePanel = new Panel();
            employeeButt = new Button();
            userButt = new Button();
            dashboardButt = new Button();
            dashPanel = new Panel();
            userPanel = new Panel();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(51, 55, 64);
            sidePanel.Controls.Add(employeeButt);
            sidePanel.Controls.Add(userButt);
            sidePanel.Controls.Add(dashboardButt);
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(273, 782);
            sidePanel.TabIndex = 0;
            // 
            // employeeButt
            // 
            employeeButt.BackColor = Color.FromArgb(77, 82, 93);
            employeeButt.FlatAppearance.BorderSize = 0;
            employeeButt.FlatAppearance.MouseDownBackColor = Color.Black;
            employeeButt.FlatAppearance.MouseOverBackColor = Color.Black;
            employeeButt.FlatStyle = FlatStyle.Flat;
            employeeButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            employeeButt.ForeColor = Color.White;
            employeeButt.Location = new Point(0, 297);
            employeeButt.Name = "employeeButt";
            employeeButt.Size = new Size(273, 74);
            employeeButt.TabIndex = 7;
            employeeButt.Text = "Employee";
            employeeButt.UseVisualStyleBackColor = false;
            // 
            // userButt
            // 
            userButt.BackColor = Color.FromArgb(77, 82, 93);
            userButt.FlatAppearance.BorderSize = 0;
            userButt.FlatAppearance.MouseDownBackColor = Color.Black;
            userButt.FlatAppearance.MouseOverBackColor = Color.Black;
            userButt.FlatStyle = FlatStyle.Flat;
            userButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            userButt.ForeColor = Color.White;
            userButt.Location = new Point(0, 223);
            userButt.Name = "userButt";
            userButt.Size = new Size(273, 74);
            userButt.TabIndex = 6;
            userButt.Text = "User Management";
            userButt.UseVisualStyleBackColor = false;
            userButt.Click += userButt_Click;
            // 
            // dashboardButt
            // 
            dashboardButt.BackColor = Color.FromArgb(77, 82, 93);
            dashboardButt.FlatAppearance.BorderSize = 0;
            dashboardButt.FlatAppearance.MouseDownBackColor = Color.Black;
            dashboardButt.FlatAppearance.MouseOverBackColor = Color.Black;
            dashboardButt.FlatStyle = FlatStyle.Flat;
            dashboardButt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dashboardButt.ForeColor = Color.White;
            dashboardButt.Location = new Point(0, 149);
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
            userPanel.BackColor = Color.FromArgb(255, 192, 192);
            userPanel.Location = new Point(273, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(1116, 784);
            userPanel.TabIndex = 2;
            userPanel.Visible = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 34);
            ClientSize = new Size(1389, 782);
            Controls.Add(sidePanel);
            Controls.Add(dashPanel);
            Controls.Add(userPanel);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            FormClosed += AdminForm_FormClosed;
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button userButt;
        private Button dashboardButt;
        private Button employeeButt;
        private Panel dashPanel;
        private Panel userPanel;
    }
}