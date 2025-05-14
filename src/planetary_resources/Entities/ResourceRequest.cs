namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class ResourceRequest
{
    private long Id { get; set; }
    private Planet Planet { get; set; }
    private CargoType CargoType { get; set; }
    private double PoundsOfCargo { get; set; }

    public ResourceRequest(Planet planet, CargoType cargo, double pounds)
    {
        Planet = planet;
        CargoType = cargo;
        PoundsOfCargo = pounds;
    }
}