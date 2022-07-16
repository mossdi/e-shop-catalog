namespace EShop.Catalog.DAL.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using Contracts;

internal class Category : BaseEntity
{
    [Column("name")]
    public string Name { get; set; }

    [Column("description")]
    public string Description { get; set; }
}