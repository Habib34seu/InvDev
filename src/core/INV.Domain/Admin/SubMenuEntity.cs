using System.ComponentModel.DataAnnotations.Schema;

namespace INV.Domain.Admin;

public class SubMenuEntity : BaseEntity
{
    public int SubMenuName { get; set; }

    [ForeignKey("MasterMenus")]
    public int MasterMenuId { get; set; }
}
