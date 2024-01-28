
using AccessManagement.API.User.Infrustructure.Entites;

namespace AccessManagement.API.User.Infrustructure.Repository;
public interface IRoleRepository
{
    public List<RoleEntity> GetAllRoles();
    public RoleEntity GetRoleById(Guid roleId);
    public void CreateRole(RoleEntity newRole);
    public RoleEntity UpdateRole(RoleEntity updatedRole);
    public void DeleteRole(Guid roleId);

}