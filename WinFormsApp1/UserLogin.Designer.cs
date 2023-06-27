namespace WinFormsApp1
{
    partial class UserLogin
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
            username = new Label();
            usernamebox = new TextBox();
            label1 = new Label();
            passwordBox = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(108, 62);
            username.Name = "username";
            username.Size = new Size(79, 20);
            username.TabIndex = 0;
            username.Text = "User name";
            // 
            // usernamebox
            // 
            usernamebox.Location = new Point(200, 59);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(125, 27);
            usernamebox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 115);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(200, 112);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(125, 27);
            passwordBox.TabIndex = 1;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(200, 167);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 228);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(label1);
            Controls.Add(usernamebox);
            Controls.Add(username);
            Name = "UserLogin";
            Text = "UserLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private TextBox usernamebox;
        private Label label1;
        private TextBox passwordBox;
        private Button loginBtn;
    }
}