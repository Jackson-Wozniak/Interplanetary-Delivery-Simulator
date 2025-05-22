using interplanetary_delivery_simulator.planetary_resources.Entities;
using Microsoft.EntityFrameworkCore;

namespace interplanetary_delivery_simulator.Data;

public partial class LunarLogisticsDbContext
{
    public DbSet<Planet> Planets { get; set; }

    partial void ConfigureSolarSystem(ModelBuilder builder)
    {
        builder.Entity<Planet>(planet =>
        {
            planet.OwnsOne(p => p.Orbit, orbit =>
            {
                orbit.WithOwner();
                orbit.HasOne(o => o.OrbitsAround)
                    .WithMany()
                    .HasForeignKey("OrbitsAroundId")
                    .OnDelete(DeleteBehavior.Restrict);
            });
            planet.OwnsOne(p => p.Information);
        });
    }
}