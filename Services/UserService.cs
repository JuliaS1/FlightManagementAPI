// UserService.cs
using System.Collections.Generic;
using System.Linq;
using FlightManagementAPI.Models;

public class UserService : IUserService
{
    private readonly List<User> _users = new List<User>
    {
        new User { Id = 1, Username = "admin", Password = "admin123" }
    };

    public User Authenticate(string username, string password)
    {
        var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

        return user ?? new User();
    }
}
