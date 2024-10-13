using Animalis.Common;
using Microsoft.EntityFrameworkCore;

namespace AnimalisPOC.Data;

internal class AppDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>().ToTable("animals");
    }
}