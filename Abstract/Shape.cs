using System;
using System.Runtime.InteropServices;

namespace Former;
public abstract class Shape
{
    public abstract double Area();
    public void Describe()
    {
        Console.WriteLine($"{GetType().Name} har arean {Area():F2}");
    }
}
class Circle : Shape
{
    public double Radius {get;}
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
class Rectangle : Shape
{
    public double Width {get;}
    public double Height {get;}
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double Area()
    {
        return Width * Height;
    }
}
class Triangle : Shape
{
    public double BaseLength {get;}
    public double Height {get;}
    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }
    public override double Area()
    {
        return BaseLength * Height / 2;
    }
}