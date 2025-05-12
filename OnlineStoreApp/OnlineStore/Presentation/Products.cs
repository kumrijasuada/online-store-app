using OnlineStore.Application.Models;
using OnlineStore.Common.Exceptions;

namespace OnlineStore.Presentation;

public partial class Products : Form
{
    public Products()
    {
        InitializeComponent();
    }


    private void addProdBtn_Click(object sender, EventArgs e)
    {
        AddProduct addProduct = new();
        addProduct.FormClosed += Products_FormClosed;
        addProduct.Show();
    }

    private void updateProdBtn_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
            return;

        var selectedToEdit = dataGridView1.SelectedRows[0].Cells["Barcode"].Value.ToString();
        var productToEdit = Program.ProductManager.RetrieveProductByBarcode(selectedToEdit);
        AddProduct updateProduct = new(productToEdit);
        updateProduct.FormClosed += Products_FormClosed;
        updateProduct.Show();
    }

    private void deleteProdBtn_Click(object sender, EventArgs e)
    {
        string barcode = dataGridView1.SelectedRows[0].Cells[nameof(Product.Barcode)].Value.ToString();

        Product? product = Program.ProductManager.RetrieveProductByBarcode(barcode);
        if (product != null)
        {
            Program.ProductManager.RemoveProduct(product);
            PopulateProducts();
        }
    }

    private void PopulateProducts()
    {
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = Program.ProductManager.GetAllProducts(Program.CurrentLoggedIn.Role);
        dataGridView1.Columns[nameof(Product.Id)].Visible = false;
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        int selectedCount = dataGridView1.SelectedRows.Count;

        addProdBtn.Enabled = true;
        updateProdBtn.Enabled = selectedCount == 1;
        deleteProdBtn.Enabled = selectedCount == 1;
    }

    private void Products_FormClosed(object sender, FormClosedEventArgs e)
    {
        PopulateProducts();
    }

    private void uploadBtn_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() != DialogResult.OK)
            return;

        var selectedFileName = openFileDialog1.FileName;
        if (!selectedFileName.EndsWith(".csv"))
        {
            MessageBox.Show("The selected file should be in the '.csv' format.");
            return;
        }

        var products = File.ReadAllLines(selectedFileName);
        for (var i = 0; i < products.Length; i++)
        {
            try
            {
                var productsFields = products[i].Split(',');
                if (productsFields.Length != 5)
                    throw new BaseException("File has incorrect information.");

                Product product = new()
                {
                    Name = productsFields[0],
                    Barcode = productsFields[1],
                    Price = decimal.Parse(productsFields[2]),
                    Stock = int.Parse(productsFields[3]),
                    Description = productsFields[4]

                };

                Program.ProductManager.AddProduct(product);
            }
            catch (BaseException)
            {
                continue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        PopulateProducts();
    }

    private void downloadBtn_Click(object sender, EventArgs e)
    {
        var selectedFileResult = saveFileDialog1.ShowDialog();
        if (selectedFileResult == DialogResult.OK)
        {
            var fileName = saveFileDialog1.FileName;
            List<string> productsToSave = new()
            {
                    "Name, Barcode, Price, Stock, Description"
                };
            var products = Program.ProductManager.GetAllProducts(Program.CurrentLoggedIn.Role);
            foreach (var product in products)
            {
                productsToSave.Add($"{product.Name},{product.Barcode},{product.Price},{product.Stock}, {product.Description}");
            }
            File.WriteAllLines(fileName, productsToSave.ToArray());
        }
    }
}

