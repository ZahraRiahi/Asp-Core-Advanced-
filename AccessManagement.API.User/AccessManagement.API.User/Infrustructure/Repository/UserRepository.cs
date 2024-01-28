using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AccessManagement.API.User.Infrustructure.Entites;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AccessManagement.API.User.Infrustructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;
    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreateUser(UserEntity newUser)
    {
        var users = _dbContext.Users.Add(newUser);
        var saveUser = _dbContext.SaveChanges();
    }

    public void DeleteUser(Guid userId)
    {
        _dbContext.Remove(userId);
        _dbContext.SaveChanges();
    }

    public List<UserEntity> GetAllUsers()
    {
        var users = _dbContext.Users.ToList();
        return users;
    }

    public UserEntity GetUserById(Guid userId)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.UserID == userId);
        return user;
    }

    public UserEntity UpdateUser(UserEntity updatedUser)
    {
        var existingUser = _dbContext.Users.FirstOrDefault(u => u.UserID == updatedUser.UserID);
        if (existingUser != null)
        {
            existingUser.Username = updatedUser.Username;
            existingUser.Email = updatedUser.Email;
            existingUser.Password = updatedUser.Password;
            existingUser.FirstName = updatedUser.FirstName;
            existingUser.LastName = updatedUser.LastName;
            existingUser.PhoneNumber = updatedUser.PhoneNumber;
            existingUser.Addresses = updatedUser.Addresses;
            existingUser.RegistrationDate = updatedUser.RegistrationDate;
            existingUser.LastLogin = updatedUser.LastLogin;
            _dbContext.SaveChanges();
        }
        return existingUser;


    }

}