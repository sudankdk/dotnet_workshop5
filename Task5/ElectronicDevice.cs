namespace Task5;

public abstract class ElectronicDevice
{
    public string Brand { get; set; }
    public double Price { get; set; }

    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void ShowInfo();
}