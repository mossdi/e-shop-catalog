namespace EShopCore.DAL.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contracts;

internal class Profile : BaseEntity
{
    [Required]
    [Column("first_name")]
    public string FirstName { get; set; }

    [Required]
    [Column("last_name")]
    public string LastName { get; set; }
}