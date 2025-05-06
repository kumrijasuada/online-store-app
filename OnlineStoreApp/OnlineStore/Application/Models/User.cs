namespace OnlineStore.Application.Models;

public class User
{
    public int Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    private static int _id = 0;
    public User()
    {
        Id = ++_id;
    }
}