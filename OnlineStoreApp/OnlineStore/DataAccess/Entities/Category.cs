using Microsoft.EntityFrameworkCore;

namespace OnlineStore.DataAccess.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public ICollection<Product> Products { get; set; } = default!;

    public static void CreateCategoryModelBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);

            entity.HasIndex(x => x.Name).IsUnique();
        });
    }
}
