using Microsoft.EntityFrameworkCore;

namespace OnlineStore.DataAccess.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Barcode { get; set; } = default!;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public bool IsActive { get; set; } = true;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = default!;

    public static void CreateProductModelBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name)
            .IsRequired().HasMaxLength(50);

            entity.Property(x => x.Description).HasMaxLength(300);
            entity.Property(x => x.Barcode).HasMaxLength(20);
            entity.Property(x => x.IsActive);
            entity.Property(x => x.Price)
            .HasPrecision(18, 2);

            entity.Property(x => x.Stock);

            entity.HasOne(x => x.Category)
             .WithMany(x=>x.Products)
             .HasForeignKey(x => x.CategoryId);

            entity.HasIndex(x => x.Name).IsUnique();
            entity.HasIndex(x => x.Barcode).IsUnique();
        });
    }
}
