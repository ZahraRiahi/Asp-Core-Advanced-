using AccessManagement.API.User.DTO.ExternalAPIModels.Embeded;

namespace AccessManagement.API.User.DTO.ExternalAPIModels.Response;
public class RoleResponse
{
      public Guid RoleID { get; set; }
    public string Title { get; set; }
    public  UserEmbeded Users { get; set; }
    public DateTime CreationDate { get; set; }
    public int CreatorId { get; set; }
}