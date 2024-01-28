
using AccessManagement.API.User.Application;
using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AccessManagement.API.Role.Controllers;

[ApiController]
[Route("[controller]")]
public class RoleController : ControllerBase
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;


    public RoleController(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }
    [HttpGet]
    public ActionResult<IEnumerable<RoleResponse>> GetAllRoles()
    {
        var roles = _roleRepository.GetAllRoles();
        return Ok(roles);
    }

    [HttpGet("{roleId}")]
    public ActionResult<RoleResponse> GetRoleById(Guid roleId)
    {
        var role = _roleRepository.GetRoleById(roleId);
        if (role == null)
            return NotFound();

        return Ok(role);
    }
    [HttpPost]
    public ActionResult<RoleResponse> CreateRole(RoleRequest roleRequest)
    {
        var newRole = _roleRepository.CreateRole(roleRequest);
        return Ok(newRole);
    }
    [HttpPut("{roleId}")]
    public ActionResult<RoleResponse> UpdateRole(RoleRequest updatedRole)
    {
        var role = _roleRepository.GetRoleById(updatedRole.RoleID);
        if (role == null)
        {
            return NotFound();
        }
        var updateRole = _roleRepository.UpdateRole(updatedRole);
        return Ok(updateRole);
    }
    [HttpDelete("{RoleId}")]
    public ActionResult<RoleResponse> DeleteRole(Guid RoleId)
    {
        var Role = _roleRepository.GetRoleById(RoleId);
        if (Role == null)
        {
            return NotFound();
        }
        var deletedRole = _roleRepository.DeleteRole(RoleId);
        return Ok(deletedRole);
    }

}