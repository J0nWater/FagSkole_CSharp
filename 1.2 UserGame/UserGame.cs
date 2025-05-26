namespace _1._2_UserGame;

internal class UserGame
{
    public static void Run()
    {
        var name = "";
        int age = 0;
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
                    var ageInput = Console.ReadLine();
                    age = int.Parse(ageInput);
                    break;
                }
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            if (name != "" && age != 0)
            {
                Console.WriteLine($"Your name is {name}, you are {age} years old.");
            }
        }
    }
}