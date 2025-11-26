namespace Task2;

public class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }
    
    public void Start()
    {
        Console.WriteLine("Vehicle starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopping...");
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Speed: {Speed}");
    }
}

public class Car : Vehicle
{
    public string Seat { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seat: {Seat}");
    }
}

public class Motorcycle : Vehicle
{
    public string Engine { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Engine: {Engine}");
    }
}