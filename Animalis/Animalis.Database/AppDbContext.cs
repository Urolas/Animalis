using Animalis.Common;
using Microsoft.EntityFrameworkCore;

namespace Animalis.Database;

public class AppDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>().ToTable("animals");
    }
}