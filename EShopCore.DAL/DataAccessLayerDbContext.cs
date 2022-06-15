namespace EShopCore.DAL;

using Entities;
using Microsoft.EntityFrameworkCore;

internal class DataAccessLayerDbContext: DbContext
{
    public DataAccessLayerDbContext(DbContextOptions<DataAccessLayerDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable(name: "users");
        modelBuilder.Entity<Profile>().ToTable(name: "profiles");
        modelBuilder.Entity<Role>().ToTable(name: "roles");
        modelBuilder.Entity<UserRole>().ToTable(name: "user_roles");
    }
}
