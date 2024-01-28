using AccessManagement.API.User.Application;
using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AccessManagement.API.User.Infrustructure.Configuration;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AccessManagement.API.User.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;


    public UserController(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    [HttpGet]
    public ActionResult<IEnumerable<UserResponse>> GetAllUsers()
    {
        var users = _userRepository.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("{userId}")]
    public ActionResult<UserResponse> GetUserById(Guid userId)
    {
        var user = _userRepository.GetUserById(userId);
        if (user == null)
            return NotFound();

        return Ok(user);
    }
    [HttpPost]
    public ActionResult<UserResponse> CreateUser(UserRequest userRequest)
    {
        // var mapUserRequest = _mapper.Map<DTO.InternalAPIModels.Request.UserRequest>(userRequest);
        var newUser = _userRepository.CreateUser(userRequest);
        return Ok(newUser);
    }
    [HttpPut("{userId}")]
    public ActionResult<UserResponse> UpdateUser(UserRequest updatedUser)
    {
        var user = _userRepository.GetUserById(updatedUser.UserID);
        if (user == null)
        {
            return NotFound();
        }
        var updateUser = _userRepository.UpdateUser(updatedUser);
        return Ok(updateUser);
    }
    [HttpDelete("{userId}")]
    public ActionResult<UserResponse> DeleteUser(Guid userId)
    {
        var user = _userRepository.GetUserById(userId);
        if (user == null)
        {
            return NotFound();
        }
        var deletedUser = _userRepository.DeleteUser(userId);
        return Ok(deletedUser);
    }

}