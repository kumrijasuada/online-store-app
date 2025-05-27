namespace OnlineStore.Presentation
{
    partial class Categories
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
            categoryDataGrid = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // categoryDataGrid
            // 
            categoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGrid.Location = new Point(234, 77);
            categoryDataGrid.Name = "categoryDataGrid";
            categoryDataGrid.RowHeadersWidth = 51;
            categoryDataGrid.Size = new Size(576, 330);
            categoryDataGrid.TabIndex = 0;
            categoryDataGrid.SelectionChanged += categoryDataGrid_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(463, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 77);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Category Name";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(34, 153);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Location = new Point(34, 231);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Location = new Point(34, 315);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(851, 519);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(categoryDataGrid);
            Name = "Categories";
            Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)categoryDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView categoryDataGrid;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}