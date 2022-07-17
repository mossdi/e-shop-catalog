namespace EShop.Catalog.DAL.Configuration;

using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product
            {
                Id = new Guid("D11CFE18-D46E-4C85-A726-DD41ACA37B99"),
                Name = "Kremona Rosa Morena",
                ManufacturerId = new Guid("B3964F15-DDCC-4582-BCCA-43EC7C31E1C2"),
                Description = "Part of Kremona's Flamenco Series, the Rosa Morena's subtle flamenco design elements " +
                              "enable snap and spontaneity, while its Indian rosewood and European spruce construct " +
                              "conveys the stately depth of a concert classical. Other appointments include a bone " +
                              "nut and saddle, wood binding and rosette, and a gold machines with pearloid buttons.",
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            },
            new Product
            {
                Id = new Guid("45458FA1-C499-4C60-B373-072D7FA12FB0"),
                Name = "Remo Mondo Djembe 14\" Adinkra",
                ManufacturerId = new Guid("03618B30-FFA1-44CB-8BD7-94E1BAB58ECE"),
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            },
            new Product
            {
                Id = new Guid("81675FFA-C0CD-4C60-BD12-8368F08DEDF4"),
                Name = "Casio Celviano AP-470",
                ManufacturerId = new Guid("13E22DC8-E1E1-489F-A618-9DAE375BDACE"),
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            },
            new Product
            {
                Id = new Guid("D2406749-4588-4C95-8849-E82C9A38768F"),
                Name = "Moog Subsequent 37",
                ManufacturerId = new Guid("C828B3D4-C478-427F-82D6-BFFC681626B9"),
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            },
            new Product
            {
                Id = new Guid("48E06835-984B-48BA-8DD7-97A99092C77D"),
                Name = "Remo Djembe Bag Deluxe 14\"",
                ManufacturerId = new Guid("03618B30-FFA1-44CB-8BD7-94E1BAB58ECE"),
                CreatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-17 10:03:18.771764 +00:00"),
            }
        );
    }
}