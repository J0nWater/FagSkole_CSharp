namespace _1._1_IntroToNetV2;

class Program
{
    static void Main(string[] args)
    {
        var name = MyConsole.Ask("What is your name? ");
        var locastion = MyConsole.Ask("Where do you live? ");
        Console.WriteLine($"Hi, {name}. You live at {locastion}");
    }


}