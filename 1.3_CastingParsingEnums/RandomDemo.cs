namespace _1._3_CastingParsingEnums;

public class RandomDemo
{
    public static void Run()
    {
        var random = new Random();
        Console.WriteLine(random.Next(100, 200));
        Console.WriteLine(random.Next(100, 200));
        Console.WriteLine(random.Next(100, 200));
    }
}