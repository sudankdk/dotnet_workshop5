namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        var car = new Car
        {
            Brand = "Toyota",
            Speed = 120,
            Seat = "Leather"
        };

        car.DisplayInfo();

        var bike = new Motorcycle
        {
            Brand = "Yamaha",
            Speed = 150,
            Engine = "250cc"
        };

        bike.DisplayInfo();

    }
}