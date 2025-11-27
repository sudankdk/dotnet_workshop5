namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        ElectronicStore store = new ElectronicStore();

        Laptop laptop1 = new Laptop("Hp", 60900);
        Smartphone phone1 = new Smartphone("Nokia", 80900);

        store.AddDevice(laptop1);
        store.AddDevice(phone1);

        store.ShowAllDeviceDetails();
    }
}