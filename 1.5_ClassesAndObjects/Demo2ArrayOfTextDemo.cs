namespace _1._5_ClassesAndObjects;

public class Demo2ArrayOfTextDemo
{
    public static void Run()
    {
        var customTexts = new CustomText[]
        {
            new CustomText
            {
                Text = "Jon",
                Column = 3,
                Row = 10
            },
            new CustomText
            {
                Text = "Water",
                Column = 3,
                Row = 5
            }
        };

        foreach (var customText in customTexts)
        {
            Console.SetCursorPosition(customText.Column, customText.Row);
            Console.WriteLine(customText.Text);
        }
    }
}