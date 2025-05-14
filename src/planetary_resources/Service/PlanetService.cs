using interplanetary_delivery_simulator.planetary_resources.Entities;
using interplanetary_delivery_simulator.Data;

namespace interplanetary_delivery_simulator.planetary_resources.Service;

public class PlanetService : IPlanetService
{
    private readonly LunarLogisticsDbContext _solarSystemDbContext;

    public PlanetService(LunarLogisticsDbContext dbContext)
    {
        _solarSystemDbContext = dbContext;
    }
    
    public void AddDefaultPlanets(List<Planet> planets)
    {
        using var transaction = _solarSystemDbContext.Database.BeginTransaction();
        try
        {
            _solarSystemDbContext.Planets.RemoveRange(_solarSystemDbContext.Planets);
            _solarSystemDbContext.SaveChanges();
            _solarSystemDbContext.Planets.AddRange(planets);
            _solarSystemDbContext.SaveChanges();
            transaction.Commit();
        }
        catch (Exception)
        {
            transaction.Rollback();
        }
    }

    public Planet GetPlanet(string name)
    {
        var planet = _solarSystemDbContext.Planets.Find(name);
        if (planet == null) throw new Exception();
        return planet;
    }

    public long GetPlanetCount()
    {
        return _solarSystemDbContext.Planets.Count();
    }
}