using OnlineStore.Application.Models;
using OnlineStore.Common;
using OnlineStore.Common.Exceptions;

namespace OnlineStore.Application.BusinessLogic;

public class ProductManager
{
    private List<Product> Products;

    public ProductManager()
    {
        Products = new List<Product>();
    }

    public List<Product> GetAllProducts(string userRole)
    {
        if (userRole == Constants.UserRole)
        {
            return Products.Where(x => x.IsActive).ToList();
        }

        return Products;
    }

    public Product? RetrieveProductByBarcode(string barcode)
    {
        foreach (Product product in Products)
        {
            if (product.Barcode == barcode)
            {
                return product;
            }
        }
        return null;
    }

    public void AddProduct(Product product)
    {
        Product? existingProduct = RetrieveProductByBarcode(product.Barcode);
        if (existingProduct is not null)
        {
            throw new BaseException($"There is already a product with the requested barcode: {product.Barcode}.");
        }

        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Product? existingProduct = Products.FirstOrDefault(x => x.Barcode == product.Barcode);

        if (existingProduct is null)
        {
            throw new BaseException($"Product with the requested barcode: {product.Barcode} was not found.");
        }

        Products.Remove(product);
    }
}
