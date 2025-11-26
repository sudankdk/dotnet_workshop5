namespace Task3;

public class Printer
{
    public void Print(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    public void Print(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    public void Print(string message, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine(i + ". " + message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer();

        p.Print("Hello World");

        p.Print(123);

        p.Print("Repeat Message", 3);

        Console.ReadLine();
        
        
        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Ram";
        nepaliTeacher.Teaching();  
        nepaliTeacher.SalaryInfo(); 
        // English teacher object
        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Name = "John";
        englishTeacher.Teaching();  // Teacher teaches in English
        englishTeacher.SalaryInfo(); //
    }
}