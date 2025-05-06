namespace OnlineStore.Presentation
{
    partial class Users
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
            usersDataGrid = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            userLbl = new Label();
            updateLbl = new Label();
            deleteLbl = new Label();
            allUsersLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)usersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // usersDataGrid
            // 
            usersDataGrid.BackgroundColor = SystemColors.ActiveCaption;
            usersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGrid.Location = new Point(269, 57);
            usersDataGrid.Name = "usersDataGrid";
            usersDataGrid.RowHeadersWidth = 51;
            usersDataGrid.Size = new Size(556, 414);
            usersDataGrid.TabIndex = 0;
            usersDataGrid.SelectionChanged += usersDataGrid_SelectionChanged;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LimeGreen;
            addBtn.Location = new Point(87, 120);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Orange;
            updateBtn.Location = new Point(87, 233);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Tomato;
            deleteBtn.Location = new Point(87, 352);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Remove";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Location = new Point(87, 82);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(85, 20);
            userLbl.TabIndex = 4;
            userLbl.Text = "Create User";
            // 
            // updateLbl
            // 
            updateLbl.AutoSize = true;
            updateLbl.Location = new Point(87, 198);
            updateLbl.Name = "updateLbl";
            updateLbl.Size = new Size(89, 20);
            updateLbl.TabIndex = 5;
            updateLbl.Text = "Modify User";
            // 
            // deleteLbl
            // 
            deleteLbl.AutoSize = true;
            deleteLbl.Location = new Point(87, 315);
            deleteLbl.Name = "deleteLbl";
            deleteLbl.Size = new Size(86, 20);
            deleteLbl.TabIndex = 6;
            deleteLbl.Text = "Delete User";
            // 
            // allUsersLbl
            // 
            allUsersLbl.AutoSize = true;
            allUsersLbl.Location = new Point(475, 20);
            allUsersLbl.Name = "allUsersLbl";
            allUsersLbl.Size = new Size(66, 20);
            allUsersLbl.TabIndex = 7;
            allUsersLbl.Text = "All Users";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 503);
            Controls.Add(allUsersLbl);
            Controls.Add(deleteLbl);
            Controls.Add(updateLbl);
            Controls.Add(userLbl);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(usersDataGrid);
            Name = "Users";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)usersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usersDataGrid;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Label userLbl;
        private Label updateLbl;
        private Label deleteLbl;
        private Label allUsersLbl;
    }
}