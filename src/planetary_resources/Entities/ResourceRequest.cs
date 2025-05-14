namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class ResourceRequest
{
    public long Id { get; set; }
    public Planet Planet { get; set; }
    public CargoType CargoType { get; set; }
    public double PoundsOfCargo { get; set; }

    public ResourceRequest(Planet planet, CargoType cargo, double pounds)
    {
        Planet = planet;
        CargoType = cargo;
        PoundsOfCargo = pounds;
    }
}