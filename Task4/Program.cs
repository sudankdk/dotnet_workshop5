namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        Console.WriteLine("Car:");
        myCar.StartEngine();
        myCar.StopEngine();

        Console.WriteLine();

        // Create object of Bike
        Bike myBike = new Bike();
        Console.WriteLine("Bike:");
        myBike.Display();
        myBike.StartEngine();
        myBike.StopEngine();    }
}