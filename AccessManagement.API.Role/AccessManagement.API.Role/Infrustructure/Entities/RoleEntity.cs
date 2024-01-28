using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessManagement.API.User.Infrustructure.Entites;

[Table("Role")]
public class RoleEntity
{

    [Key]
    public Guid RoleID { get; set; }
    public string Title { get; set; }
    public ICollection<UserEntity> Users { get; set; }
    public DateTime CreationDate { get; set; }
    public int CreatorId { get; set; }
}