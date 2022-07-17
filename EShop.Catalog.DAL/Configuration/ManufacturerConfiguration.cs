namespace EShop.Catalog.DAL.Configuration;

using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
{
    public void Configure(EntityTypeBuilder<Manufacturer> builder)
    {
        builder.HasData(
            new Manufacturer
            {
                Id = new Guid("B3964F15-DDCC-4582-BCCA-43EC7C31E1C2"),
                Name = "Kremona",
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                
            },
            new Manufacturer
            {
                Id = new Guid("03618B30-FFA1-44CB-8BD7-94E1BAB58ECE"),
                Name = "Remo",
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            },
            new Manufacturer
            {
                Id = new Guid("13E22DC8-E1E1-489F-A618-9DAE375BDACE"),
                Name = "Casio",
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            },
            new Manufacturer
            {
                Id = new Guid("C828B3D4-C478-427F-82D6-BFFC681626B9"),
                Name = "Moog",
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            },
            new Manufacturer
            {
                Id = new Guid("990025A6-5D43-44EF-AAAE-76B158A0B61A"),
                Name = "Ableton",
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            }
        );
    }
}