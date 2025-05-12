using OnlineStore.Application.Models;
using OnlineStore.Common;
using OnlineStore.Common.Exceptions;

namespace OnlineStore.Application.BusinessLogic;

public class UserManager
{
    private List<User> Users { get; }
    public UserManager()
    {
        Users =
        [
            new User()
            {
                Name = "Admin",
                Email = "admin@gmail.com",
                Password = "admin@1234",
                Role = Constants.AdminRole
            },
            new User()
            {
                Name = "User",
                Email = "user@gmail.com",
                Password = "user@1234",
                Role = Constants.UserRole
            },
        ];
    }

    public User? LogIn(string email, string password)
    {
        foreach (var user in Users)
        {
            if (user.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && user.Password == password)
            {
                Program.CurrentLoggedIn = user;
                return user;
            }
        }

        return null;
    }

    public List<User> GetAllUsers()
    {
        return Users;
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public User GetUserById(int id)
    {
        var user = Users.Where(x => x.Id == id).FirstOrDefault();
        if (user != null)
        {
            return user;
        }

        throw new BaseException($"User with the requested id {id} was not found.");
    }

    public void DeleteUser(User userToDelete)
    {
        if (Users.Count != 0)
        {
            if (userToDelete.Role == Constants.AdminRole)
            {
                bool existingAdmin = false;

                foreach (var user in Users)
                {
                    if (user.Role == Constants.AdminRole && user.Id != userToDelete.Id)
                    {
                        existingAdmin = true;
                        break;
                    }
                }

                if (!existingAdmin)
                    return;
            }

            Users.Remove(userToDelete);
        }
    }
}
