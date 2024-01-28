using AccessManagement.API.User.DTO.InternalAPIModels.Embeded;
using AccessManagement.API.User.DTO.InternalAPIModels.Request;
using AccessManagement.API.User.DTO.InternalAPIModels.Response;
using AutoMapper;

namespace AccessManagement.API.User.Infrustructure.Configuration;

public class Mapper : Profile
{
    public Mapper()
    {
        // CreateMap<UserResponse, AccessManagement.API.User.Infrustructure.Entites.User>().ReverseMap();
        // CreateMap<AddressEmbeded, AccessManagement.API.User.Infrustructure.Entites.Address>().ReverseMap();
        CreateMap<AccessManagement.API.User.DTO.ExternalAPIModels.Response.UserResponse, UserResponse>().ReverseMap();
        CreateMap<AccessManagement.API.User.DTO.ExternalAPIModels.Request.UserRequest, UserRequest>().ReverseMap();
        CreateMap<AccessManagement.API.User.DTO.ExternalAPIModels.Embeded.AddressEmbeded, AddressEmbeded>().ReverseMap();

    }
}
