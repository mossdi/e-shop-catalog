namespace EShop.Catalog.DAL;

using Entities;
using Microsoft.EntityFrameworkCore;

internal class DataAccessDbContext: DbContext
{
    public DataAccessDbContext(DbContextOptions<DataAccessDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Users { get; set; }
    public DbSet<Category> Profiles { get; set; }
    public DbSet<ProductCategory> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().ToTable(name: "products");
        modelBuilder.Entity<Category>().ToTable(name: "categories");
        modelBuilder.Entity<ProductCategory>().ToTable(name: "roles");
    }
}
