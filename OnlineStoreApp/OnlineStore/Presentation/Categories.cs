using OnlineStore.Application.Models;

namespace OnlineStore.Presentation;

public partial class Categories : Form
{
    public Categories()
    {
        InitializeComponent();
        PopulateCategories();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string name = textBox1.Text;
        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("Category name is required.");
            return;
        }

        Program.CategoryManager.AddCategory(new Category
        {
            Name = name,
        });
        PopulateCategories();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _ = int.TryParse(categoryDataGrid.SelectedRows[0].Cells[nameof(Category.Id)].Value.ToString(), out int id);

        Category? category = Program.CategoryManager.GetCategoryById(id);
        if (category != null)
        {
            Program.CategoryManager.RemoveCategory(category);
            PopulateCategories();
        }
    }

    private void PopulateCategories()
    {
        categoryDataGrid.DataSource = null;
        categoryDataGrid.DataSource = Program.CategoryManager.GetAllCategories();
        if (categoryDataGrid.DataSource != null)
        {
            categoryDataGrid.Columns[nameof(Category.Id)].ReadOnly = true;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (categoryDataGrid.SelectedRows[0].Cells[nameof(User.Id)].Value is int id)
        {
            var category = Program.CategoryManager.GetCategoryById(id);
            category.Name = textBox1.Text;
            Program.CategoryManager.UpdateCategory(category);
        }
    }

    private void categoryDataGrid_SelectionChanged(object sender, EventArgs e)
    {
        int selectedCount = categoryDataGrid.SelectedRows.Count;

        button1.Enabled = true;
        button2.Enabled = selectedCount == 1;
        button3.Enabled = selectedCount == 1;
    }
}
