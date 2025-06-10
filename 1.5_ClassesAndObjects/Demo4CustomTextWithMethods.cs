using _1._5_ClassesAndObjects.Demo4;

namespace _1._5_ClassesAndObjects;

public class Demo4CustomTextWithMethods
{
    public static void Run()
    {
        // var customText = new FancyCustomText
        // {
        //     Row = 1,
        //     Column = 3,
        //     Color = ConsoleColor.DarkBlue,
        //     Text = "Hallo"
        // };

        var customText = new FancyCustomText("Gytis", 3, 1, ConsoleColor.DarkBlue);
        
        customText.Show();

        Console.WriteLine("Programmet er ferdig!");
    }
} 