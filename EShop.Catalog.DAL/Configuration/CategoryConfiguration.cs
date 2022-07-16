namespace EShop.Catalog.DAL.Configuration;

using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category
            {
                Id = new Guid("84ddb38f-8d9e-4e4b-9022-4085ced63475"),
                Name = "Pianos",
                Description = "Digital pianos for beginners and professionals.",
                CreatedAt = DateTime.Parse("2022-07-16 12:03:18.771764 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-16 12:03:18.771769 +00:00"),
            },
            new Category
            {
                Id = new Guid("4f71bda6-0fb9-4b45-aada-39e3bfd89548"),
                Name = "Guitars",
                Description = "Acoustic and electric guitars for beginners and professionals.",
                CreatedAt = DateTime.Parse("2022-07-16 12:03:18.771770 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-16 12:03:18.771771 +00:00"),
            },
            new Category
            {
                Id = new Guid("0aedc2cf-3338-44df-b346-37adc399acae"),
                Name = "Drums",
                Description = "Acoustic and electric drums for beginners and professionals.",
                CreatedAt = DateTime.Parse("2022-07-16 12:03:18.771771 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-16 12:03:18.771772 +00:00"),
            },
            new Category
            {
                Id = new Guid("b5718b16-3974-4949-a372-b8d93d2352f4"),
                Name = "Synthesizers",
                CreatedAt = DateTime.Parse("2022-07-16 12:03:18.771773 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-16 12:03:18.771773 +00:00"),
            },
            new Category
            {
                Id = new Guid("c547c364-5434-428f-803d-0fdd04f7d48e"),
                Name = "Accessories",
                CreatedAt = DateTime.Parse("2022-07-16 12:03:18.771774 +00:00"),
                UpdatedAt = DateTime.Parse("2022-07-16 12:03:18.771775 +00:00"),
            }
        );
    }
}