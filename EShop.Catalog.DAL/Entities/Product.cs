namespace EShop.Catalog.DAL.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using Contracts;

public class Product : BaseEntity
{
    [Column("name")]
    public string Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }
}