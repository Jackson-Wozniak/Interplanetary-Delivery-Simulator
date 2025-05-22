using interplanetary_delivery_simulator.planetary_resources.Entities;
using interplanetary_delivery_simulator.planetary_resources.Utils;

namespace interplanetary_delivery_simulator.planetary_resources.Properties;

public class DefaultPlanets
{
    private static readonly Planet THE_SUN = new Planet(
        "The Sun", 
        new OrbitTelemetry
        {
            XCoordinate = 0,
            YCoordinate = 0,
            OrbitsAround = THE_SUN,
            EarthMasses = 332900
        },
        new PlanetInformation
        {
            Type = PlanetType.STAR,
            PersonCapacity = 0,
            PersonCount = 0
        });
    
    public static List<Planet> AllPlanets()
    {
        List<Planet> planets = new List<Planet>
        {
            THE_SUN
        };

        return planets;
    }
}