using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AccessManagement.API.User.Infrustructure.Entites;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AccessManagement.API.User.Infrustructure.Repository;

public class RoleRepository : IRoleRepository
{
    private readonly ApplicationDbContext _dbContext;
    public RoleRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreateRole(RoleEntity newRole)
    {
        var roles = _dbContext.Roles.Add(newRole);
        var saveRole = _dbContext.SaveChanges();
    }


    public void DeleteRole(Guid roleId)
    {
        _dbContext.Remove(roleId);
        _dbContext.SaveChanges();
    }



    public List<RoleEntity> GetAllRoles()
    {
        var roles = _dbContext.Roles.ToList();
        return roles;
    }


    public RoleEntity GetRoleById(Guid roleId)
    {
        var role = _dbContext.Roles.FirstOrDefault(u => u.RoleID == roleId);
        return role;
    }



    public RoleEntity UpdateRole(RoleEntity updatedRole)
    {
        var existingRole = _dbContext.Roles.FirstOrDefault(u => u.RoleID == updatedRole.RoleID);
        if (existingRole != null)
        {
            existingRole.Title = updatedRole.Title;
            existingRole.CreationDate = updatedRole.CreationDate;
            existingRole.CreatorId = updatedRole.CreatorId;
            existingRole.Users = updatedRole.Users;

            _dbContext.SaveChanges();
        }
        return existingRole;
    }



}