
using AccessManagement.API.User.Infrustructure.Entites;

namespace AccessManagement.API.User.Infrustructure.Repository;
public interface IPermissionRepository
{
    public List<PermissionEntity> GetAllPermissions();
    public PermissionEntity GetPermissionById(Guid permissionId);
    public void CreatePermission(PermissionEntity newPermission);
    public PermissionEntity UpdatePermission(PermissionEntity updatedPermission);
    public void DeletePermission(Guid permissionId);

}