namespace OnlineStore.Presentation
{
    partial class AddUser
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
            nameLbl = new Label();
            textBox1 = new TextBox();
            emailLbl = new Label();
            textBox2 = new TextBox();
            passwordLbl = new Label();
            textBox3 = new TextBox();
            saveBtn = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(54, 32);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(49, 20);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 1;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(54, 137);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(46, 20);
            emailLbl.TabIndex = 2;
            emailLbl.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 3;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(54, 253);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(70, 20);
            passwordLbl.TabIndex = 4;
            passwordLbl.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 307);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(241, 27);
            textBox3.TabIndex = 5;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(145, 543);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(106, 29);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 374);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "User" });
            comboBox1.Location = new Point(27, 416);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 8;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 602);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Controls.Add(textBox3);
            Controls.Add(passwordLbl);
            Controls.Add(textBox2);
            Controls.Add(emailLbl);
            Controls.Add(textBox1);
            Controls.Add(nameLbl);
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private TextBox textBox1;
        private Label emailLbl;
        private TextBox textBox2;
        private Label passwordLbl;
        private TextBox textBox3;
        private Button saveBtn;
        private Label label1;
        private ComboBox comboBox1;
    }
}