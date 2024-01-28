using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AccessManagement.API.User.Infrustructure.Entites;

namespace AccessManagement.API.User.Application;
public interface IUserRepository
{
    public List<UserResponse> GetAllUsers();
    public UserResponse GetUserById(Guid userId);
    public UserResponse CreateUser(UserRequest newUser);
    public UserResponse UpdateUser(UserRequest updatedUser);
    public UserResponse DeleteUser(Guid userId);
}
