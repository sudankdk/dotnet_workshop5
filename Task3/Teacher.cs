namespace Task3;

public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public sealed void SalaryInfo()
    {
        Console.WriteLine("Teacher salary information");
    }
}

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine("Teacher teaches in Nepali");
    }
}

public class EnglishTeacher : Teacher
{
}