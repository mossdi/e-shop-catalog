namespace EShopCore.DAL.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contracts;

internal class UserRole : BaseEntity
{
    [Required]
    [Column("user_guid")]
    public Guid UserGuid { get; set; }
    
    [Required]
    [Column("role_guid")]
    public Guid RoleGuid { get; set; }
}