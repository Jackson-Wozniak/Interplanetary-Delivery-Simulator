using interplanetary_delivery_simulator.planetary_resources.Enums;

namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class CargoType
{
    public String Name { get; set; }
    public double PricePerPound { get; set; }
    public CargoCategory Category { get; set; }

    public CargoType(String name, double price, CargoCategory category)
    {
        Name = name;
        PricePerPound = price;
        Category = category;
    }

    private void UpdateCategory()
    {
        
    }
}