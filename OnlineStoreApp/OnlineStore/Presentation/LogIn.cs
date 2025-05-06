using OnlineStore.Application.Models;
using OnlineStore.Common;

namespace OnlineStore.Presentation;

public partial class LogIn : Form
{
    public LogIn()
    {
        InitializeComponent();
    }

    private void logInBtn_Click_1(object sender, EventArgs e)
    {

        string email = email_txtBox.Text;
        string password = password_txtBox.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please fill in both fields.");
            return;
        }

        User? user = Program.UserManager.LogIn(email, password);
        if (user == null)
        {
            password_txtBox.Clear();
            password_txtBox.Focus();
            return;
        }

        if (user.Role == Constants.AdminRole)
        {
            AdminDashboard adminDashboard = new();
            adminDashboard.Show();
            Hide();
        }
    }
}
