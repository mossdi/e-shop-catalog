namespace EShop.Catalog.DAL.Configuration;

using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasData(
            new ProductCategory
            {
                Id = new Guid("1B2F3B8E-CDDD-443A-A5FA-1833241D9168"),
                ProductId = new Guid("81675FFA-C0CD-4C60-BD12-8368F08DEDF4"),
                CategoryId = new Guid("84ddb38f-8d9e-4e4b-9022-4085ced63475"),
                CreatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
            },
            new ProductCategory
            {
                Id = new Guid("AEDDF5AB-4401-4CE7-AD9D-B870352F1232"),
                ProductId = new Guid("D11CFE18-D46E-4C85-A726-DD41ACA37B99"),
                CategoryId = new Guid("4f71bda6-0fb9-4b45-aada-39e3bfd89548"),
                CreatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
                
            },
            new ProductCategory
            {
                Id = new Guid("6526EB2E-3162-4100-B391-C03C638515B9"),
                ProductId = new Guid("45458FA1-C499-4C60-B373-072D7FA12FB0"),
                CategoryId = new Guid("0aedc2cf-3338-44df-b346-37adc399acae"),
                CreatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
            },
            new ProductCategory
            {
                Id = new Guid("B0DFAB09-EDF1-4B55-A055-1627FD2DB059"),
                ProductId = new Guid("D2406749-4588-4C95-8849-E82C9A38768F"),
                CategoryId = new Guid("b5718b16-3974-4949-a372-b8d93d2352f4"),
                CreatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
            },
            new ProductCategory
            {
                Id = new Guid("ABFE8F1F-093A-4851-9CF3-C832EA8ED923"),
                ProductId = new Guid("48E06835-984B-48BA-8DD7-97A99092C77D"),
                CategoryId = new Guid("c547c364-5434-428f-803d-0fdd04f7d48e"),
                CreatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 12:03:18.771764 +00:00"),
            }
        );
    }
}