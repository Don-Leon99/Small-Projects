using System;

namespace Vehicle;

public class Car : Vehicles
{
    public int NumberOfDoors {get; set;}

    public Car(string brand, string model, int year, int numberOfDoors)
    : base (brand, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public string GetInfo()
    {
        return $"{base.GetInfo()} - {NumberOfDoors} doors";
    }
}