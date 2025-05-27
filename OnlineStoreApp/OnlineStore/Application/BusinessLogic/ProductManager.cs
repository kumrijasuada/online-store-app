using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Models;
using OnlineStore.Common;
using OnlineStore.Common.Exceptions;

namespace OnlineStore.Application.BusinessLogic;

public class ProductManager
{
    public List<Product> GetAllProducts(string userRole)
    {
        if (userRole == Constants.UserRole)
        {
            return Program.OnlineStoreDbContext.Products.Include(x=>x.Category).Where(x => x.IsActive).Select(x=>new Product
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Barcode = x.Barcode,
                Price = x.Price,
                Stock = x.Stock,
                IsActive = x.IsActive,
                CategoryId = x.CategoryId,
            }).ToList();
        }

        return Program.OnlineStoreDbContext.Products.Include(x=>x.Category).Select(x => new Product
        {
            Id = x.Id,
            Name = x.Name,
            Barcode = x.Barcode,
            Description = x.Description,
            Price = x.Price,
            Stock = x.Stock,
            IsActive = x.IsActive,
            CategoryId=x.CategoryId,
        }).ToList();
    }

    public Product? RetrieveProductByBarcode(string barcode)
    {
        return Program.OnlineStoreDbContext.Products.Include(x=>x.Category).Where(x => x.Barcode == barcode).Select(x => new Product
        {
            Id = x.Id,
            Name = x.Name,
            Barcode = x.Barcode,
            Description = x.Description,
            Price = x.Price,
            Stock = x.Stock,
            IsActive = x.IsActive,
            CategoryId=x.CategoryId,
        }).FirstOrDefault();
    }

    public void AddProduct(Product product)
    {
        Product? existingProduct = RetrieveProductByBarcode(product.Barcode);
        if (existingProduct is not null)
        {
            throw new BaseException($"There is already a product with the requested barcode: {product.Barcode}.");
        }

        Program.OnlineStoreDbContext.Products.Add(new DataAccess.Entities.Product
        {
            Name = product.Name,
            Barcode = product.Barcode,
            Description = product.Description,
            Price = product.Price,
            Stock = product.Stock,
            IsActive = product.IsActive,
            CategoryId = product.CategoryId,
        });
        Program.OnlineStoreDbContext.SaveChanges();
    }

    public void RemoveProduct(Product product)
    {
       var existingProduct = Program.OnlineStoreDbContext.Products.FirstOrDefault(x => x.Barcode == product.Barcode);

        if (existingProduct is null)
        {
            throw new BaseException($"Product with the requested barcode: {product.Barcode} was not found.");
        }

        Program.OnlineStoreDbContext.Products.Remove(existingProduct);
        Program.OnlineStoreDbContext.SaveChanges();
    }
}
