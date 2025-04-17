using Microsoft.EntityFrameworkCore;

namespace interplanetary_delivery_simulator;

public class LunarLogisticsDbContext : DbContext
{
    public LunarLogisticsDbContext(DbContextOptions<LunarLogisticsDbContext> options): base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        
    }
}