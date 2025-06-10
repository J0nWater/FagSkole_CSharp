namespace _1._5_ClassesAndObjects;

public class Demo1Object
{
    public static void Run()
    {
        var myTextA = new CustomText();
        myTextA.Text = "Jon";
        myTextA.Column = 10;
        myTextA.Row = 3;        
        
        var myTextB = new CustomText
        {
            Text = "Water",
            Column = 3,
            Row = 10
        };

        Console.SetCursorPosition(myTextA.Column, myTextA.Row);
        Console.WriteLine(myTextA.Text);        
        
        Console.SetCursorPosition(myTextB.Column, myTextB.Row);
        Console.WriteLine(myTextB.Text);
    }
}