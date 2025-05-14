using interplanetary_delivery_simulator.planetary_resources.Enums;
using interplanetary_delivery_simulator.planetary_resources.Utils;

namespace interplanetary_delivery_simulator.planetary_resources.Entities;

public class CargoType
{
    public string Name { get; set; }
    public double PricePerPound { get; set; }
    public CargoCategory Category { get; set; }

    public CargoType(string name, double price)
    {
        Name = name;
        PricePerPound = price;
        UpdateCategory();
    }

    private void UpdateCategory()
    {
        Category = CargoCategoryUtils.CategoryFromType(Name);
    }
}