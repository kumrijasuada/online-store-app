using OnlineStore.Application.Models;
using OnlineStore.Common;
using OnlineStore.Common.Exceptions;

namespace OnlineStore.Application.BusinessLogic;

public class ProductManager
{
    public ProductManager()
    { }

    public List<Product> GetAllProducts(string userRole)
    {
        if (userRole == Constants.UserRole)
        {
            return Program.OnlineStoreDbContext.Products.Where(x => x.IsActive).ToList();
        }

        return Program.OnlineStoreDbContext.Products.ToList();
    }

    public Product? RetrieveProductByBarcode(string barcode)
    {
        return Program.OnlineStoreDbContext.Products.Where(x => x.Barcode == barcode).FirstOrDefault();
    }

    public void AddProduct(Product product)
    {
        Product? existingProduct = RetrieveProductByBarcode(product.Barcode);
        if (existingProduct is not null)
        {
            throw new BaseException($"There is already a product with the requested barcode: {product.Barcode}.");
        }

        Program.OnlineStoreDbContext.Products.Add(product);
        Program.OnlineStoreDbContext.SaveChanges();
    }

    public void RemoveProduct(Product product)
    {
        Product? existingProduct = Program.OnlineStoreDbContext.Products.FirstOrDefault(x => x.Barcode == product.Barcode);

        if (existingProduct is null)
        {
            throw new BaseException($"Product with the requested barcode: {product.Barcode} was not found.");
        }

        Program.OnlineStoreDbContext.Products.Remove(product);
        Program.OnlineStoreDbContext.SaveChanges();
    }
}
