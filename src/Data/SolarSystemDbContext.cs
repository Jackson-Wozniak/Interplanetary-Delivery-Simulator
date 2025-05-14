using interplanetary_delivery_simulator.planetary_resources.Entities;
using Microsoft.EntityFrameworkCore;

namespace interplanetary_delivery_simulator.Data;

public partial class LunarLogisticsDbContext
{
    public DbSet<Planet> Planets { get; set; }

    partial void ConfigureSolarSystem(ModelBuilder builder)
    {
        
    }
}