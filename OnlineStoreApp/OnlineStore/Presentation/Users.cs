using OnlineStore.Application.Models;

namespace OnlineStore.Presentation;

public partial class Users : Form
{
    public Users()
    {
        InitializeComponent();
        PopulateUsers();
    }


    private void addBtn_Click(object sender, EventArgs e)
    {
        AddUser addUser = new();
        addUser.FormClosed += Users_FormClosed;
        addUser.Show();
    }

    private void updateBtn_Click(object sender, EventArgs e)
    {
        if (usersDataGrid.SelectedRows.Count == 0)
            return;

        if (usersDataGrid.SelectedRows[0].Cells[nameof(User.Id)].Value is int id)
        {
            AddUser addUser = new(id);
            addUser.FormClosed += Users_FormClosed;
            addUser.Show();
        }
        else
        {
            MessageBox.Show($"The selected id is not valid.");
        }

    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        _ = int.TryParse(usersDataGrid.SelectedRows[0].Cells[nameof(User.Id)].Value.ToString(), out int id);

        User? user = Program.UserManager.GetUserById(id);
        if (user != null)
        {
            Program.UserManager.DeleteUser(user);
            PopulateUsers();
        }
    }

    private void usersDataGrid_SelectionChanged(object sender, EventArgs e)
    {
        int selectedCount = usersDataGrid.SelectedRows.Count;

        addBtn.Enabled = true;
        updateBtn.Enabled = selectedCount == 1;
        deleteBtn.Enabled = selectedCount == 1;
    }

    private void Users_FormClosed(object sender, FormClosedEventArgs e)
    {
        PopulateUsers();
    }


    private void PopulateUsers()
    {
        usersDataGrid.DataSource = null;
        usersDataGrid.DataSource = Program.UserManager.GetAllUsers();
        usersDataGrid.Columns[nameof(User.Password)].Visible = false;
    }
}