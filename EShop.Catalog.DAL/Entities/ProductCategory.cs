namespace EShop.Catalog.DAL.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using Contracts;

internal class ProductCategory : BaseEntity
{
    [Column("product_id")]
    public Guid ProductId { get; set; }
    
    [Column("category_id")]
    public Guid CategoryId { get; set; }
    
    public virtual Product Product { get; set; }
    
    public virtual Category Category { get; set; }
}