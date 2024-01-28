using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AccessManagement.API.User.Infrustructure.Entites;

namespace AccessManagement.API.User.Infrustructure.Repository;
public interface IUserRepository
{
    public List<UserEntity> GetAllUsers();
    public UserEntity GetUserById(Guid userId);
    public void CreateUser(UserEntity newUser);
    public UserEntity UpdateUser(UserEntity updatedUser);
    public void DeleteUser(Guid userId);

}