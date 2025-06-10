namespace _1._5_ClassesAndObjects.Demo4;

public class FancyCustomText
{
    public string Text;
    public int Column;
    public int Row;
    public ConsoleColor Color;

    public FancyCustomText(string text, int column, int row, ConsoleColor color)
    {
        Text = text;
        Column = column;
        Row = row;
        Color = color;
    }

    public void Show()
    {
        Console.SetCursorPosition(Column, Row);
        Console.ForegroundColor = Color;
        Console.WriteLine(Text);
        Console.ResetColor();
    }
}