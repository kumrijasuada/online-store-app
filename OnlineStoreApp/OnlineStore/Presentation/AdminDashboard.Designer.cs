namespace OnlineStore;

partial class AdminDashboard
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
        usersBox = new PictureBox();
        pictureBox2 = new PictureBox();
        exitLbl = new Label();
        usersLbl = new Label();
        prodBox = new PictureBox();
        prodLbl = new Label();
        ((System.ComponentModel.ISupportInitialize)usersBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)prodBox).BeginInit();
        SuspendLayout();
        // 
        // usersBox
        // 
        usersBox.Image = (Image)resources.GetObject("usersBox.Image");
        usersBox.Location = new Point(12, 12);
        usersBox.Name = "usersBox";
        usersBox.Size = new Size(260, 160);
        usersBox.TabIndex = 0;
        usersBox.TabStop = false;
        usersBox.Click += usersBox_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.logoff;
        pictureBox2.Location = new Point(700, 308);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(107, 96);
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        pictureBox2.Click += pictureBox2_Click;
        // 
        // exitLbl
        // 
        exitLbl.AutoSize = true;
        exitLbl.Location = new Point(738, 425);
        exitLbl.Name = "exitLbl";
        exitLbl.Size = new Size(33, 20);
        exitLbl.TabIndex = 2;
        exitLbl.Text = "Exit";
        // 
        // usersLbl
        // 
        usersLbl.AutoSize = true;
        usersLbl.Location = new Point(95, 196);
        usersLbl.Name = "usersLbl";
        usersLbl.Size = new Size(44, 20);
        usersLbl.TabIndex = 3;
        usersLbl.Text = "Users";
        // 
        // prodBox
        // 
        prodBox.Image = Properties.Resources.products;
        prodBox.Location = new Point(12, 239);
        prodBox.Name = "prodBox";
        prodBox.Size = new Size(260, 165);
        prodBox.TabIndex = 4;
        prodBox.TabStop = false;
        prodBox.Click += prodBox_Click;
        // 
        // prodLbl
        // 
        prodLbl.AutoSize = true;
        prodLbl.Location = new Point(95, 425);
        prodLbl.Name = "prodLbl";
        prodLbl.Size = new Size(66, 20);
        prodLbl.TabIndex = 5;
        prodLbl.Text = "Products";
        // 
        // AdminDashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(853, 469);
        Controls.Add(prodLbl);
        Controls.Add(prodBox);
        Controls.Add(usersLbl);
        Controls.Add(exitLbl);
        Controls.Add(pictureBox2);
        Controls.Add(usersBox);
        Name = "AdminDashboard";
        Text = "AdminDashboard";
        ((System.ComponentModel.ISupportInitialize)usersBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)prodBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox usersBox;
    private PictureBox pictureBox2;
    private Label exitLbl;
    private Label usersLbl;
    private PictureBox prodBox;
    private Label prodLbl;
}