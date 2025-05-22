using System.Collections;
using interplanetary_delivery_simulator.planetary_resources.Utils;

namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class Planet
{
    public long Id { get; set; }
    public string Name { get; set; }
    public OrbitTelemetry Orbit { get; set; }
    public PlanetInformation Information { get; set; }
    
    public Planet(){ }

    public Planet(string name, OrbitTelemetry orbit, PlanetInformation info)
    {
        Name = name;
        Orbit = orbit;
        Information = info;
    }
}