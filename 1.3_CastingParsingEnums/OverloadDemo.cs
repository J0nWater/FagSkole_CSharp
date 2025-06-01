namespace _1._3_CastingParsingEnums;

public class OverloadDemo
{
    public static void Run()
    {
        Greet("Gytis");
        Greet();
        SuperGreeting();
        SuperGreeting("Gytis");
    }

    public static void SuperGreeting(string name = "på deg")
    {
        Console.WriteLine($"Hei {name}");
    }
    public static void Greet(string name)
    {
        Console.WriteLine($"Hei, {name}!");
    }
    public static void Greet()
    {
        Console.WriteLine("Hei på deg");
    }
}