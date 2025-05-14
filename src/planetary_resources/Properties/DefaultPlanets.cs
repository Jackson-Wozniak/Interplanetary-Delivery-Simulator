using interplanetary_delivery_simulator.planetary_resources.Entities;

namespace interplanetary_delivery_simulator.planetary_resources.Properties;

public class DefaultPlanets
{
    public static List<Planet> AllPlanets()
    {
        List<Planet> planets = new List<Planet>();
        planets.Add(Planet.Colony("Earth", 0, 10_000_000_000, 7_000_000_000));

        return planets;
    }
}