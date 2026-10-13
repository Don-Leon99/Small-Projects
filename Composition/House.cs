using System;

namespace Hus;

class Room
{
    public string Name {get;}
    public double Area {get;}
    public Room(string name, double area)
    {
        Name = name;
        Area = area;
    }
}
public class House
{
    private readonly List<Room> _rooms;

    public House()
    {
        _rooms = new List<Room>
        {
            new Room("Kök", 15.5),
            new Room("Sovrum", 12.0),
            new Room("Badrum", 6.5)
        };
    }
    public double TotalArea()
    {
        double total = 0;
        foreach(Room room in _rooms)
        {
            total += room.Area;
        }
        return total;
    }

}
