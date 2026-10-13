// Interface
interface IMovable
{
    void Move();
}
interface ISpeaker
{
    string Speak();
}
class Dog : IMovable, ISpeaker
{
    public void Move()
    {
        Console.WriteLine("Hunden springer.");
    }
    public string Speak()
    {
        return "Voff!";
    }
}
class Robot : IMovable, ISpeaker
{
        public void Move()
    {
        Console.WriteLine("Roboten rullar.");
    }
    public string Speak()
    {
        return "Bip Bop!";
    }
}
class Rock : IMovable
{
    public void Move()
    {
        Console.WriteLine("Stenen rullar.");
    }
}
class Program
{
    static void MakeItMove(IMovable item)
    {
        item.Move();
    }
    static void MakeItSpeak(ISpeaker item)
    {
        item.Speak();
    }
    static void Main()
    {
        Dog dog = new Dog();
        Robot robot = new Robot();
        Rock rock = new Rock();

        MakeItMove(dog);
        MakeItMove(robot);
        MakeItMove(rock);

        MakeItSpeak(dog);
        MakeItSpeak(robot);

        List<IMovable> movingThings = new List<IMovable>
        {
          dog,
          robot,
          rock  
        };
        
        foreach(IMovable thing in movingThings)
        {
            thing.Move();
        }
    }
}