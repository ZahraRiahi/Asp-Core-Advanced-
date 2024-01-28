using AccessManagement.API.User.Application;
using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AccessManagement.API.User.DTO.ExternalAPIModels.Response;

using AccessManagement.API.User.Infrustructure.Entites;
using AutoMapper;

namespace AccessManagement.API.User.Application.Repository;
public class RoleRepository : IRoleRepository
{
    private readonly IMapper _mapper;
    private readonly IRoleRepository _roleRepository;

    public RoleRepository(IMapper mapper, IRoleRepository roleRepository)
    {
        _mapper = mapper;
        _roleRepository = roleRepository;
    }

    public RoleResponse CreateRole(RoleRequest newRole)
    {
        var roleRequests = _mapper.Map<RoleRequest>(newRole);
        var createdRole = _roleRepository.CreateRole(roleRequests);
        var createRoleEntity = _mapper.Map<RoleResponse>(createdRole);
        return createRoleEntity;
    }


    public RoleResponse DeleteRole(Guid roleId)
    {
        var deletedRole = _roleRepository.DeleteRole(roleId);
        return deletedRole;
    }


    public List<RoleResponse> GetAllRoles()
    {
        var roles = _roleRepository.GetAllRoles();
        var roleResponses = _mapper.Map<List<RoleResponse>>(roles);
        return roleResponses;
    }

    public RoleResponse GetRoleById(Guid roleId)
    {
        var role = _roleRepository.GetRoleById(roleId);
        return role;
    }



    public RoleResponse UpdateRole(RoleRequest updatedRole)
    {
        var roleRequests = _mapper.Map<RoleRequest>(updatedRole);
        var updateRule = _roleRepository.UpdateRole(roleRequests);
        var updateRoleEntity = _mapper.Map<RoleResponse>(updatedRole);
        return updateRoleEntity;
    }

}