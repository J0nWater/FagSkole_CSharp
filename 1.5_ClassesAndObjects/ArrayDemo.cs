public class ArrayDemo
{
    public static void Run()
    {
        int[] numbers = [1, 2, 3, 4];
        bool[] booleans = [true, false, true];
        decimal[] decimals = [1.1m, 1.2m, 1.3m] ;
        
        string[] texts = new string[3];
        texts[0] = "Hei";
        texts[1] = "på";
        texts[2] = "deg";

        string[] texts2 = new string[] {"Hei", "på", "deg"};
        
        string[] texts3 = ["Hei", "på", "deg"];
    }
}