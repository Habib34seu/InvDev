using System.ComponentModel.DataAnnotations.Schema;

namespace INV.Domain.Admin;

public class MasterMenuEntity : BaseEntity
{
    public required string MasterMenuName { get; set; }

    [ForeignKey("Companies")]
    public int CompanyId { get; set; }

    [ForeignKey("Users")]
    public int UserId { get; set; }
}
