using Microsoft.EntityFrameworkCore;

namespace OnlineStore.DataAccess.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Role { get; set; } = default!;

    public static void CreateUserModelBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);
            entity.Property(x => x.Email).HasMaxLength(100);
            entity.Property(x => x.Password).HasMaxLength(100);
            entity.Property(x => x.Role).HasMaxLength(10);

            entity.HasIndex(x => x.Id);
            entity.HasIndex(x=>x.Name);
        });
    }
}
