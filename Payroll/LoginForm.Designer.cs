namespace Payroll
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            LoginPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            loginButt = new Button();
            label5 = new Label();
            label6 = new Label();
            LoginPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTB
            // 
            usernameTB.BackColor = Color.FromArgb(116, 88, 80);
            usernameTB.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTB.ForeColor = Color.White;
            usernameTB.Location = new Point(220, 78);
            usernameTB.Margin = new Padding(3, 4, 3, 4);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(500, 51);
            usernameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.FromArgb(116, 88, 80);
            passwordTB.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            passwordTB.ForeColor = Color.White;
            passwordTB.Location = new Point(220, 174);
            passwordTB.Margin = new Padding(3, 4, 3, 4);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(500, 51);
            passwordTB.TabIndex = 1;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(230, 231, 232);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Location = new Point(323, 311);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(225, 78);
            LoginPanel.TabIndex = 3;
            LoginPanel.Click += LoginPanel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 20);
            label1.Name = "label1";
            label1.Size = new Size(105, 41);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 55, 64);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(LoginPanel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(usernameTB);
            panel1.Controls.Add(passwordTB);
            panel1.Location = new Point(59, 131);
            panel1.Margin = new Padding(50);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 447);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(58, 78);
            label3.Name = "label3";
            label3.Size = new Size(144, 35);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 186);
            label4.Name = "label4";
            label4.Size = new Size(140, 35);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(335, 11);
            label2.Name = "label2";
            label2.Size = new Size(190, 63);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            // 
            // loginButt
            // 
            loginButt.Location = new Point(889, 593);
            loginButt.Margin = new Padding(3, 4, 3, 4);
            loginButt.Name = "loginButt";
            loginButt.Size = new Size(74, 31);
            loginButt.TabIndex = 2;
            loginButt.Text = "Login";
            loginButt.UseVisualStyleBackColor = true;
            loginButt.Click += loginButt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(382, 46);
            label5.Name = "label5";
            label5.Size = new Size(0, 35);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(333, 30);
            label6.Name = "label6";
            label6.Size = new Size(284, 54);
            label6.TabIndex = 7;
            label6.Text = "Payroll System";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 34);
            ClientSize = new Size(975, 637);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(loginButt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTB;
        private TextBox passwordTB;
        private Panel LoginPanel;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button loginButt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
