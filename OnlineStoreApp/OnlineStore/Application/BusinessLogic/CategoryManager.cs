using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Models;
using OnlineStore.Common.Exceptions;

namespace OnlineStore.Application.BusinessLogic;

public class CategoryManager
{
    public List<Category>? GetAllCategories()
    {
        if (Program.OnlineStoreDbContext.Categories.Count() != 0)
        {
            return Program.OnlineStoreDbContext.Categories.Select(x => new Category
            {
                Id = x.Id,
                Name = x.Name
            }).OrderBy(x => x.Id).ToList();
        }
        return null;
    }

    public void AddCategory(Category categoryToAdd)
    {
        Program.OnlineStoreDbContext.Categories.Add(new DataAccess.Entities.Category
        {
            Name = categoryToAdd.Name,
        });
        Program.OnlineStoreDbContext.SaveChanges();
    }

    public void UpdateCategory(Category categoryToUpdate)
    {
        var categoryEntity = Program.OnlineStoreDbContext.Categories.Find(categoryToUpdate.Id);
        if (categoryEntity is null)
            throw new BaseException("Category does not exists.");

        categoryEntity.Name = categoryToUpdate.Name;
        Program.OnlineStoreDbContext.SaveChanges();
    }

    public Category? GetCategoryById(int id)
    {
        var category = Program.OnlineStoreDbContext.Categories.Where(x => x.Id == id).FirstOrDefault();
        if (category == null)
        {
            throw new BaseException($"The requested category with id {id} does not exists");
        }
        return new Category
        {
            Id = id,
            Name = category.Name
        };
    }

    public void RemoveCategory(Category categoryToRemove)
    {
        var category = Program.OnlineStoreDbContext.Categories.Include(x => x.Products).FirstOrDefault(x => x.Id == categoryToRemove.Id);
        if (category == null)
        {
            throw new BaseException("Category with the requested id does not exists.");
        }

        bool activeProduct = category.Products.Any(x => x.IsActive);
        if (activeProduct)
        {
            throw new BaseException("Product can't be deleted");
        }

        using var dbTransaction = Program.OnlineStoreDbContext.Database.BeginTransaction();
        try
        {
            Program.OnlineStoreDbContext.Products.RemoveRange(category.Products);

            Program.OnlineStoreDbContext.Categories.Remove(category);

            Program.OnlineStoreDbContext.SaveChanges();

            dbTransaction.Commit();
        }
        catch (BaseException ex)
        {
            dbTransaction.Rollback();
            throw;
        }
    }
}
