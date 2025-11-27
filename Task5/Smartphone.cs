namespace Task5;

public class Smartphone: ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone - Brand: {Brand}, Price: {Price}");
    }

    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera enabled.");
    }
}

