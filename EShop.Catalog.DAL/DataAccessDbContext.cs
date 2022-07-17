namespace EShop.Catalog.DAL;

using Configuration;
using Entities;
using Microsoft.EntityFrameworkCore;

internal class DataAccessDbContext: DbContext
{
    public DataAccessDbContext(DbContextOptions<DataAccessDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

        modelBuilder.Entity<Product>().ToTable(name: "products");
        modelBuilder.Entity<Category>().ToTable(name: "categories");
        modelBuilder.Entity<ProductCategory>().ToTable(name: "product_categories");
        modelBuilder.Entity<Manufacturer>().ToTable(name: "manufacturers");
    }
}
