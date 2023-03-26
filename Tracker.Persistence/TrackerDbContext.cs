using Microsoft.EntityFrameworkCore;
using Tracker.Domain.Entities;

namespace Tracker.Persistence;

public class TrackerDbContext : DbContext
{
    public TrackerDbContext(DbContextOptions<TrackerDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TrackerDbContext).Assembly);
    }
}