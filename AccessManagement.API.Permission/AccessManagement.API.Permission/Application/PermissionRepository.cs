using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;

using AutoMapper;

namespace AccessManagement.API.User.Application.Repository;
public class PermissionRepository : IPermissionRepository
{
    private readonly IMapper _mapper;
    private readonly IPermissionRepository _permissionRepository;

    public PermissionRepository(IMapper mapper, IPermissionRepository permissionRepository)
    {
        _mapper = mapper;
        _permissionRepository = permissionRepository;
    }

    public PermissionResponse CreatePermission(PermissionRequest newPermission)
    {
        var permissionRequests = _mapper.Map<PermissionRequest>(newPermission);
        var createdPermission = _permissionRepository.CreatePermission(permissionRequests);
        var createPermissionEntity = _mapper.Map<PermissionResponse>(createdPermission);
        return createPermissionEntity;
    }


    public PermissionResponse DeletePermission(Guid permissionId)
    {
        var deletedPermission = _permissionRepository.DeletePermission(permissionId);
        return deletedPermission;
    }


    public List<PermissionResponse> GetAllPermissions()
    {
        var permissions = _permissionRepository.GetAllPermissions();
        var permissionResponses = _mapper.Map<List<PermissionResponse>>(permissions);
        return permissionResponses;
    }

    public PermissionResponse GetPermissionById(Guid permissionId)
    {
        var permission = _permissionRepository.GetPermissionById(permissionId);
        return permission;
    }



    public PermissionResponse UpdatePermission(PermissionRequest updatedPermission)
    {
        var permissionRequests = _mapper.Map<PermissionRequest>(updatedPermission);
        var updateRule = _permissionRepository.UpdatePermission(permissionRequests);
        var updatePermissionEntity = _mapper.Map<PermissionResponse>(updatedPermission);
        return updatePermissionEntity;
    }

}