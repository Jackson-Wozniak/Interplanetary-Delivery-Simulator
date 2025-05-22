using interplanetary_delivery_simulator.planetary_resources.Utils;

namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class PlanetInformation
{
    public PlanetType Type { get; set; }
    public long PersonCapacity { get; set; }
    public long PersonCount { get; set; }
}