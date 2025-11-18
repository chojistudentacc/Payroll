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
            loginButt = new Button();
            SuspendLayout();
            // 
            // usernameTB
            // 
            usernameTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTB.Location = new Point(331, 215);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(211, 29);
            usernameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            passwordTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTB.Location = new Point(331, 250);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(211, 29);
            passwordTB.TabIndex = 1;
            // 
            // loginButt
            // 
            loginButt.Location = new Point(367, 296);
            loginButt.Name = "loginButt";
            loginButt.Size = new Size(148, 55);
            loginButt.TabIndex = 2;
            loginButt.Text = "Login";
            loginButt.UseVisualStyleBackColor = true;
            loginButt.Click += loginButt_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButt);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginButt;
    }
}
