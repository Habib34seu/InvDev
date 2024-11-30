
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INV.Domain;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool IsActive { get; set; }  
    public bool IsDelete { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public string CreatedDate { get; set; } = string.Empty;
    public string UpdatedBy { get; set; } = string.Empty;
    public string UpdatedDate { get; set; } = string.Empty;

}

public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Ignore(x => x.CreatedBy);
        builder.Ignore(x => x.CreatedDate);
        builder.Ignore(x => x.CreatedBy);
        builder.Ignore(x => x.UpdatedBy);
        builder.Ignore(x => x.UpdatedDate);
        builder.Ignore(x => x.IsActive);
        builder.Ignore(x => x.IsDelete);
        ConfigureDerivedEntity(builder);
    }

    protected abstract void ConfigureDerivedEntity(EntityTypeBuilder<T> builder);
}