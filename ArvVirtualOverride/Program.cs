// Arv, Virutal, Override, Klass-struktur:
using Vehicle;

var vehicles = new List<Vehicles>
{
    new Vehicles ("Generic", "Model X", 2010),
    new Car ("Volvo", "V70", 2018, 5),
    new Motorcycle ("Yamaha", "MT-07", 2021, false)
};

foreach(var vehicle in vehicles)
{
    Console.WriteLine(vehicle.GetInfo());
}