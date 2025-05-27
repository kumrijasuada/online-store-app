using OnlineStore.Presentation;
using Application1 = System.Windows.Forms.Application; // Alias

namespace OnlineStore;

public partial class AdminDashboard : Form
{
    public AdminDashboard()
    {
        InitializeComponent();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Application1.Exit();
    }

    private void usersBox_Click(object sender, EventArgs e)
    {
        Users users = new();
        users.ShowDialog();
    }

    private void prodBox_Click(object sender, EventArgs e)
    {
        Products products = new();
        products.ShowDialog();
    }

    private void categoriesPictureBox_Click(object sender, EventArgs e)
    {
        Categories categories = new();
        categories.ShowDialog();
    }
}
