namespace _1._3_CastingParsingEnums;

public class ConvertDemo
{
    public static void Run()
    {
        double d = 5.5;
        int i = (int)d;

        int upperCaseANumber = 65;
        char c = (char)upperCaseANumber;

        int i2 = int.Parse("123");
        int i3 = Convert.ToInt32("123");
        
        bool wasParsed = int.TryParse("122", out int parsedNumber);
        if (wasParsed)
        {
            Console.WriteLine($"{parsedNumber}");
        }
        
        Console.WriteLine($"i={i}");
        Console.WriteLine($"c={c}");
    }
}