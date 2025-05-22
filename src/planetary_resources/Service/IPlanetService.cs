using interplanetary_delivery_simulator.planetary_resources.Entities;

namespace interplanetary_delivery_simulator.planetary_resources.Service;

public interface IPlanetService
{
    void AddDefaultPlanets(List<Planet> planets);
    Planet FindPlanet(string name);
    Task<List<Planet>> FindAllPlanets();
    long FindPlanetCount();
}