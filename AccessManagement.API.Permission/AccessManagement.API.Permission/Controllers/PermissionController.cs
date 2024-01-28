
using AccessManagement.API.User.Application;
using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AccessManagement.API.Permission.Controllers;

[ApiController]
[Route("[controller]")]
public class PermissionController : ControllerBase
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IMapper _mapper;


    public PermissionController(IPermissionRepository permissionRepository, IMapper mapper)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
    }
    [HttpGet]
    public ActionResult<IEnumerable<PermissionResponse>> GetAllPermissions()
    {
        var permissions = _permissionRepository.GetAllPermissions();
        return Ok(permissions);
    }

    [HttpGet("{permissionId}")]
    public ActionResult<PermissionResponse> GetPermissionById(Guid permissionId)
    {
        var permission = _permissionRepository.GetPermissionById(permissionId);
        if (permission == null)
            return NotFound();

        return Ok(permission);
    }
    [HttpPost]
    public ActionResult<PermissionResponse> CreatePermission(PermissionRequest permissionRequest)
    {
        var newPermission = _permissionRepository.CreatePermission(permissionRequest);
        return Ok(newPermission);
    }
    [HttpPut("{permissionId}")]
    public ActionResult<PermissionResponse> UpdatePermission(PermissionRequest updatedPermission)
    {
        var permission = _permissionRepository.GetPermissionById(updatedPermission.PermissionID);
        if (permission == null)
        {
            return NotFound();
        }
        var updatePermission = _permissionRepository.UpdatePermission(updatedPermission);
        return Ok(updatePermission);
    }
    [HttpDelete("{permissionId}")]
    public ActionResult<PermissionResponse> DeletePermission(Guid permissionId)
    {
        var permission = _permissionRepository.GetPermissionById(permissionId);
        if (permission == null)
        {
            return NotFound();
        }
        var deletedPermission = _permissionRepository.DeletePermission(permissionId);
        return Ok(deletedPermission);
    }

}