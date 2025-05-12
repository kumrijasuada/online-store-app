namespace OnlineStore.Presentation
{
    partial class Products
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
            addProdBtn = new Button();
            updateProdBtn = new Button();
            deleteProdBtn = new Button();
            label1 = new Label();
            UpdateProdLbl = new Label();
            deleteProdLbl = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            uploadBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            downloadBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addProdBtn
            // 
            addProdBtn.BackColor = Color.LimeGreen;
            addProdBtn.Location = new Point(12, 149);
            addProdBtn.Name = "addProdBtn";
            addProdBtn.Size = new Size(94, 29);
            addProdBtn.TabIndex = 0;
            addProdBtn.Text = "Add";
            addProdBtn.UseVisualStyleBackColor = false;
            addProdBtn.Click += addProdBtn_Click;
            // 
            // updateProdBtn
            // 
            updateProdBtn.BackColor = Color.Orange;
            updateProdBtn.Location = new Point(13, 281);
            updateProdBtn.Name = "updateProdBtn";
            updateProdBtn.Size = new Size(94, 29);
            updateProdBtn.TabIndex = 1;
            updateProdBtn.Text = "Update";
            updateProdBtn.UseVisualStyleBackColor = false;
            updateProdBtn.Click += updateProdBtn_Click;
            // 
            // deleteProdBtn
            // 
            deleteProdBtn.BackColor = Color.Tomato;
            deleteProdBtn.Location = new Point(13, 427);
            deleteProdBtn.Name = "deleteProdBtn";
            deleteProdBtn.Size = new Size(94, 29);
            deleteProdBtn.TabIndex = 2;
            deleteProdBtn.Text = "Delete";
            deleteProdBtn.UseVisualStyleBackColor = false;
            deleteProdBtn.Click += deleteProdBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 95);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "Add Product";
            // 
            // UpdateProdLbl
            // 
            UpdateProdLbl.AutoSize = true;
            UpdateProdLbl.Location = new Point(7, 231);
            UpdateProdLbl.Name = "UpdateProdLbl";
            UpdateProdLbl.Size = new Size(113, 20);
            UpdateProdLbl.TabIndex = 4;
            UpdateProdLbl.Text = "Update Product";
            // 
            // deleteProdLbl
            // 
            deleteProdLbl.AutoSize = true;
            deleteProdLbl.Location = new Point(12, 381);
            deleteProdLbl.Name = "deleteProdLbl";
            deleteProdLbl.Size = new Size(108, 20);
            deleteProdLbl.TabIndex = 5;
            deleteProdLbl.Text = "Delete Product";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(782, 408);
            dataGridView1.TabIndex = 6;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 26);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 7;
            label2.Text = "All Products";
            // 
            // uploadBtn
            // 
            uploadBtn.BackColor = Color.LavenderBlush;
            uploadBtn.Location = new Point(709, 19);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(124, 63);
            uploadBtn.TabIndex = 8;
            uploadBtn.Text = "Upload";
            uploadBtn.UseVisualStyleBackColor = false;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // downloadBtn
            // 
            downloadBtn.BackColor = Color.LavenderBlush;
            downloadBtn.Location = new Point(839, 19);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(109, 63);
            downloadBtn.TabIndex = 9;
            downloadBtn.Text = "Download";
            downloadBtn.UseVisualStyleBackColor = false;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "Products.csv";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 615);
            Controls.Add(downloadBtn);
            Controls.Add(uploadBtn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(deleteProdLbl);
            Controls.Add(UpdateProdLbl);
            Controls.Add(label1);
            Controls.Add(deleteProdBtn);
            Controls.Add(updateProdBtn);
            Controls.Add(addProdBtn);
            Name = "Products";
            Text = "Products";
            FormClosed += Products_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addProdBtn;
        private Button updateProdBtn;
        private Button deleteProdBtn;
        private Label label1;
        private Label UpdateProdLbl;
        private Label deleteProdLbl;
        private DataGridView dataGridView1;
        private Label label2;
        private Button uploadBtn;
        private OpenFileDialog openFileDialog1;
        private Button downloadBtn;
        private SaveFileDialog saveFileDialog1;
    }
}