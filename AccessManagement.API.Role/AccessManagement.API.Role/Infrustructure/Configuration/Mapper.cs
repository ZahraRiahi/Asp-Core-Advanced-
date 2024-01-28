using AccessManagement.API.User.DTO.ExternalAPIModels.Response;
using AccessManagement.API.User.DTO.InternalAPIModels.Embeded;
using AccessManagement.API.User.DTO.ExternalAPIModels.Request;
using AutoMapper;
using AccessManagement.API.User.DTO.ExternalAPIModels.Embeded;

namespace AccessManagement.API.User.Infrustructure.Configuration;

public class Mapper : Profile
{
    public Mapper()
    {
        // CreateMap<UserResponse, AccessManagement.API.User.Infrustructure.Entites.User>().ReverseMap();
        // CreateMap<AddressEmbeded, AccessManagement.API.User.Infrustructure.Entites.Address>().ReverseMap();
        CreateMap<AccessManagement.API.User.DTO.ExternalAPIModels.Response.RoleResponse, RoleResponse>().ReverseMap();
        CreateMap<AccessManagement.API.User.DTO.ExternalAPIModels.Request.RoleRequest, RoleRequest>().ReverseMap();
        CreateMap<AccessManagement.API.User.DTO.ExternalAPIModels.Embeded.AddressEmbeded, DTO.ExternalAPIModels.Embeded.AddressEmbeded>().ReverseMap();
        CreateMap<AccessManagement.API.User.DTO.ExternalAPIModels.Embeded.UserEmbeded, UserEmbeded>().ReverseMap();


    }
}
