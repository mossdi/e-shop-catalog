namespace EShopCore.DAL.Contracts;

using System.ComponentModel.DataAnnotations.Schema;

internal abstract class BaseEntity
{
    [Column("guid")]
    public Guid Guid { get; set; }

    [Column("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
    
    [Column("deleted_at")]
    public DateTimeOffset DeletedAt { get; set; }
}