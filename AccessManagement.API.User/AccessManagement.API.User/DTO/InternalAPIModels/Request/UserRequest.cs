using System.ComponentModel.DataAnnotations;
using AccessManagement.API.User.DTO.ExternalAPIModels.Embeded;

namespace AccessManagement.API.User.DTO.ExternalAPIModels.Request;
public class UserRequest
{
    public Guid UserID { get; set; }
    [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
    public string Username { get; set; }
    [Required(ErrorMessage = "لطفاایمیل را وارد کنید")]
    public string Email { get; set; }
    [Required(ErrorMessage = "لطفا پسورد را وارد کنید")]
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public AddressEmbeded Address { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime LastLogin { get; set; }
}