using interplanetary_delivery_simulator.planetary_resources.Entities;

namespace interplanetary_delivery_simulator.planetary_resources.DTOs;

public class PlanetDTO
{
    public string Name { get; set; }

    public PlanetDTO(Planet planet)
    {
        Name = planet.Name;
    }
}