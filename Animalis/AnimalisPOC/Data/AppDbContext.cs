using Animalis.Common;
using Microsoft.EntityFrameworkCore;

namespace AnimalisPOC.Data;

internal class AppDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }

    //public FoodImpactDbContext(DbContextOptions<FoodImpactDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Database=DatabaseTest; Username=postgres; Password=1234;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>().ToTable("animals");
    }
}