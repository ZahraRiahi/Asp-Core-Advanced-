using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessManagement.API.User.Infrustructure.Entites;
[Table("Address")]
public class AddressEntity
{
    [Key]
    public Guid AddressID { get; set; }
    [ForeignKey("User")]
    public Guid UserID { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string Street { get; set; }
}