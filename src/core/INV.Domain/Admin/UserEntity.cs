using System.ComponentModel.DataAnnotations.Schema;

namespace INV.Domain.Admin;

public class UserEntity : BaseEntity
{
    public required string FirstName { get; set; }
    public string MiddleName { get; set; } = string.Empty;
    public required string LastName { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PhoneNo { get; set; } = string.Empty;
    public DateTime DofB { get; set; }
    public string PresentAddress { get; set; } = string.Empty;
    public string PresentPo { get; set; } = string.Empty;
    public string PresentThana { get; set; } = string.Empty;
    public string PermanentAddress { get; set; } = string.Empty;
    public string PermanentPo { get; set; } = string.Empty;
    public string PermanentThana { get; set; } = string.Empty;
    public string NID { get; set; } = string.Empty;
    public string PasportNo { get; set; } = string.Empty;
    public string BirthCertificate { get; set; } = string.Empty;

    [ForeignKey("Companies")]
    public int CompanyId { get; set; } 

}
