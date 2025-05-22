using interplanetary_delivery_simulator.planetary_resources.Entities;
using interplanetary_delivery_simulator.Data;
using Microsoft.EntityFrameworkCore;

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
            foreach (var planet in planets)
            {
                if (_solarSystemDbContext.Planets.Find(planet.Name) == null)
                {
                    _solarSystemDbContext.Planets.Add(planet);
                }
            }
            transaction.Commit();
        }
        catch (Exception)
        {
            transaction.Rollback();
        }
    }

    public Planet FindPlanet(string name)
    {
        var planet = _solarSystemDbContext.Planets.Find(name);
        if (planet == null) throw new Exception();
        return planet;
    }

    public Task<List<Planet>> FindAllPlanets()
    {
        return _solarSystemDbContext.Planets.ToListAsync();
    }

    public long FindPlanetCount()
    {
        return _solarSystemDbContext.Planets.Count();
    }
}