using OnlineStore.Application.Models;

namespace OnlineStore.Presentation;

public partial class AddProduct : Form
{
    private Product modifyProduct = null;

    public AddProduct(Product product = null)
    {
        InitializeComponent();
        PopulateComboBox();

        modifyProduct = product;
        if (modifyProduct != null)
            PopulateProductInfo();
    }

    private void PopulateProductInfo()
    {
        textBox1.Text = modifyProduct.Name;
        textBox2.Text = modifyProduct.Barcode;
        textBox3.Text = modifyProduct.Price.ToString();
        textBox4.Text = modifyProduct.Stock.ToString();
        textBox5.Text = modifyProduct.Description;
        PopulateComboBox();
    }
    private void PopulateComboBox()
    {
        productCatComboBox.DataSource = Program.CategoryManager.GetAllCategories();
        productCatComboBox.DisplayMember = nameof(Product.Name);
        productCatComboBox.ValueMember = nameof(Product.Id);
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBox2.Text))
        {
            MessageBox.Show("Barcode fields is required.");
            return;
        }

        if (modifyProduct == null)
        {
            modifyProduct = new Product()
            {
                Name = textBox1.Text,
                Barcode = textBox2.Text,
                Price = decimal.Parse(textBox3.Text),
                Stock = int.Parse(textBox4.Text),
                Description = textBox5.Text,
                CategoryId = (int)productCatComboBox.SelectedValue
            };
            Program.ProductManager.AddProduct(modifyProduct);
        }
        else
        {
            modifyProduct.Name = textBox1.Text;
            modifyProduct.Barcode = textBox2.Text;
            modifyProduct.Price = decimal.Parse(textBox3.Text);
            modifyProduct.Stock = int.Parse(textBox4.Text);
            modifyProduct.Description = textBox5.Text;
            modifyProduct.CategoryId = (int)productCatComboBox.SelectedValue;
        }

        Close();
    }
}
