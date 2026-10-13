using System;

namespace Vehicle;

public class Vehicles
{
    public string Brand {get; set;} = "";
    public string Model {get; set;} = "";
    public int Year {get; set;}

    public Vehicles(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public string GetInfo()
    {
        return $"{Brand} {Model} ({Year})";
    }
}
