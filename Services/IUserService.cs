using FlightManagementAPI.Models;

public interface IUserService
{
    User Authenticate(string username, string password);
}
