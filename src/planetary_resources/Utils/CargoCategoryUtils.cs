using System.Diagnostics;
using interplanetary_delivery_simulator.planetary_resources.Entities;
using interplanetary_delivery_simulator.planetary_resources.Enums;

namespace interplanetary_delivery_simulator.planetary_resources.Utils;

public class CargoCategoryUtils
{
    public static CargoCategory CategoryFromType(string type)
    {
        switch (type.ToUpper())
        {
            case "BUILDING TOOLS" : return CargoCategory.CONSTRUCTION;
            case "GLASS": return CargoCategory.CONSTRUCTION;
            case "CONCRETE": return CargoCategory.CONSTRUCTION;
            
            case "FOOD": return CargoCategory.FOOD;
            case "WATER": return CargoCategory.FOOD;
            
            case "GAS": return CargoCategory.FUEL;
            case "OIL": return CargoCategory.FUEL;
            case "URANIUM": return CargoCategory.FUEL;
            
            case "ROVER": return CargoCategory.VEHICLE;
            case "BUGGY": return CargoCategory.VEHICLE;
            case "LIFE POD": return CargoCategory.VEHICLE;
            
            default: return CargoCategory.OTHER;
        }
    }
}