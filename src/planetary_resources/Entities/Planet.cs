using System.Collections;
using interplanetary_delivery_simulator.planetary_resources.Utils;

namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class Planet
{
    public long Id { get; set; }
    public string Name { get; set; }
    public double MilesFromEarth { get; set; }
    public PlanetType Type { get; set; }
    public long PersonCapacity { get; set; }
    public long PersonCount { get; set; }
    public List<ResourceRequest> ResourceRequests = new List<ResourceRequest>();
    
    public Planet(){ }

    private Planet(string name, double milesFromEarth, PlanetType type, long capacity, long count)
    {
        Name = name;
        MilesFromEarth = milesFromEarth;
        Type = type;
        PersonCapacity = capacity;
        PersonCount = count;
    }

    public static Planet Colony(string name, double milesFromEarth, long capacity, long startingCount)
    {
        return new Planet(name, milesFromEarth, PlanetType.COLONY, capacity, startingCount);
    }
}