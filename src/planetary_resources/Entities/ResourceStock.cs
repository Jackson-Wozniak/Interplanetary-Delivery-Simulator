namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class ResourceStock
{
    public long Id { get; set; }
    public Planet Planet { get; set; }
    public CargoType CargoType { get; set; }
    public double CurrentWeight { get; set; }
    public double MinimumRequired { get; set; }
    public double PoundsUsedPerDay { get; set; }
}