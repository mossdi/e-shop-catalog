namespace EShop.Catalog.DAL.Contracts;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

internal abstract class BaseEntity
{
    [Key]
    [Column("guid")]
    public Guid Guid { get; set; }

    [Column("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
    
    [Column("deleted_at")]
    public DateTimeOffset DeletedAt { get; set; }
}