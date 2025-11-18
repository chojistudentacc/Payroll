namespace Payroll
{
    partial class employeeDashboard
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
            components = new System.ComponentModel.Container();
            currentDateLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            netPayLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            attendanceAbsentLabel = new Label();
            attendancePresentLabel = new Label();
            label4 = new Label();
            panel3 = new Panel();
            nextPayDateLabel = new Label();
            label6 = new Label();
            panel4 = new Panel();
            leaveBalanceLabel = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // currentDateLabel
            // 
            currentDateLabel.AutoSize = true;
            currentDateLabel.BackColor = Color.FromArgb(146, 149, 154);
            currentDateLabel.Font = new Font("Segoe UI", 11F);
            currentDateLabel.ForeColor = Color.White;
            currentDateLabel.Location = new Point(482, 9);
            currentDateLabel.Name = "currentDateLabel";
            currentDateLabel.Size = new Size(113, 20);
            currentDateLabel.TabIndex = 0;
            currentDateLabel.Text = "CURRENT DATE";
            currentDateLabel.Click += currentDateLabel_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(146, 149, 154);
            panel1.Controls.Add(netPayLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 101);
            panel1.TabIndex = 1;
            // 
            // netPayLabel
            // 
            netPayLabel.AutoSize = true;
            netPayLabel.Font = new Font("Segoe UI", 11F);
            netPayLabel.ForeColor = Color.White;
            netPayLabel.Location = new Point(13, 44);
            netPayLabel.Name = "netPayLabel";
            netPayLabel.Size = new Size(118, 20);
            netPayLabel.TabIndex = 1;
            netPayLabel.Text = "net amount here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 11);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Net Pay";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(146, 149, 154);
            panel2.Controls.Add(attendanceAbsentLabel);
            panel2.Controls.Add(attendancePresentLabel);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(166, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 101);
            panel2.TabIndex = 2;
            // 
            // attendanceAbsentLabel
            // 
            attendanceAbsentLabel.AutoSize = true;
            attendanceAbsentLabel.Font = new Font("Segoe UI", 11F);
            attendanceAbsentLabel.ForeColor = Color.White;
            attendanceAbsentLabel.Location = new Point(17, 62);
            attendanceAbsentLabel.Name = "attendanceAbsentLabel";
            attendanceAbsentLabel.Size = new Size(55, 20);
            attendanceAbsentLabel.TabIndex = 2;
            attendanceAbsentLabel.Text = "Absent";
            // 
            // attendancePresentLabel
            // 
            attendancePresentLabel.AutoSize = true;
            attendancePresentLabel.Font = new Font("Segoe UI", 11F);
            attendancePresentLabel.ForeColor = Color.White;
            attendancePresentLabel.Location = new Point(15, 40);
            attendancePresentLabel.Name = "attendancePresentLabel";
            attendancePresentLabel.Size = new Size(57, 20);
            attendancePresentLabel.TabIndex = 1;
            attendancePresentLabel.Text = "Present";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 11);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Attendance";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(146, 149, 154);
            panel3.Controls.Add(nextPayDateLabel);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(457, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 101);
            panel3.TabIndex = 4;
            // 
            // nextPayDateLabel
            // 
            nextPayDateLabel.AutoSize = true;
            nextPayDateLabel.Font = new Font("Segoe UI", 11F);
            nextPayDateLabel.ForeColor = Color.White;
            nextPayDateLabel.Location = new Point(19, 44);
            nextPayDateLabel.Name = "nextPayDateLabel";
            nextPayDateLabel.Size = new Size(100, 20);
            nextPayDateLabel.TabIndex = 1;
            nextPayDateLabel.Text = "pay date here";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 11);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 0;
            label6.Text = "Next Pay Date";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(146, 149, 154);
            panel4.Controls.Add(leaveBalanceLabel);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(311, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 101);
            panel4.TabIndex = 3;
            // 
            // leaveBalanceLabel
            // 
            leaveBalanceLabel.AutoSize = true;
            leaveBalanceLabel.Font = new Font("Segoe UI", 11F);
            leaveBalanceLabel.ForeColor = Color.White;
            leaveBalanceLabel.Location = new Point(26, 44);
            leaveBalanceLabel.Name = "leaveBalanceLabel";
            leaveBalanceLabel.Size = new Size(80, 20);
            leaveBalanceLabel.TabIndex = 1;
            leaveBalanceLabel.Text = "Remaining";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 11);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 0;
            label8.Text = "Leave Balance";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(20, 171);
            panel5.Name = "panel5";
            panel5.Size = new Size(577, 101);
            panel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(224, 9);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "Latest Payslip";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label7);
            panel6.Location = new Point(20, 297);
            panel6.Name = "panel6";
            panel6.Size = new Size(577, 101);
            panel6.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(212, 9);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 0;
            label7.Text = "Announcements";
            // 
            // employeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 34);
            ClientSize = new Size(632, 422);
            ControlBox = false;
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(currentDateLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employeeDashboard";
            Text = "employeeDashboard";
            WindowState = FormWindowState.Maximized;
            Load += employeeDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentDateLabel;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label netPayLabel;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label nextPayDateLabel;
        private Label label6;
        private Panel panel4;
        private Label leaveBalanceLabel;
        private Label label8;
        private Label attendancePresentLabel;
        private Label label4;
        private Label attendanceAbsentLabel;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Label label7;
    }
}