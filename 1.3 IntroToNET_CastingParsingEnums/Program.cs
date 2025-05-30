namespace _1._3_IntroToNET_CastingParsingEnums;

class Program
{
    static void Main(string[] args)
    {
        var name = Ask("What is your name? ");
        var locastion = Ask("Where do you live? ");
        Console.WriteLine($"Hi, {name}. You live at {locastion}");
    }

    static string Ask(string question)
    {
        Console.Write(question);
        return Console.ReadLine();
    }
}