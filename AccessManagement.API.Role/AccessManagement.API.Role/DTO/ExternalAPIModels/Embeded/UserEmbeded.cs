namespace AccessManagement.API.User.DTO.ExternalAPIModels.Embeded;
public class UserEmbeded
{
     public Guid UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public AddressEmbeded Addresses { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime LastLogin { get; set; }
}