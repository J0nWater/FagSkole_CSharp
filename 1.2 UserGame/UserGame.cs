namespace _1._2_UserGame;

internal class UserGame
{
    public UserGame()
    {
        Run();
    }
    public static void Run()
    {
        string? name = null;
        string? age = null;
        while (true)
        {
            Console.WriteLine("""
                              Wellcome to program.
                              1) Enter name
                              2) Enter age
                              3) Quit
                              """);
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                {
                    Console.WriteLine("What is your name? ");
                    name = Console.ReadLine();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("What is your age? ");
                    age = Console.ReadLine();
                    break;
                }
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(age))
            {
                Console.WriteLine($"Your name is {name}, you are {age} years old.");
            }
        }
    }
}