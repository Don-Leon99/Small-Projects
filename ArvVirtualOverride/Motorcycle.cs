using System;

namespace Vehicle;

public class Motorcycle : Vehicles
{
    public bool HasSideCar {get; set;}

    public Motorcycle(string brand, string model, int year, bool hasSideCar)
    : base (brand, model, year)
    {
        HasSideCar = hasSideCar;
    }
    public string GetInfo()
    {
        return $"{base.GetInfo()} - {HasSideCar} sidecar";
    }
}
