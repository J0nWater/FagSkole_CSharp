// Console.WriteLine("Hello, World!");

string[] array = new string[2];
array[0] = "1";
array[1] = "2";

string[] array2 = ["1", "2"];

string[] array3 = new string[]
{
    "1",
    "2"
};

foreach (var x in array2)
{
    Console.WriteLine(x);
}