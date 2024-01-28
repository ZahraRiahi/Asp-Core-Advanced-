using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AccessManagement.API.User.Infrustructure.Entites;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AccessManagement.API.User.Infrustructure.Repository;

public class PermissionRepository : IPermissionRepository
{
    private readonly ApplicationDbContext _dbContext;
    public PermissionRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreatePermission(PermissionEntity newPermission)
    {
        var Permissions = _dbContext.Permissions.Add(newPermission);
        var savePermission = _dbContext.SaveChanges();
    }


    public void DeletePermission(Guid permissionId)
    {
        _dbContext.Remove(permissionId);
        _dbContext.SaveChanges();
    }



    public List<PermissionEntity> GetAllPermissions()
    {
        var permissions = _dbContext.Permissions.ToList();
        return permissions;
    }


    public PermissionEntity GetPermissionById(Guid permissionId)
    {
        var permission = _dbContext.Permissions.FirstOrDefault(u => u.PermissionID == permissionId);
        return permission;
    }



    public PermissionEntity UpdatePermission(PermissionEntity updatedPermission)
    {
        var existingPermission = _dbContext.Permissions.FirstOrDefault(u => u.PermissionID == updatedPermission.PermissionID);
        if (existingPermission != null)
        {
            existingPermission.Title = updatedPermission.Title;
            existingPermission.CreationDate = updatedPermission.CreationDate;
            existingPermission.CreatorId = updatedPermission.CreatorId;
            existingPermission.Users = updatedPermission.Users;

            _dbContext.SaveChanges();
        }
        return existingPermission;
    }



}