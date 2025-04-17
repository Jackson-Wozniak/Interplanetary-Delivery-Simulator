using Microsoft.EntityFrameworkCore;

namespace interplanetary_delivery_simulator.Data;

public partial class LunarLogisticsDbContext : DbContext
{
    partial void ConfigureSolarSystem(ModelBuilder builder);
    
    public LunarLogisticsDbContext(DbContextOptions<LunarLogisticsDbContext> options): base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        ConfigureSolarSystem(builder);
    }
}