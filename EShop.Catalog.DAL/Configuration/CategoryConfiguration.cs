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
                Name = "Pianos",
                Description = "Digital pianos for beginners and professionals.",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Category
            {
                Name = "Guitars",
                Description = "Acoustic and electric guitars for beginners and professionals.",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Category
            {
                Name = "Drums",
                Description = "Acoustic and electric drums for beginners and professionals.",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Category
            {
                Name = "Synthesizers",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            },
            new Category
            {
                Name = "Accessories",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            }
        );
    }
}