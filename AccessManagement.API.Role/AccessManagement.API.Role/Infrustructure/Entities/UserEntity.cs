using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessManagement.API.User.Infrustructure.Entites;

[Table("User")]
public class UserEntity
{

    [Key]
    public Guid UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    [StringLength(50)]
    public string FirstName { get; set; }
    [StringLength(50)]
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<AddressEntity> Addresses { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime LastLogin { get; set; }
}