using OnlineStore.Application.Models;
using OnlineStore.Common;

namespace OnlineStore.Presentation;

public partial class AddUser : Form
{
    private User modifyUser = null;

    public AddUser(int id = 0)
    {
        InitializeComponent();
        if (id != 0)
        {
            modifyUser = Program.UserManager.GetUserById(id);

            PopulateUserInfo();
        }
    }

    private void PopulateUserInfo()
    {
        textBox1.Text = modifyUser.Name;
        textBox2.Text = modifyUser.Email;
        comboBox1.SelectedItem = modifyUser.Role;
    }

    private void saveBtn_Click_1(object sender, EventArgs e)
    {
        bool addUser = modifyUser == null;
        string selectedRole = comboBox1.SelectedItem?.ToString();

        // Need to prevent admin role duplication
        bool existingAdmin = false;
        foreach (var user in Program.UserManager.GetAllUsers())
        {
            if (user.Role == Constants.AdminRole && user != modifyUser)
            {
                existingAdmin = true;
                break;
            }
        }

        if (existingAdmin)
        {
            MessageBox.Show("There is already an existing user with the 'Admin' role.");
            return;
        }

        if (addUser)
        {
            modifyUser = new User();
            Program.UserManager.AddUser(modifyUser);
            addUser = true;
        }

        modifyUser.Name = textBox1.Text;
        modifyUser.Email = textBox2.Text;
        modifyUser.Role = comboBox1.SelectedItem?.ToString()!;

        if (addUser && string.IsNullOrWhiteSpace(textBox3.Text))
        {
            MessageBox.Show("Password is required!");
            return;
        }

        if (!string.IsNullOrWhiteSpace(textBox3.Text))
        {
            modifyUser.Password = textBox3.Text;
        }

        Close();
    }
}