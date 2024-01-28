using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;

namespace AccessManagement.API.User.Application;
public interface IRoleRepository
{
    public List<RoleResponse> GetAllRoles();
    public RoleResponse GetRoleById(Guid roleId);
    public RoleResponse CreateRole(RoleRequest newRole);
    public RoleResponse UpdateRole(RoleRequest updatedRole);
    public RoleResponse DeleteRole(Guid roleId);
}
