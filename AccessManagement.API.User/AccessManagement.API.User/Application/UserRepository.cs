using AccessManagement.API.User.Application;
using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;

using AccessManagement.API.User.Infrustructure.Entites;
using AutoMapper;

namespace AccessManagement.API.User.Application.Repository;
public class UserRepository : IUserRepository
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public UserRepository(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }


    public UserResponse CreateUser(UserRequest newUser)

    {
        var userRequests = _mapper.Map<UserRequest>(newUser);
        var createdUser = _userRepository.CreateUser(userRequests);
        var createUserEntity = _mapper.Map<UserResponse>(createdUser);
        return createUserEntity;
    }



    public UserResponse DeleteUser(Guid userId)
    {
        var deletedUser = _userRepository.DeleteUser(userId);
        return deletedUser;
    }

    public UserResponse GetUserById(Guid userId)
    {
        var user = _userRepository.GetUserById(userId);
        return user;
    }



    public UserResponse UpdateUser(UserRequest updatedUser)
    {
        var userRequests = _mapper.Map<UserRequest>(updatedUser);
        var updateUser = _userRepository.UpdateUser(userRequests);
        var updateUserEntity = _mapper.Map<UserResponse>(updateUser);
        return updateUserEntity;
    }

    List<UserResponse> IUserRepository.GetAllUsers()
    {
        var users = _userRepository.GetAllUsers();
        var userResponses = _mapper.Map<List<UserResponse>>(users);
        return userResponses;
    }
}