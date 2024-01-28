using AccessManagement.API.User.DTO.InternalAPIModels.Embeded;

namespace AccessManagement.API.User.DTO.InternalAPIModels.Response;
public class UserResponse
{
    public Guid UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public AddressEmbeded Address { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime LastLogin { get; set; }
    public int ResponseCode { get; set; }
    public string ResponseMessage { get; set; }
}