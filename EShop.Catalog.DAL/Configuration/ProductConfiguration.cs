using EShop.Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Catalog.DAL.Configuration;

using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        //
    }
}