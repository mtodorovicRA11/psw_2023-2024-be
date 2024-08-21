using Explorer.Tours.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Explorer.Tours.Core.Database;

public class ToursContext : DbContext
{
    public ToursContext(DbContextOptions<ToursContext> options) : base(options) {}
    public DbSet<Tour> Tours { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("tours");
    }
}