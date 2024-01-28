using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;

namespace AccessManagement.API.User.Application;
public interface IPermissionRepository
{
    public List<PermissionResponse> GetAllPermissions();
    public PermissionResponse GetPermissionById(Guid permissionId);
    public PermissionResponse CreatePermission(PermissionRequest newPermission);
    public PermissionResponse UpdatePermission(PermissionRequest updatedPermission);
    public PermissionResponse DeletePermission(Guid permissionId);
}
