namespace Task4;

public abstract class Vehicle
{
   public  abstract void StartEngine();
   public abstract void StopEngine();
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car is starting...");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car is stopping...");
    }
}

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike is starting...");
    }

    public void Display()
    {
        Console.WriteLine("Boom Boom");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike is stopping...");
    }
}