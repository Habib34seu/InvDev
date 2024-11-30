

namespace INV.Domain.Admin;

public class ComapnyEntity : BaseEntity
{
    public required string CompanyName { get; set; }
    public required string Address { get; set; }
    public required string Email { get; set; }
    public required string ContractPerson { get; set; }
    public required string PhoneNo { get; set; }
   
}
