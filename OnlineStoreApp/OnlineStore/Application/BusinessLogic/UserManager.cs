using OnlineStore.Application.Models;
using OnlineStore.Common;
using OnlineStore.Common.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace OnlineStore.Application.BusinessLogic;

public class UserManager
{
    public User? LogIn(string email, string password)
    {
        var userEntity = Program.OnlineStoreDbContext.Users.Where(x => x.Email.Equals(email) && x.Password == password).FirstOrDefault();
        if (userEntity == null)
            return null;

        User user = new()
        {
            Id = userEntity.Id,
            Name = userEntity.Name,
            Email = userEntity.Email,
            Password = userEntity.Password,
            Role = userEntity.Role
        };
        Program.CurrentLoggedIn = user;

        return user;
    }

    public List<User> GetAllUsers()
    {
        return Program.OnlineStoreDbContext.Users.Select(x => new User
        {
            Id = x.Id,
            Name = x.Name,
            Email = x.Email,
            Password = x.Password,
            Role = x.Role
        }).ToList();
    }

    public void AddUser(User user)
    {
        Program.OnlineStoreDbContext.Users.Add(new DataAccess.Entities.User
        {
            Name = user.Name,
            Email = user.Email,
            Password = HashPassword(user.Password),
            Role = user.Role
        });
        Program.OnlineStoreDbContext.SaveChanges();
    }

    private static string HashPassword(string password)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        StringBuilder sb = new();
        foreach (byte b in bytes)
        {
            sb.Append(b.ToString("x2"));
        }
        return sb.ToString();
    }

    public User GetUserById(int id)
    {
        var user = Program.OnlineStoreDbContext.Users.Where(x => x.Id == id).FirstOrDefault();
        if (user != null)
        {
            return new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role
            };
        }

        throw new BaseException($"User with the requested id {id} was not found.");
    }

    public void DeleteUser(User userToDelete)
    {
        if (Program.OnlineStoreDbContext.Users.Any())
        {
            if (userToDelete.Role == Constants.AdminRole)
            {
                bool existingAdmin = Program.OnlineStoreDbContext.Users.Any(x => (x.Role == Constants.AdminRole) && (x.Id == userToDelete.Id));

                if (!existingAdmin)
                    return;

            }

            DataAccess.Entities.User user = Program.OnlineStoreDbContext.Users.FirstOrDefault(x => x.Id == userToDelete.Id);
            if (user != null)
            {
                Program.OnlineStoreDbContext.Users.Remove(user);
                Program.OnlineStoreDbContext.SaveChanges();
            }
        }
    }
}
