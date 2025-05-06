namespace OnlineStore.Presentation
{
    partial class LogIn
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
            lblEmail = new Label();
            llblPassword = new Label();
            email_txtBox = new TextBox();
            password_txtBox = new TextBox();
            logInBtn = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(119, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // llblPassword
            // 
            llblPassword.AutoSize = true;
            llblPassword.Location = new Point(119, 214);
            llblPassword.Name = "llblPassword";
            llblPassword.Size = new Size(73, 20);
            llblPassword.TabIndex = 1;
            llblPassword.Text = "Password:";
            // 
            // email_txtBox
            // 
            email_txtBox.Location = new Point(235, 128);
            email_txtBox.MaxLength = 100;
            email_txtBox.Name = "email_txtBox";
            email_txtBox.Size = new Size(267, 27);
            email_txtBox.TabIndex = 2;
            // 
            // password_txtBox
            // 
            password_txtBox.Location = new Point(235, 213);
            password_txtBox.MaxLength = 20;
            password_txtBox.Name = "password_txtBox";
            password_txtBox.PasswordChar = '*';
            password_txtBox.Size = new Size(267, 27);
            password_txtBox.TabIndex = 3;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.LightGray;
            logInBtn.Location = new Point(245, 341);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(223, 29);
            logInBtn.TabIndex = 4;
            logInBtn.Text = "LogIn";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click_1;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logInBtn);
            Controls.Add(password_txtBox);
            Controls.Add(email_txtBox);
            Controls.Add(llblPassword);
            Controls.Add(lblEmail);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label llblPassword;
        private TextBox email_txtBox;
        private TextBox password_txtBox;
        private Button logInBtn;
    }
}